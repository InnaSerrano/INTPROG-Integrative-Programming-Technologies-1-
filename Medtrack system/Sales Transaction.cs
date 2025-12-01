using MySql.Data.MySqlClient;

namespace InventoryAndSales
{
    public partial class Sales_Transaction : Form
    {
        public object ID { get; private set; }

        public Sales_Transaction()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string medicineID = txtID.Text.Trim(); // Get MedicineID from the user input

            if (string.IsNullOrEmpty(medicineID))
            {
                MessageBox.Show("Please enter a Medicine ID.");
                return;
            }

            string connString = "server=localhost;userid=root;password=;database=pharmacy_inventorys;";
            string query = "SELECT MedicineID, BrandName, GenericName, Unit, UsedFor FROM medicine WHERE MedicineID = @MedicineID";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicineID", medicineID);

                    try
                    {
                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtBrandName.Text = reader["BrandName"].ToString();
                                txtGenericName.Text = reader["GenericName"].ToString();
                                txtUnit.Text = reader["Unit"].ToString();
                                txtUsed.Text = reader["UsedFor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No medicine found with that ID.");
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error while searching: " + ex.Message);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            DateTime boughtDate = dtpBought.Value.Date;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the customer's name.");
                return;
            }

            if (!ValidateInputs(out int qty, out decimal price, out decimal cash))
            {
                return;
            }

            decimal total = qty * price;
            decimal discount = total * 0.20m;
            decimal finalAmount = total - discount;

            if (cash < finalAmount)
            {
                MessageBox.Show("Cash provided is not enough to complete the transaction.");
                return;
            }

            decimal change = cash - finalAmount;

            txtTotal.Text = total.ToString("F2");
            txtDiscount.Text = discount.ToString("F2");
            txtChange.Text = change.ToString("F2");

            string connString = "server=localhost;userid=root;password=;database=pharmacy_inventorys;";

            string salesQuery = "INSERT INTO sales (`CustomerName`, `Quantity`, `DateBought`, `Price`, `Total`, `CashEntered`, `Discount`, `ChangeAmount`) " +
                                "VALUES (@Name, @Quantity, @DateBought, @Price, @Total, @Cash, @Discount, @Change)";

            string transactionQuery = "INSERT INTO transaction (`CustomerName`, `Quantity`, `Price`, `DateBought`) " +
                                      "VALUES ( @Name, @Quantity, @Price, @DateBought)";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {   
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(salesQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Quantity", qty);
                        cmd.Parameters.AddWithValue("@DateBought", boughtDate);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@Cash", cash);
                        cmd.Parameters.AddWithValue("@Discount", discount);
                        cmd.Parameters.AddWithValue("@Change", change);

                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand transCmd = new MySqlCommand(transactionQuery, conn))
                    {
                        
                       
                        transCmd.Parameters.AddWithValue("@Name", name);
                        transCmd.Parameters.AddWithValue("@Quantity", qty);
                        transCmd.Parameters.AddWithValue("@Price", price);
                        transCmd.Parameters.AddWithValue("@DateBought", boughtDate);

                        transCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Transaction saved successfully.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error saving transaction: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out int qty, out decimal price, out decimal cash))
            {
                return;
            }

            decimal total = qty * price;
            decimal discount = total * 0.20m;
            decimal finalAmount = total - discount;

            if (cash < finalAmount)
            {
                MessageBox.Show("Cash provided is not enough to cover the discounted total.");
                return;
            }

            decimal change = cash - finalAmount;

            txtTotal.Text = total.ToString("F2");
            txtDiscount.Text = discount.ToString("F2");
            txtChange.Text = change.ToString("F2");
        }

        private bool ValidateInputs(out int qty, out decimal price, out decimal cash)
        {
            qty = 0;
            price = 0;
            cash = 0;

            string qtyText = txtQty.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            string cashText = txtCash.Text.Trim();

            if (string.IsNullOrEmpty(qtyText) ||
                string.IsNullOrEmpty(priceText) ||
                string.IsNullOrEmpty(cashText))
            {
                MessageBox.Show("Please enter Quantity, Price, and Cash.");
                return false;
            }

            if (!int.TryParse(qtyText, out qty) ||
                !decimal.TryParse(priceText, out price) ||
                !decimal.TryParse(cashText, out cash))
            {
                MessageBox.Show("Invalid number input for Quantity, Price, or Cash.");
                return false;
            }

            return true;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void Sales_Transaction_Load(object sender, EventArgs e)
        {

        }
    }
}

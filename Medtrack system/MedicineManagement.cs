namespace InventoryAndSales
{
    public partial class MedicineManagement : Form
    {
        public MedicineManagement()
        {
            InitializeComponent();
        }

        private void MedicineManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ID = txtMedicineID.Text.Trim();
            string B_NAME = txtBrandName.Text.Trim();
            string G_NAME = txtGenericName.Text.Trim();
            string Unit = txtUnit.Text.Trim();
            string USED_FOR = txtUsedFor.Text.Trim();
            string quantityText = cboQuantity.Text.Trim();
            string PricePerUnit = txtPricePerUnit.Text.Trim();

            if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(B_NAME) ||
                string.IsNullOrEmpty(G_NAME) || string.IsNullOrEmpty(USED_FOR) ||
                string.IsNullOrEmpty(quantityText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(quantityText, out int quantity))
            {
                MessageBox.Show("Quantity must be a number.");
                return;
            }

            DateTime dtpArriveValue = dtpArrive.Value.Date;
            DateTime dtpExpiryValue = dtpExpiry.Value.Date;

            string connString = "server=localhost;userid=root;password=;database=pharmacy_inventorys;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string medicineQuery = "INSERT INTO medicine (MedicineID, BrandName, GenericName, Unit, UsedFor) " +
                                               "VALUES (@ID, @BName, @GName, @Unit, @UsedFor)";
                        using (MySqlCommand cmd = new MySqlCommand(medicineQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ID", ID);
                            cmd.Parameters.AddWithValue("@BName", B_NAME);
                            cmd.Parameters.AddWithValue("@GName", G_NAME);
                            cmd.Parameters.AddWithValue("@Unit", Unit);
                            cmd.Parameters.AddWithValue("@UsedFor", USED_FOR);
                            cmd.ExecuteNonQuery();
                        }

                        string inventoryQuery = "INSERT INTO inventory (MedicineID, Quantity, ArriveDate, ExpiryDate, PricePerUnit) " +
                                                "VALUES (@ID, @Quantity, @Arrive, @Expiry, @Price)";
                        using (MySqlCommand invCmd = new MySqlCommand(inventoryQuery, conn, transaction))
                        {
                            invCmd.Parameters.AddWithValue("@ID", ID);
                            invCmd.Parameters.AddWithValue("@Quantity", quantity);
                            invCmd.Parameters.AddWithValue("@Arrive", dtpArriveValue);
                            invCmd.Parameters.AddWithValue("@Expiry", dtpExpiryValue);
                            invCmd.Parameters.AddWithValue("@Price", PricePerUnit);
                            invCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Medicine and inventory saved successfully.");
                        btnClear.PerformClick();
                    }
                    catch (MySqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error saving data: " + ex.Message);
                    }
            }
        }
     }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedicineID.Clear();
            txtBrandName.Clear();
            txtGenericName.Clear();
            txtUsedFor.Clear();
            cboQuantity.SelectedIndex = -1;
            dtpArrive.Value = DateTime.Now;
            dtpExpiry.Value = DateTime.Now;

        }

        private void dtpArrived_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMedicineID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

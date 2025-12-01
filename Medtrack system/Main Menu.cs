using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAndSales
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            MedicineManagement medManagement = new MedicineManagement();
            medManagement.Show();
            this.Hide();
        }

        private void btnViewmed_Click(object sender, EventArgs e)
        {
            SearchAndDisplay view = new SearchAndDisplay();
            view.Show();
            this.Hide();
        }

        private void btnSellmed_Click(object sender, EventArgs e)
        {
            Sales_Transaction sales = new Sales_Transaction();
            sales.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
            this.Hide();
        }
    }
}

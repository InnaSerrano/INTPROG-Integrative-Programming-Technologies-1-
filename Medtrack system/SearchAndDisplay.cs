using MySql.Data.MySqlClient;
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
    public partial class SearchAndDisplay : Form
    {
        public SearchAndDisplay()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                
                MessageBox.Show("Please enter a search term.");
                return;
            }

            string connString = "server=localhost;userid=root;password=;database=pharmacy_inventorys;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"SELECT * FROM medicine
                         WHERE MedicineID LIKE @search 
                         OR BrandName LIKE @search 
                         OR GenericName LIKE @search";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    try
                    {
                        conn.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRecords.DataSource = dt;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Search failed: " + ex.Message);
                    }
                }
            }
        }

        private void dgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {            
            string connString = "server=localhost;userid=root;password=;database=pharmacy_inventorys;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT * FROM medicine";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRecords.DataSource = dt;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Failed to load records: " + ex.Message);
                    }
                }
            }
        }

        private void btnAscending_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;userid=root;password=;database=pharmacy_inventorys;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT * FROM Medicine ORDER BY MedicineID ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRecords.DataSource = dt;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Sort failed: " + ex.Message);
                    }
                }
            }
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;userid=root;password=;database=pharmacy_inventorys;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT * FROM medicine ORDER BY MedicineID DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRecords.DataSource = dt;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Sort failed: " + ex.Message);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }
    }

}

using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SSM
{
    public partial class EditDevices : Form
    {
        string databasePath = @"Data Source=C:\Users\Admin\source\repos\SSM\bin\Debug\database.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        private int selectedRowIndex = -1;

        public EditDevices()
        {
            InitializeComponent();
            this.Load += EditDevices_Load;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            btnAddDevice.Click += btnAddDevice_Click;
            btnEditDevice.Click += btnEditDevice_Click;
            btnDeleteDevice.Click += btnDeleteDevice_Click;
        }

        private void EditDevices_Load(object sender, EventArgs e)
        {
            data_show();
        }

        private void data_show()
        {
            try
            {
                dataGridView1.Rows.Clear();
                con = new SQLiteConnection(databasePath);
                con.Open();

                string q = "SELECT * FROM Devices";
                cmd = new SQLiteCommand(q, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["id"], dr["vendor"], dr["model"], dr["ip"], dr["purchase_date"], dr["responsible"]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_vendor.Text = row.Cells["vendor"].Value.ToString();
                textBox_model.Text = row.Cells["model"].Value.ToString();
                textBox_ip.Text = row.Cells["ip"].Value.ToString();
                textBox_purchaseDate.Text = row.Cells["purchase_date"].Value.ToString();
                textBox_responsible.Text = row.Cells["responsible"].Value.ToString();
                selectedRowIndex = e.RowIndex; // Speichern des Index der ausgewählten Zeile
            }
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_vendor.Text) && !string.IsNullOrEmpty(textBox_model.Text))
                {
                    using (var connection = new SQLiteConnection(databasePath))
                    {
                        connection.Open();

                        string insertQuery = @"
                            INSERT INTO Devices (vendor, model, ip, purchase_date, responsible) 
                            VALUES (@Vendor, @Model, @Ip, @PurchaseDate, @Responsible)";
                        using (var command = new SQLiteCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Vendor", textBox_vendor.Text);
                            command.Parameters.AddWithValue("@Model", textBox_model.Text);
                            command.Parameters.AddWithValue("@Ip", textBox_ip.Text);
                            command.Parameters.AddWithValue("@PurchaseDate", textBox_purchaseDate.Text);
                            command.Parameters.AddWithValue("@Responsible", textBox_responsible.Text);
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Device added successfully!");
                        data_show(); // Daten neu laden
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both Vendor and Model.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnEditDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    using (var connection = new SQLiteConnection(databasePath))
                    {
                        connection.Open();

                        string updateQuery = @"
                            UPDATE Devices 
                            SET vendor = @Vendor, model = @Model, ip = @Ip, purchase_date = @PurchaseDate, responsible = @Responsible 
                            WHERE id = @Id";
                        using (var command = new SQLiteCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Vendor", textBox_vendor.Text);
                            command.Parameters.AddWithValue("@Model", textBox_model.Text);
                            command.Parameters.AddWithValue("@Ip", textBox_ip.Text);
                            command.Parameters.AddWithValue("@PurchaseDate", textBox_purchaseDate.Text);
                            command.Parameters.AddWithValue("@Responsible", textBox_responsible.Text);
                            command.Parameters.AddWithValue("@Id", Convert.ToInt32(selectedRow.Cells["id"].Value));
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Device updated successfully!");
                        data_show(); // Daten neu laden
                        selectedRowIndex = -1; // Zurücksetzen des Index nach dem Speichern
                    }
                }
                else
                {
                    MessageBox.Show("No row selected. Please select a row to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    using (var connection = new SQLiteConnection(databasePath))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Devices WHERE id = @Id";
                        using (var command = new SQLiteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", Convert.ToInt32(selectedRow.Cells["id"].Value));
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Device deleted successfully!");
                        data_show(); // Daten neu laden
                        selectedRowIndex = -1; // Zurücksetzen des Index nach dem Löschen
                    }
                }
                else
                {
                    MessageBox.Show("No row selected. Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            textBox_vendor.Clear();
            textBox_model.Clear();
            textBox_ip.Clear();
            textBox_purchaseDate.Clear();
            textBox_responsible.Clear();
        }
    }
}

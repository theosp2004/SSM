using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SSM
{
    public partial class EditHosts : Form
    {
        string databasePath = @"Data Source=C:\Users\Admin\source\repos\SSM\bin\Debug\database.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        private int selectedRowIndex = -1;

        public EditHosts()
        {
            InitializeComponent();
            this.Load += EditHosts_Load;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            btnAddHost.Click += btnAddHost_Click;
            btnEditHost.Click += btnEditHost_Click;
            btnDeleteHost.Click += btnDeleteHost_Click;
        }

        private void EditHosts_Load(object sender, EventArgs e)
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

                string q = "SELECT * FROM Hosts";
                cmd = new SQLiteCommand(q, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["id"], dr["host_name"], dr["serial_number"], dr["host_ip"], dr["os_version"], dr["description"], dr["purchase_date"], dr["plant_fk_name"], dr["server_rack_fk_name"]);
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
                textBox_hostName.Text = row.Cells["host_name"].Value.ToString();
                textBox_serialNumber.Text = row.Cells["serial_number"].Value.ToString();
                textBox_hostIp.Text = row.Cells["host_ip"].Value.ToString();
                textBox_osVersion.Text = row.Cells["os_version"].Value.ToString();
                textBox_description.Text = row.Cells["description"].Value.ToString();
                textBox_purchaseDate.Text = row.Cells["purchase_date"].Value.ToString();
                textBox_plantFkName.Text = row.Cells["plant_fk_name"].Value.ToString();
                textBox_serverRackFkName.Text = row.Cells["server_rack_fk_name"].Value.ToString();
                selectedRowIndex = e.RowIndex; // Speichern des Index der ausgewählten Zeile
            }
        }

        private void btnAddHost_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_hostName.Text) && !string.IsNullOrEmpty(textBox_hostIp.Text))
                {
                    using (var connection = new SQLiteConnection(databasePath))
                    {
                        connection.Open();

                        string insertQuery = @"
                            INSERT INTO Hosts (host_name, serial_number, host_ip, os_version, description, purchase_date, plant_fk_name, server_rack_fk_name) 
                            VALUES (@HostName, @SerialNumber, @HostIp, @OsVersion, @Description, @PurchaseDate, @PlantFkName, @ServerRackFkName)";
                        using (var command = new SQLiteCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@HostName", textBox_hostName.Text);
                            command.Parameters.AddWithValue("@SerialNumber", textBox_serialNumber.Text);
                            command.Parameters.AddWithValue("@HostIp", textBox_hostIp.Text);
                            command.Parameters.AddWithValue("@OsVersion", textBox_osVersion.Text);
                            command.Parameters.AddWithValue("@Description", textBox_description.Text);
                            command.Parameters.AddWithValue("@PurchaseDate", textBox_purchaseDate.Text);
                            command.Parameters.AddWithValue("@PlantFkName", textBox_plantFkName.Text);
                            command.Parameters.AddWithValue("@ServerRackFkName", textBox_serverRackFkName.Text);
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Host added successfully!");
                        data_show(); // Daten neu laden
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both Host Name and Host IP.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnEditHost_Click(object sender, EventArgs e)
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
                            UPDATE Hosts 
                            SET host_name = @HostName, serial_number = @SerialNumber, host_ip = @HostIp, os_version = @OsVersion, 
                                description = @Description, purchase_date = @PurchaseDate, plant_fk_name = @PlantFkName, server_rack_fk_name = @ServerRackFkName 
                            WHERE id = @Id";
                        using (var command = new SQLiteCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@HostName", textBox_hostName.Text);
                            command.Parameters.AddWithValue("@SerialNumber", textBox_serialNumber.Text);
                            command.Parameters.AddWithValue("@HostIp", textBox_hostIp.Text);
                            command.Parameters.AddWithValue("@OsVersion", textBox_osVersion.Text);
                            command.Parameters.AddWithValue("@Description", textBox_description.Text);
                            command.Parameters.AddWithValue("@PurchaseDate", textBox_purchaseDate.Text);
                            command.Parameters.AddWithValue("@PlantFkName", textBox_plantFkName.Text);
                            command.Parameters.AddWithValue("@ServerRackFkName", textBox_serverRackFkName.Text);
                            command.Parameters.AddWithValue("@Id", Convert.ToInt32(selectedRow.Cells["id"].Value));
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Host updated successfully!");
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

        private void btnDeleteHost_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    using (var connection = new SQLiteConnection(databasePath))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Hosts WHERE id = @Id";
                        using (var command = new SQLiteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", Convert.ToInt32(selectedRow.Cells["id"].Value));
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Host deleted successfully!");
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
            textBox_hostName.Clear();
            textBox_serialNumber.Clear();
            textBox_hostIp.Clear();
            textBox_osVersion.Clear();
            textBox_description.Clear();
            textBox_purchaseDate.Clear();
            textBox_plantFkName.Clear();
            textBox_serverRackFkName.Clear();
        }
    }
}

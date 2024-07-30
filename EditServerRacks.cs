using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SSM
{
    public partial class EditServerRacks : Form
    {
        string databasePath = @"Data Source=C:\Users\Admin\source\repos\SSM\bin\Debug\database.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        private int selectedRowIndex = -1;

        public EditServerRacks()
        {
            InitializeComponent();
            this.Load += EditServerRacks_Load;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            btnAddRack.Click += btnAddRack_Click;
            btnEditRack.Click += btnEditRack_Click;
            btnDeleteRack.Click += btnDeleteRack_Click;
        }

        private void EditServerRacks_Load(object sender, EventArgs e)
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

                string q = "SELECT * FROM Server_Racks";
                cmd = new SQLiteCommand(q, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["id"], dr["rack_name"], dr["description"]);
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
                textBox_rackName.Text = row.Cells["rack_name"].Value.ToString();
                textBox_description.Text = row.Cells["description"].Value.ToString();
                selectedRowIndex = e.RowIndex; // Speichern des Index der ausgewählten Zeile
            }
        }

        private void btnAddRack_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_rackName.Text))
                {
                    using (var connection = new SQLiteConnection(databasePath))
                    {
                        connection.Open();

                        string insertQuery = @"
                            INSERT INTO Server_Racks (rack_name, description) 
                            VALUES (@RackName, @Description)";
                        using (var command = new SQLiteCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@RackName", textBox_rackName.Text);
                            command.Parameters.AddWithValue("@Description", textBox_description.Text);
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Server Rack added successfully!");
                        data_show(); // Daten neu laden
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Rack Name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnEditRack_Click(object sender, EventArgs e)
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
                            UPDATE Server_Racks 
                            SET rack_name = @RackName, description = @Description 
                            WHERE id = @Id";
                        using (var command = new SQLiteCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@RackName", textBox_rackName.Text);
                            command.Parameters.AddWithValue("@Description", textBox_description.Text);
                            command.Parameters.AddWithValue("@Id", Convert.ToInt32(selectedRow.Cells["id"].Value));
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Server Rack updated successfully!");
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

        private void btnDeleteRack_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    using (var connection = new SQLiteConnection(databasePath))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Server_Racks WHERE id = @Id";
                        using (var command = new SQLiteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", Convert.ToInt32(selectedRow.Cells["id"].Value));
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Server Rack deleted successfully!");
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
            textBox_rackName.Clear();
            textBox_description.Clear();
        }
    }
}

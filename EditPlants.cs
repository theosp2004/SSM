using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SSM
{
    public partial class EditPlants : Form
    {
        string databasePath = @"Data Source=C:\Users\Admin\source\repos\SSM\bin\Debug\database.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        private int selectedRowIndex = -1;

        public EditPlants()
        {
            InitializeComponent();
        }

        private void data_show()
        {
            try
            {
                dataGridView1.Rows.Clear();
                con = new SQLiteConnection(databasePath);
                con.Open();

                string q = "SELECT * FROM Plants";
                cmd = new SQLiteCommand(q, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["id"], dr["plant_name"], dr["description"]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnExit(object sender, EventArgs e)
        {
            this.Hide();
            //            ParentForm.Show();
                    
        }

        private void EditPlants_Load(object sender, EventArgs e)
        {
            data_show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //textBox_id.Text = row.Cells["id"].Value.ToString();
                textBox_plantname.Text = row.Cells["plant_name"].Value.ToString();
                textBox_plant_description.Text = row.Cells["description"].Value.ToString();
                selectedRowIndex = e.RowIndex; // Speichern des Index der ausgewählten Zeile
            }
        }

        private void btnEditPlant_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    using (var connection = new SQLiteConnection(databasePath))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE Plants SET plant_name = @PlantName, description = @Description WHERE id = @Id";
                        using (var command = new SQLiteCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@PlantName", textBox_plantname.Text);
                            command.Parameters.AddWithValue("@Description", textBox_plant_description.Text);
                            command.Parameters.AddWithValue("@Id", Convert.ToInt32(selectedRow.Cells["id"].Value));

                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        //MessageBox.Show("Plant updated successfully!");
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

        private void btnDeletePlant_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete the record?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Code, der ausgeführt werden soll, wenn "Ja" angeklickt wurde
            {
                try
                {
                    if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count - 1)
                    {
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                        using (var connection = new SQLiteConnection(databasePath))
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM Plants WHERE id = @Id";
                            using (var command = new SQLiteCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Id", Convert.ToInt32(selectedRow.Cells["id"].Value));
                                command.ExecuteNonQuery();
                            }

                            connection.Close();
                            MessageBox.Show("Plant deleted successfully!");
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
            }
        }

        private void btnAddPlant_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_plantname.Text) && !string.IsNullOrEmpty(textBox_plant_description.Text))
                {
                    using (var connection = new SQLiteConnection(databasePath))
                    {
                        connection.Open();

                        string insertQuery = "INSERT INTO Plants (plant_name, description) VALUES (@PlantName, @Description)";
                        using (var command = new SQLiteCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@PlantName", textBox_plantname.Text);
                            command.Parameters.AddWithValue("@Description", textBox_plant_description.Text);
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                        //MessageBox.Show("Plant added successfully!");
                        data_show(); // Daten neu laden
                        textBox_plantname.Clear(); // TextBoxen leeren
                        textBox_plant_description.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both Plant Name and Description.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

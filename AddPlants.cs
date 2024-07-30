using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SSM
{
    public partial class AddPlants : Form
    {

        public AddPlants()
        {
            InitializeComponent();
            InitializeCustomComponents();

        }
        private void InitializeCustomComponents()
        {
            // Plant Name TextBox
            //textBox_plant_name = new TextBox();
            //textBox_plant_name.Location = new Point(10, 10);
            //textBox_plant_name.Width = 200;
            //this.Controls.Add(textBox_plant_name);

            // Description TextBox
            //textBox_description = new TextBox();
            //textBox_description.Location = new Point(10, 40);
            //textBox_description.Width = 200;
            //this.Controls.Add(textBox_description);

            //// Add Plant Button
            //btnAddPlant = new Button();
            //btnAddPlant.Location = new Point(10, 70);
            //btnAddPlant.Text = "Add Plant";
            //btnAddPlant.Click += new EventHandler(BtnAddPlant_Click);
            //this.Controls.Add(btnAddPlant);
        }

        private void BtnAddPlant_Click(object sender, EventArgs e)
        {
            AddPlantToDatabase(textBox_plant_name.Text, textBox_description.Text);
        }

        private void AddPlantToDatabase(string plantName, string description)
        {
            try
            {
                //string databasePath = @"Data Source=C:\Users\Admin\source\repos\SSM\Database\database.db";
                string path = "database.db";
                string cs = @"URI:file" + Application.StartupPath + "\\database.db";
                using (var connection = new SQLiteConnection(cs))
                {
                    connection.Open();

                    string insertQuery = @"
                    INSERT INTO Plants (plant_name, description) 
                    VALUES (@PlantName, @Description)";

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PlantName", plantName);
                        command.Parameters.AddWithValue("@Description", description);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                    MessageBox.Show("Plant added successfully!");
                    textBox_plant_name.Text = "";
                    textBox_description.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnAddPlant_Click(object sender, EventArgs e)
        {
                AddPlantToDatabase(textBox_plant_name.Text, textBox_description.Text);
        }

        private void btnCancleBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

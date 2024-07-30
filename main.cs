using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace SSM
{
    public partial class main : Form
    {
        private string databasePath = "Data Source=C:\\Users\\Admin\\source\\repos\\SSM\\Database\\database.db";

        public main()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(databasePath))
                {
                    connection.Open();

                    string create_table_hosts = @"
                        CREATE TABLE IF NOT EXISTS Hosts (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            host_name TEXT NOT NULL UNIQUE,
                            serial_number TEXT UNIQUE,
                            host_ip TEXT NOT NULL,
                            os_version TEXT,
                            description TEXT,
                            purchase_date TEXT,
                            plant_fk_name TEXT,
                            server_rack_fk_name TEXT,
                            FOREIGN KEY (plant_fk_name) REFERENCES Plants(plant_name),
                            FOREIGN KEY (server_rack_fk_name) REFERENCES Server_Racks(rack_name)
                        )";
                    using (var command = new SQLiteCommand(create_table_hosts, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while initializing the database: " + ex.Message);
            }
        }

        private void plantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPlants addNewPlant = new AddPlants();
            addNewPlant.ShowDialog();
            this.Show();
        }

        private void plantsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditPlants editPlant = new EditPlants();
            editPlant.ShowDialog();
            this.Show();
        }

        private void hostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditHosts editHosts = new EditHosts();
            editHosts.ShowDialog();
            this.Show();
        }

        private void serverRacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditServerRacks editServerRacks = new EditServerRacks();
            editServerRacks.ShowDialog();
            this.Show();
        }

        // Backup-Button hinzufügen
        private void btnBackupDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                string backupDirectory = @"C:\Users\Admin\source\repos\SSM\backups\"; // Verzeichnis für die Backups

                // Sicherstellen, dass das Backup-Verzeichnis existiert
                if (!Directory.Exists(backupDirectory))
                {
                    Directory.CreateDirectory(backupDirectory);
                }

                // Dateiname für das Backup
                string backupFileName = "database_backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".db";
                string backupPath = Path.Combine(backupDirectory, backupFileName);

                // Datenbankdatei kopieren
                File.Copy(databasePath, backupPath);

                MessageBox.Show("Database backup created successfully at: " + backupPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the database backup: " + ex.Message);
            }
        }

        private void addProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProblem addProblem = new AddProblem();
            addProblem.ShowDialog();
        }

        private void collectXMLFilesTogetherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            XmlMerger xmlMerger = new XmlMerger();
            xmlMerger.ShowDialog();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software was developed by Theo Paraskevopoulos\n" +
                            "Albert-Kemmerich Str. 1-3\n" +
                            "57439 Attendorn\n" +
                            "+491722436236");
        }
    }
}

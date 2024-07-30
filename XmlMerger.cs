using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SSM
{
    public partial class XmlMerger : Form
    {
    // Liste zum Speichern der Dateipfade
    private List<string> filePaths = new List<string>();

        public XmlMerger()
        {
            InitializeComponent();
        }
        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePaths.AddRange(openFileDialog.FileNames);
                    txtPreview.Text = string.Join(Environment.NewLine, filePaths);
                }
            }
        }
        private void btnMergeAndSave_Click(object sender, EventArgs e)
        {
            if (filePaths.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie zuerst die XML-Dateien aus.");
                return;
            }

            try
            {
                XmlDocument mergedDoc = new XmlDocument();
                XmlElement root = mergedDoc.CreateElement("CONTRACTS");
                mergedDoc.AppendChild(root);

                foreach (string filePath in filePaths)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filePath);

                    XmlNode importedNode = mergedDoc.ImportNode(doc.DocumentElement, true);
                    root.AppendChild(importedNode);
                }

                string mergedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "merged_contracts.xml");
                mergedDoc.Save(mergedFilePath);

                txtPreview.Text = mergedDoc.OuterXml;

                MessageBox.Show("XML-Dateien wurden erfolgreich zusammengeführt und gespeichert.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Zusammenführen der XML-Dateien: " + ex.Message);
            }
        }
    }
}


namespace SSM
{
    partial class XmlMerger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.btnMergeAndSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(68, 240);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(129, 36);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "select Files";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(68, 208);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(100, 26);
            this.txtPreview.TabIndex = 1;
            // 
            // btnMergeAndSave
            // 
            this.btnMergeAndSave.Location = new System.Drawing.Point(68, 317);
            this.btnMergeAndSave.Name = "btnMergeAndSave";
            this.btnMergeAndSave.Size = new System.Drawing.Size(75, 23);
            this.btnMergeAndSave.TabIndex = 2;
            this.btnMergeAndSave.Text = "Merge and Save";
            this.btnMergeAndSave.UseVisualStyleBackColor = true;
            this.btnMergeAndSave.Click += new System.EventHandler(this.btnMergeAndSave_Click);
            // 
            // XmlMerger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMergeAndSave);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.btnSelectFiles);
            this.Name = "XmlMerger";
            this.Text = "XmlMerger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Button btnMergeAndSave;
    }
}
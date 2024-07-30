
namespace SSM
{
    partial class EditServerRacks
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rack_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRack = new System.Windows.Forms.Button();
            this.btnEditRack = new System.Windows.Forms.Button();
            this.btnDeleteRack = new System.Windows.Forms.Button();
            this.textBox_rackName = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.lbl_serverRack = new System.Windows.Forms.Label();
            this.lbl_serverRackDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rack_name,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(349, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(415, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // rack_name
            // 
            this.rack_name.HeaderText = "ServerRack (SV)";
            this.rack_name.MinimumWidth = 8;
            this.rack_name.Name = "rack_name";
            this.rack_name.Width = 150;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.Width = 150;
            // 
            // btnAddRack
            // 
            this.btnAddRack.Location = new System.Drawing.Point(12, 130);
            this.btnAddRack.Name = "btnAddRack";
            this.btnAddRack.Size = new System.Drawing.Size(315, 32);
            this.btnAddRack.TabIndex = 1;
            this.btnAddRack.Text = "Add Rack";
            this.btnAddRack.UseVisualStyleBackColor = true;
            // 
            // btnEditRack
            // 
            this.btnEditRack.Location = new System.Drawing.Point(12, 168);
            this.btnEditRack.Name = "btnEditRack";
            this.btnEditRack.Size = new System.Drawing.Size(315, 32);
            this.btnEditRack.TabIndex = 2;
            this.btnEditRack.Text = "Edit Rack";
            this.btnEditRack.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRack
            // 
            this.btnDeleteRack.Location = new System.Drawing.Point(12, 206);
            this.btnDeleteRack.Name = "btnDeleteRack";
            this.btnDeleteRack.Size = new System.Drawing.Size(315, 32);
            this.btnDeleteRack.TabIndex = 3;
            this.btnDeleteRack.Text = "Delete Rack";
            this.btnDeleteRack.UseVisualStyleBackColor = true;
            // 
            // textBox_rackName
            // 
            this.textBox_rackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rackName.Location = new System.Drawing.Point(125, 12);
            this.textBox_rackName.Name = "textBox_rackName";
            this.textBox_rackName.Size = new System.Drawing.Size(202, 35);
            this.textBox_rackName.TabIndex = 4;
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_description.Location = new System.Drawing.Point(125, 64);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(202, 35);
            this.textBox_description.TabIndex = 5;
            // 
            // lbl_serverRack
            // 
            this.lbl_serverRack.AutoSize = true;
            this.lbl_serverRack.Location = new System.Drawing.Point(8, 15);
            this.lbl_serverRack.Name = "lbl_serverRack";
            this.lbl_serverRack.Size = new System.Drawing.Size(96, 20);
            this.lbl_serverRack.TabIndex = 6;
            this.lbl_serverRack.Text = "Server Rack";
            // 
            // lbl_serverRackDescription
            // 
            this.lbl_serverRackDescription.AutoSize = true;
            this.lbl_serverRackDescription.Location = new System.Drawing.Point(8, 67);
            this.lbl_serverRackDescription.Name = "lbl_serverRackDescription";
            this.lbl_serverRackDescription.Size = new System.Drawing.Size(89, 20);
            this.lbl_serverRackDescription.TabIndex = 7;
            this.lbl_serverRackDescription.Text = "Description";
            // 
            // EditServerRacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 253);
            this.Controls.Add(this.lbl_serverRackDescription);
            this.Controls.Add(this.lbl_serverRack);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_rackName);
            this.Controls.Add(this.btnDeleteRack);
            this.Controls.Add(this.btnEditRack);
            this.Controls.Add(this.btnAddRack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditServerRacks";
            this.Text = "EditServerRacks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rack_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button btnAddRack;
        private System.Windows.Forms.Button btnEditRack;
        private System.Windows.Forms.Button btnDeleteRack;
        private System.Windows.Forms.TextBox textBox_rackName;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label lbl_serverRack;
        private System.Windows.Forms.Label lbl_serverRackDescription;
    }
}
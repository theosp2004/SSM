
namespace SSM
{
    partial class EditHosts
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.host_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.host_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.os_version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plant_fk_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_rack_fk_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_hostName = new System.Windows.Forms.TextBox();
            this.textBox_osVersion = new System.Windows.Forms.TextBox();
            this.textBox_purchaseDate = new System.Windows.Forms.TextBox();
            this.textBox_serverRackFkName = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_plantFkName = new System.Windows.Forms.TextBox();
            this.textBox_hostIp = new System.Windows.Forms.TextBox();
            this.textBox_serialNumber = new System.Windows.Forms.TextBox();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.btnEditHost = new System.Windows.Forms.Button();
            this.btnDeleteHost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.host_name,
            this.serial_number,
            this.host_ip,
            this.os_version,
            this.description,
            this.purchase_date,
            this.plant_fk_name,
            this.server_rack_fk_name});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // host_name
            // 
            this.host_name.HeaderText = "Hostname";
            this.host_name.MinimumWidth = 8;
            this.host_name.Name = "host_name";
            this.host_name.Width = 150;
            // 
            // serial_number
            // 
            this.serial_number.HeaderText = "S/N";
            this.serial_number.MinimumWidth = 8;
            this.serial_number.Name = "serial_number";
            this.serial_number.Width = 150;
            // 
            // host_ip
            // 
            this.host_ip.HeaderText = "iLo_ip";
            this.host_ip.MinimumWidth = 8;
            this.host_ip.Name = "host_ip";
            this.host_ip.Width = 150;
            // 
            // os_version
            // 
            this.os_version.HeaderText = "OS_Version";
            this.os_version.MinimumWidth = 8;
            this.os_version.Name = "os_version";
            this.os_version.Width = 150;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.Width = 150;
            // 
            // purchase_date
            // 
            this.purchase_date.HeaderText = "Purchase Date";
            this.purchase_date.MinimumWidth = 8;
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.Width = 150;
            // 
            // plant_fk_name
            // 
            this.plant_fk_name.HeaderText = "stored in Plant";
            this.plant_fk_name.MinimumWidth = 8;
            this.plant_fk_name.Name = "plant_fk_name";
            this.plant_fk_name.Width = 150;
            // 
            // server_rack_fk_name
            // 
            this.server_rack_fk_name.HeaderText = "SV";
            this.server_rack_fk_name.MinimumWidth = 8;
            this.server_rack_fk_name.Name = "server_rack_fk_name";
            this.server_rack_fk_name.Width = 150;
            // 
            // textBox_hostName
            // 
            this.textBox_hostName.Location = new System.Drawing.Point(70, 253);
            this.textBox_hostName.Name = "textBox_hostName";
            this.textBox_hostName.Size = new System.Drawing.Size(100, 26);
            this.textBox_hostName.TabIndex = 1;
            this.textBox_hostName.Text = "Hostname";
            // 
            // textBox_osVersion
            // 
            this.textBox_osVersion.Location = new System.Drawing.Point(533, 253);
            this.textBox_osVersion.Name = "textBox_osVersion";
            this.textBox_osVersion.Size = new System.Drawing.Size(100, 26);
            this.textBox_osVersion.TabIndex = 4;
            this.textBox_osVersion.Text = "Version of OS";
            // 
            // textBox_purchaseDate
            // 
            this.textBox_purchaseDate.Location = new System.Drawing.Point(822, 245);
            this.textBox_purchaseDate.Name = "textBox_purchaseDate";
            this.textBox_purchaseDate.Size = new System.Drawing.Size(100, 26);
            this.textBox_purchaseDate.TabIndex = 6;
            this.textBox_purchaseDate.Text = "Purchase date";
            // 
            // textBox_serverRackFkName
            // 
            this.textBox_serverRackFkName.Location = new System.Drawing.Point(1135, 253);
            this.textBox_serverRackFkName.Name = "textBox_serverRackFkName";
            this.textBox_serverRackFkName.Size = new System.Drawing.Size(100, 26);
            this.textBox_serverRackFkName.TabIndex = 8;
            this.textBox_serverRackFkName.Text = "Server rack";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(671, 245);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(100, 26);
            this.textBox_description.TabIndex = 5;
            this.textBox_description.Text = "any comments";
            // 
            // textBox_plantFkName
            // 
            this.textBox_plantFkName.Location = new System.Drawing.Point(988, 253);
            this.textBox_plantFkName.Name = "textBox_plantFkName";
            this.textBox_plantFkName.Size = new System.Drawing.Size(100, 26);
            this.textBox_plantFkName.TabIndex = 7;
            this.textBox_plantFkName.Text = "stored in plant";
            // 
            // textBox_hostIp
            // 
            this.textBox_hostIp.Location = new System.Drawing.Point(378, 253);
            this.textBox_hostIp.Name = "textBox_hostIp";
            this.textBox_hostIp.Size = new System.Drawing.Size(100, 26);
            this.textBox_hostIp.TabIndex = 3;
            this.textBox_hostIp.Text = "iLo IP";
            // 
            // textBox_serialNumber
            // 
            this.textBox_serialNumber.Location = new System.Drawing.Point(194, 253);
            this.textBox_serialNumber.Name = "textBox_serialNumber";
            this.textBox_serialNumber.Size = new System.Drawing.Size(100, 26);
            this.textBox_serialNumber.TabIndex = 2;
            this.textBox_serialNumber.Text = "Serial Number";
            // 
            // btnAddHost
            // 
            this.btnAddHost.Location = new System.Drawing.Point(70, 328);
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.Size = new System.Drawing.Size(86, 40);
            this.btnAddHost.TabIndex = 9;
            this.btnAddHost.Text = "Add Host";
            this.btnAddHost.UseVisualStyleBackColor = true;
            // 
            // btnEditHost
            // 
            this.btnEditHost.Location = new System.Drawing.Point(207, 328);
            this.btnEditHost.Name = "btnEditHost";
            this.btnEditHost.Size = new System.Drawing.Size(108, 40);
            this.btnEditHost.TabIndex = 10;
            this.btnEditHost.Text = "Edit Host";
            this.btnEditHost.UseVisualStyleBackColor = true;
            // 
            // btnDeleteHost
            // 
            this.btnDeleteHost.Location = new System.Drawing.Point(378, 339);
            this.btnDeleteHost.Name = "btnDeleteHost";
            this.btnDeleteHost.Size = new System.Drawing.Size(100, 29);
            this.btnDeleteHost.TabIndex = 11;
            this.btnDeleteHost.Text = "Delete Host";
            this.btnDeleteHost.UseVisualStyleBackColor = true;
            // 
            // EditHosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 485);
            this.Controls.Add(this.btnDeleteHost);
            this.Controls.Add(this.btnEditHost);
            this.Controls.Add(this.btnAddHost);
            this.Controls.Add(this.textBox_serialNumber);
            this.Controls.Add(this.textBox_hostIp);
            this.Controls.Add(this.textBox_plantFkName);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_serverRackFkName);
            this.Controls.Add(this.textBox_purchaseDate);
            this.Controls.Add(this.textBox_osVersion);
            this.Controls.Add(this.textBox_hostName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditHosts";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn host_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn host_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn os_version;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn plant_fk_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_rack_fk_name;
        private System.Windows.Forms.TextBox textBox_hostName;
        private System.Windows.Forms.TextBox textBox_osVersion;
        private System.Windows.Forms.TextBox textBox_purchaseDate;
        private System.Windows.Forms.TextBox textBox_serverRackFkName;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_plantFkName;
        private System.Windows.Forms.TextBox textBox_hostIp;
        private System.Windows.Forms.TextBox textBox_serialNumber;
        private System.Windows.Forms.Button btnAddHost;
        private System.Windows.Forms.Button btnEditHost;
        private System.Windows.Forms.Button btnDeleteHost;
    }
}
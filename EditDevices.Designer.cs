
namespace SSM
{
    partial class EditDevices
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
            this.vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_vendor = new System.Windows.Forms.TextBox();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_purchaseDate = new System.Windows.Forms.TextBox();
            this.textBox_responsible = new System.Windows.Forms.TextBox();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnEditDevice = new System.Windows.Forms.Button();
            this.btnDeleteDevice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendor,
            this.model,
            this.ip,
            this.purchase_date,
            this.responsible});
            this.dataGridView1.Location = new System.Drawing.Point(89, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(835, 112);
            this.dataGridView1.TabIndex = 0;
            // 
            // vendor
            // 
            this.vendor.HeaderText = "Vendor";
            this.vendor.MinimumWidth = 8;
            this.vendor.Name = "vendor";
            this.vendor.Width = 150;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.MinimumWidth = 8;
            this.model.Name = "model";
            this.model.Width = 150;
            // 
            // ip
            // 
            this.ip.HeaderText = "IP";
            this.ip.MinimumWidth = 8;
            this.ip.Name = "ip";
            this.ip.Width = 150;
            // 
            // purchase_date
            // 
            this.purchase_date.HeaderText = "Purchase Date";
            this.purchase_date.MinimumWidth = 8;
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.Width = 150;
            // 
            // responsible
            // 
            this.responsible.HeaderText = "Responsible Person";
            this.responsible.MinimumWidth = 8;
            this.responsible.Name = "responsible";
            this.responsible.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox_vendor
            // 
            this.textBox_vendor.Location = new System.Drawing.Point(156, 183);
            this.textBox_vendor.Name = "textBox_vendor";
            this.textBox_vendor.Size = new System.Drawing.Size(100, 26);
            this.textBox_vendor.TabIndex = 1;
            this.textBox_vendor.Text = "Vendor";
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(321, 183);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(100, 26);
            this.textBox_model.TabIndex = 3;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(467, 183);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(100, 26);
            this.textBox_ip.TabIndex = 4;
            // 
            // textBox_purchaseDate
            // 
            this.textBox_purchaseDate.Location = new System.Drawing.Point(620, 183);
            this.textBox_purchaseDate.Name = "textBox_purchaseDate";
            this.textBox_purchaseDate.Size = new System.Drawing.Size(100, 26);
            this.textBox_purchaseDate.TabIndex = 5;
            // 
            // textBox_responsible
            // 
            this.textBox_responsible.Location = new System.Drawing.Point(771, 183);
            this.textBox_responsible.Name = "textBox_responsible";
            this.textBox_responsible.Size = new System.Drawing.Size(100, 26);
            this.textBox_responsible.TabIndex = 6;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(89, 239);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(113, 31);
            this.btnAddDevice.TabIndex = 7;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            // 
            // btnEditDevice
            // 
            this.btnEditDevice.Location = new System.Drawing.Point(247, 239);
            this.btnEditDevice.Name = "btnEditDevice";
            this.btnEditDevice.Size = new System.Drawing.Size(104, 31);
            this.btnEditDevice.TabIndex = 8;
            this.btnEditDevice.Text = "Edit Device";
            this.btnEditDevice.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDevice
            // 
            this.btnDeleteDevice.Location = new System.Drawing.Point(399, 239);
            this.btnDeleteDevice.Name = "btnDeleteDevice";
            this.btnDeleteDevice.Size = new System.Drawing.Size(119, 31);
            this.btnDeleteDevice.TabIndex = 9;
            this.btnDeleteDevice.Text = "Delete Device";
            this.btnDeleteDevice.UseVisualStyleBackColor = true;
            // 
            // EditDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.btnDeleteDevice);
            this.Controls.Add(this.btnEditDevice);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.textBox_responsible);
            this.Controls.Add(this.textBox_purchaseDate);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.textBox_model);
            this.Controls.Add(this.textBox_vendor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditDevices";
            this.Text = "EditDevices";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_vendor;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_purchaseDate;
        private System.Windows.Forms.TextBox textBox_responsible;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnEditDevice;
        private System.Windows.Forms.Button btnDeleteDevice;
    }
}
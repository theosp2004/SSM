
namespace SSM
{
    partial class EditPlants
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
            this.plant_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditPlant = new System.Windows.Forms.Button();
            this.btnDeletePlant = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddPlant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_plantname = new System.Windows.Forms.TextBox();
            this.textBox_plant_description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.plant_name,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(385, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(457, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // plant_name
            // 
            this.plant_name.HeaderText = "Plant Name";
            this.plant_name.MinimumWidth = 8;
            this.plant_name.Name = "plant_name";
            this.plant_name.Width = 150;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.Width = 150;
            // 
            // btnEditPlant
            // 
            this.btnEditPlant.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditPlant.Location = new System.Drawing.Point(26, 184);
            this.btnEditPlant.Name = "btnEditPlant";
            this.btnEditPlant.Size = new System.Drawing.Size(336, 37);
            this.btnEditPlant.TabIndex = 1;
            this.btnEditPlant.Text = "edit Plant";
            this.btnEditPlant.UseVisualStyleBackColor = false;
            this.btnEditPlant.Click += new System.EventHandler(this.btnEditPlant_Click);
            // 
            // btnDeletePlant
            // 
            this.btnDeletePlant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletePlant.Location = new System.Drawing.Point(26, 227);
            this.btnDeletePlant.Name = "btnDeletePlant";
            this.btnDeletePlant.Size = new System.Drawing.Size(336, 41);
            this.btnDeletePlant.TabIndex = 2;
            this.btnDeletePlant.Text = "delete Plant";
            this.btnDeletePlant.UseVisualStyleBackColor = false;
            this.btnDeletePlant.Click += new System.EventHandler(this.btnDeletePlant_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(336, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit - Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnExit);
            // 
            // btnAddPlant
            // 
            this.btnAddPlant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPlant.Location = new System.Drawing.Point(26, 135);
            this.btnAddPlant.Name = "btnAddPlant";
            this.btnAddPlant.Size = new System.Drawing.Size(336, 43);
            this.btnAddPlant.TabIndex = 4;
            this.btnAddPlant.Text = "add Plant";
            this.btnAddPlant.UseVisualStyleBackColor = false;
            this.btnAddPlant.Click += new System.EventHandler(this.btnAddPlant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plantname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // textBox_plantname
            // 
            this.textBox_plantname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_plantname.Location = new System.Drawing.Point(122, 26);
            this.textBox_plantname.Name = "textBox_plantname";
            this.textBox_plantname.Size = new System.Drawing.Size(240, 35);
            this.textBox_plantname.TabIndex = 7;
            // 
            // textBox_plant_description
            // 
            this.textBox_plant_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_plant_description.Location = new System.Drawing.Point(121, 78);
            this.textBox_plant_description.Name = "textBox_plant_description";
            this.textBox_plant_description.Size = new System.Drawing.Size(241, 35);
            this.textBox_plant_description.TabIndex = 8;
            // 
            // EditPlants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 354);
            this.Controls.Add(this.textBox_plant_description);
            this.Controls.Add(this.textBox_plantname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPlant);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDeletePlant);
            this.Controls.Add(this.btnEditPlant);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditPlants";
            this.Text = "EditPlants";
            this.Load += new System.EventHandler(this.EditPlants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditPlant;
        private System.Windows.Forms.Button btnDeletePlant;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddPlant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_plantname;
        private System.Windows.Forms.TextBox textBox_plant_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plant_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}
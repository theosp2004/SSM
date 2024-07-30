
namespace SSM
{
    partial class AddPlants
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
            this.btnCancleBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPlant = new System.Windows.Forms.Button();
            this.textBox_plant_name = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancleBack
            // 
            this.btnCancleBack.Location = new System.Drawing.Point(493, 149);
            this.btnCancleBack.Name = "btnCancleBack";
            this.btnCancleBack.Size = new System.Drawing.Size(183, 35);
            this.btnCancleBack.TabIndex = 7;
            this.btnCancleBack.Text = "cancle and back...";
            this.btnCancleBack.UseVisualStyleBackColor = true;
            this.btnCancleBack.Click += new System.EventHandler(this.btnCancleBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plantname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // btnAddPlant
            // 
            this.btnAddPlant.Location = new System.Drawing.Point(174, 149);
            this.btnAddPlant.Name = "btnAddPlant";
            this.btnAddPlant.Size = new System.Drawing.Size(211, 35);
            this.btnAddPlant.TabIndex = 3;
            this.btnAddPlant.Text = "add plant";
            this.btnAddPlant.UseVisualStyleBackColor = true;
            this.btnAddPlant.Click += new System.EventHandler(this.btnAddPlant_Click);
            // 
            // textBox_plant_name
            // 
            this.textBox_plant_name.Location = new System.Drawing.Point(187, 59);
            this.textBox_plant_name.Name = "textBox_plant_name";
            this.textBox_plant_name.Size = new System.Drawing.Size(179, 26);
            this.textBox_plant_name.TabIndex = 5;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(187, 97);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(179, 26);
            this.textBox_description.TabIndex = 6;
            // 
            // AddPlants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 225);
            this.Controls.Add(this.btnCancleBack);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_plant_name);
            this.Controls.Add(this.btnAddPlant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddPlants";
            this.Text = "AddPlants";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancleBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPlant;
        private System.Windows.Forms.TextBox textBox_plant_name;
        private System.Windows.Forms.TextBox textBox_description;
    }
}
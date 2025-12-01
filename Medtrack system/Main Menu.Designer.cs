namespace InventoryAndSales
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.btnViewmed = new System.Windows.Forms.Button();
            this.btnSellmed = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Choose What To Do";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddMed
            // 
            this.btnAddMed.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMed.Location = new System.Drawing.Point(267, 108);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(246, 43);
            this.btnAddMed.TabIndex = 1;
            this.btnAddMed.Text = "ADD MEDICINE";
            this.btnAddMed.UseVisualStyleBackColor = false;
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // btnViewmed
            // 
            this.btnViewmed.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnViewmed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewmed.Location = new System.Drawing.Point(267, 187);
            this.btnViewmed.Name = "btnViewmed";
            this.btnViewmed.Size = new System.Drawing.Size(246, 43);
            this.btnViewmed.TabIndex = 2;
            this.btnViewmed.Text = "VIEW MEDICINE";
            this.btnViewmed.UseVisualStyleBackColor = false;
            this.btnViewmed.Click += new System.EventHandler(this.btnViewmed_Click);
            // 
            // btnSellmed
            // 
            this.btnSellmed.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSellmed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellmed.Location = new System.Drawing.Point(267, 263);
            this.btnSellmed.Name = "btnSellmed";
            this.btnSellmed.Size = new System.Drawing.Size(250, 43);
            this.btnSellmed.TabIndex = 3;
            this.btnSellmed.Text = "SELL MEDICINE";
            this.btnSellmed.UseVisualStyleBackColor = false;
            this.btnSellmed.Click += new System.EventHandler(this.btnSellmed_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(628, 457);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(129, 30);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(267, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "TRANSACTIONS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventoryAndSales.Properties.Resources.Free_Photo___Medicine_uniform_healthcare_Medical_Workers_Day_concept;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSellmed);
            this.Controls.Add(this.btnViewmed);
            this.Controls.Add(this.btnAddMed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.Button btnViewmed;
        private System.Windows.Forms.Button btnSellmed;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
    }
}

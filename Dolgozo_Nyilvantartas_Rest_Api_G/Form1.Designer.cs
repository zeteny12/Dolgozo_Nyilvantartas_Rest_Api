namespace Dolgozo_Nyilvantartas_Rest_Api_G
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_OsszesAdat = new System.Windows.Forms.ListBox();
            this.button_DolgozoKeresese = new System.Windows.Forms.Button();
            this.textBox_DolgozoKeresese = new System.Windows.Forms.TextBox();
            this.numericUpDown_DolgozoKeresese = new System.Windows.Forms.NumericUpDown();
            this.button_DolgozoKereseseID = new System.Windows.Forms.Button();
            this.button_LapozasMegkezdese = new System.Windows.Forms.Button();
            this.numericUpDown_Oldalszam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DolgozoKeresese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Oldalszam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_OsszesAdat
            // 
            this.listBox_OsszesAdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox_OsszesAdat.FormattingEnabled = true;
            this.listBox_OsszesAdat.ItemHeight = 20;
            this.listBox_OsszesAdat.Location = new System.Drawing.Point(13, 13);
            this.listBox_OsszesAdat.Name = "listBox_OsszesAdat";
            this.listBox_OsszesAdat.Size = new System.Drawing.Size(514, 404);
            this.listBox_OsszesAdat.TabIndex = 0;
            // 
            // button_DolgozoKeresese
            // 
            this.button_DolgozoKeresese.Location = new System.Drawing.Point(533, 45);
            this.button_DolgozoKeresese.Name = "button_DolgozoKeresese";
            this.button_DolgozoKeresese.Size = new System.Drawing.Size(184, 29);
            this.button_DolgozoKeresese.TabIndex = 1;
            this.button_DolgozoKeresese.Text = "Dolgozó keresése (név)";
            this.button_DolgozoKeresese.UseVisualStyleBackColor = true;
            this.button_DolgozoKeresese.Click += new System.EventHandler(this.button_DolgozoKeresese_Click);
            // 
            // textBox_DolgozoKeresese
            // 
            this.textBox_DolgozoKeresese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_DolgozoKeresese.Location = new System.Drawing.Point(533, 13);
            this.textBox_DolgozoKeresese.Name = "textBox_DolgozoKeresese";
            this.textBox_DolgozoKeresese.Size = new System.Drawing.Size(255, 26);
            this.textBox_DolgozoKeresese.TabIndex = 2;
            // 
            // numericUpDown_DolgozoKeresese
            // 
            this.numericUpDown_DolgozoKeresese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDown_DolgozoKeresese.Location = new System.Drawing.Point(533, 107);
            this.numericUpDown_DolgozoKeresese.Name = "numericUpDown_DolgozoKeresese";
            this.numericUpDown_DolgozoKeresese.Size = new System.Drawing.Size(255, 26);
            this.numericUpDown_DolgozoKeresese.TabIndex = 3;
            this.numericUpDown_DolgozoKeresese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_DolgozoKereseseID
            // 
            this.button_DolgozoKereseseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button_DolgozoKereseseID.Location = new System.Drawing.Point(533, 139);
            this.button_DolgozoKereseseID.Name = "button_DolgozoKereseseID";
            this.button_DolgozoKereseseID.Size = new System.Drawing.Size(184, 28);
            this.button_DolgozoKereseseID.TabIndex = 4;
            this.button_DolgozoKereseseID.Text = "Dolgozó keresése (id)";
            this.button_DolgozoKereseseID.UseVisualStyleBackColor = true;
            this.button_DolgozoKereseseID.Click += new System.EventHandler(this.button_DolgozoKereseseID_Click);
            // 
            // button_LapozasMegkezdese
            // 
            this.button_LapozasMegkezdese.Location = new System.Drawing.Point(533, 209);
            this.button_LapozasMegkezdese.Name = "button_LapozasMegkezdese";
            this.button_LapozasMegkezdese.Size = new System.Drawing.Size(184, 28);
            this.button_LapozasMegkezdese.TabIndex = 5;
            this.button_LapozasMegkezdese.Text = "Lapozás megkezdése";
            this.button_LapozasMegkezdese.UseVisualStyleBackColor = true;
            this.button_LapozasMegkezdese.Click += new System.EventHandler(this.button_LapozasMegkezdese_Click);
            // 
            // numericUpDown_Oldalszam
            // 
            this.numericUpDown_Oldalszam.Enabled = false;
            this.numericUpDown_Oldalszam.Location = new System.Drawing.Point(653, 245);
            this.numericUpDown_Oldalszam.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Oldalszam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Oldalszam.Name = "numericUpDown_Oldalszam";
            this.numericUpDown_Oldalszam.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_Oldalszam.TabIndex = 6;
            this.numericUpDown_Oldalszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Oldalszam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Oldalszam.ValueChanged += new System.EventHandler(this.numericUpDown_Oldalszam_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(533, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oldalszám:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Oldalszam);
            this.Controls.Add(this.button_LapozasMegkezdese);
            this.Controls.Add(this.button_DolgozoKereseseID);
            this.Controls.Add(this.numericUpDown_DolgozoKeresese);
            this.Controls.Add(this.textBox_DolgozoKeresese);
            this.Controls.Add(this.button_DolgozoKeresese);
            this.Controls.Add(this.listBox_OsszesAdat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dolgozók Nyilvántartása";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DolgozoKeresese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Oldalszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_OsszesAdat;
        private System.Windows.Forms.Button button_DolgozoKeresese;
        private System.Windows.Forms.TextBox textBox_DolgozoKeresese;
        private System.Windows.Forms.NumericUpDown numericUpDown_DolgozoKeresese;
        private System.Windows.Forms.Button button_DolgozoKereseseID;
        private System.Windows.Forms.Button button_LapozasMegkezdese;
        private System.Windows.Forms.NumericUpDown numericUpDown_Oldalszam;
        private System.Windows.Forms.Label label1;
    }
}


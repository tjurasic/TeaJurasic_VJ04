﻿namespace LOTO_aplikacija
{
    partial class FrmLoto
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
            this.btnUplati = new System.Windows.Forms.Button();
            this.groupBoxUplaceni = new System.Windows.Forms.GroupBox();
            this.txtUplaceniBroj1 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj2 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj3 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj4 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj5 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj6 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj7 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDobitniBroj7 = new System.Windows.Forms.TextBox();
            this.btnOdigraj = new System.Windows.Forms.Button();
            this.txtDobitniBroj4 = new System.Windows.Forms.TextBox();
            this.txtDobitniBroj6 = new System.Windows.Forms.TextBox();
            this.txtDobitniBroj3 = new System.Windows.Forms.TextBox();
            this.txtDobitniBroj2 = new System.Windows.Forms.TextBox();
            this.txtDobitniBroj5 = new System.Windows.Forms.TextBox();
            this.txtDobitniBroj1 = new System.Windows.Forms.TextBox();
            this.lblNatpis = new System.Windows.Forms.Label();
            this.lblBrojPogodaka = new System.Windows.Forms.Label();
            this.groupBoxUplaceni.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(243, 42);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(75, 23);
            this.btnUplati.TabIndex = 0;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            this.btnUplati.Click += new System.EventHandler(this.btnUplati_Click);
            // 
            // groupBoxUplaceni
            // 
            this.groupBoxUplaceni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj7);
            this.groupBoxUplaceni.Controls.Add(this.btnUplati);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj4);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj6);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj3);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj2);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj5);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj1);
            this.groupBoxUplaceni.Location = new System.Drawing.Point(12, 55);
            this.groupBoxUplaceni.Name = "groupBoxUplaceni";
            this.groupBoxUplaceni.Size = new System.Drawing.Size(340, 71);
            this.groupBoxUplaceni.TabIndex = 1;
            this.groupBoxUplaceni.TabStop = false;
            this.groupBoxUplaceni.Text = "Uplaćena kombinacija:";
            this.groupBoxUplaceni.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtUplaceniBroj1
            // 
            this.txtUplaceniBroj1.Location = new System.Drawing.Point(3, 16);
            this.txtUplaceniBroj1.Name = "txtUplaceniBroj1";
            this.txtUplaceniBroj1.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj1.TabIndex = 0;
            // 
            // txtUplaceniBroj2
            // 
            this.txtUplaceniBroj2.Location = new System.Drawing.Point(49, 16);
            this.txtUplaceniBroj2.Name = "txtUplaceniBroj2";
            this.txtUplaceniBroj2.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj2.TabIndex = 1;
            this.txtUplaceniBroj2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUplaceniBroj3
            // 
            this.txtUplaceniBroj3.Location = new System.Drawing.Point(95, 16);
            this.txtUplaceniBroj3.Name = "txtUplaceniBroj3";
            this.txtUplaceniBroj3.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj3.TabIndex = 2;
            this.txtUplaceniBroj3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtUplaceniBroj4
            // 
            this.txtUplaceniBroj4.Location = new System.Drawing.Point(140, 16);
            this.txtUplaceniBroj4.Name = "txtUplaceniBroj4";
            this.txtUplaceniBroj4.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj4.TabIndex = 3;
            // 
            // txtUplaceniBroj5
            // 
            this.txtUplaceniBroj5.Location = new System.Drawing.Point(186, 16);
            this.txtUplaceniBroj5.Name = "txtUplaceniBroj5";
            this.txtUplaceniBroj5.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj5.TabIndex = 4;
            this.txtUplaceniBroj5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtUplaceniBroj6
            // 
            this.txtUplaceniBroj6.Location = new System.Drawing.Point(232, 16);
            this.txtUplaceniBroj6.Name = "txtUplaceniBroj6";
            this.txtUplaceniBroj6.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj6.TabIndex = 5;
            this.txtUplaceniBroj6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtUplaceniBroj7
            // 
            this.txtUplaceniBroj7.Location = new System.Drawing.Point(278, 16);
            this.txtUplaceniBroj7.Name = "txtUplaceniBroj7";
            this.txtUplaceniBroj7.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj7.TabIndex = 6;
            this.txtUplaceniBroj7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txtDobitniBroj7);
            this.groupBox1.Controls.Add(this.btnOdigraj);
            this.groupBox1.Controls.Add(this.txtDobitniBroj4);
            this.groupBox1.Controls.Add(this.txtDobitniBroj6);
            this.groupBox1.Controls.Add(this.txtDobitniBroj3);
            this.groupBox1.Controls.Add(this.txtDobitniBroj2);
            this.groupBox1.Controls.Add(this.txtDobitniBroj5);
            this.groupBox1.Controls.Add(this.txtDobitniBroj1);
            this.groupBox1.Location = new System.Drawing.Point(15, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dobitna kombinacija:";
            // 
            // txtDobitniBroj7
            // 
            this.txtDobitniBroj7.Location = new System.Drawing.Point(278, 16);
            this.txtDobitniBroj7.Name = "txtDobitniBroj7";
            this.txtDobitniBroj7.ReadOnly = true;
            this.txtDobitniBroj7.Size = new System.Drawing.Size(40, 20);
            this.txtDobitniBroj7.TabIndex = 6;
            // 
            // btnOdigraj
            // 
            this.btnOdigraj.Location = new System.Drawing.Point(243, 42);
            this.btnOdigraj.Name = "btnOdigraj";
            this.btnOdigraj.Size = new System.Drawing.Size(75, 23);
            this.btnOdigraj.TabIndex = 0;
            this.btnOdigraj.Text = "Odigraj";
            this.btnOdigraj.UseVisualStyleBackColor = true;
            this.btnOdigraj.Click += new System.EventHandler(this.btnOdigraj_Click);
            // 
            // txtDobitniBroj4
            // 
            this.txtDobitniBroj4.Location = new System.Drawing.Point(140, 16);
            this.txtDobitniBroj4.Name = "txtDobitniBroj4";
            this.txtDobitniBroj4.ReadOnly = true;
            this.txtDobitniBroj4.Size = new System.Drawing.Size(40, 20);
            this.txtDobitniBroj4.TabIndex = 3;
            // 
            // txtDobitniBroj6
            // 
            this.txtDobitniBroj6.Location = new System.Drawing.Point(232, 16);
            this.txtDobitniBroj6.Name = "txtDobitniBroj6";
            this.txtDobitniBroj6.ReadOnly = true;
            this.txtDobitniBroj6.Size = new System.Drawing.Size(40, 20);
            this.txtDobitniBroj6.TabIndex = 5;
            this.txtDobitniBroj6.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtDobitniBroj3
            // 
            this.txtDobitniBroj3.Location = new System.Drawing.Point(95, 16);
            this.txtDobitniBroj3.Name = "txtDobitniBroj3";
            this.txtDobitniBroj3.ReadOnly = true;
            this.txtDobitniBroj3.Size = new System.Drawing.Size(40, 20);
            this.txtDobitniBroj3.TabIndex = 2;
            this.txtDobitniBroj3.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txtDobitniBroj2
            // 
            this.txtDobitniBroj2.Location = new System.Drawing.Point(49, 16);
            this.txtDobitniBroj2.Name = "txtDobitniBroj2";
            this.txtDobitniBroj2.ReadOnly = true;
            this.txtDobitniBroj2.Size = new System.Drawing.Size(40, 20);
            this.txtDobitniBroj2.TabIndex = 1;
            this.txtDobitniBroj2.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // txtDobitniBroj5
            // 
            this.txtDobitniBroj5.Location = new System.Drawing.Point(186, 16);
            this.txtDobitniBroj5.Name = "txtDobitniBroj5";
            this.txtDobitniBroj5.ReadOnly = true;
            this.txtDobitniBroj5.Size = new System.Drawing.Size(40, 20);
            this.txtDobitniBroj5.TabIndex = 4;
            // 
            // txtDobitniBroj1
            // 
            this.txtDobitniBroj1.Location = new System.Drawing.Point(3, 16);
            this.txtDobitniBroj1.Name = "txtDobitniBroj1";
            this.txtDobitniBroj1.ReadOnly = true;
            this.txtDobitniBroj1.Size = new System.Drawing.Size(40, 20);
            this.txtDobitniBroj1.TabIndex = 0;
            // 
            // lblNatpis
            // 
            this.lblNatpis.AutoSize = true;
            this.lblNatpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNatpis.Location = new System.Drawing.Point(20, 229);
            this.lblNatpis.Name = "lblNatpis";
            this.lblNatpis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNatpis.Size = new System.Drawing.Size(93, 13);
            this.lblNatpis.TabIndex = 3;
            this.lblNatpis.Text = "Broj pogodaka:";
            // 
            // lblBrojPogodaka
            // 
            this.lblBrojPogodaka.AutoSize = true;
            this.lblBrojPogodaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojPogodaka.Location = new System.Drawing.Point(119, 229);
            this.lblBrojPogodaka.Name = "lblBrojPogodaka";
            this.lblBrojPogodaka.Size = new System.Drawing.Size(14, 13);
            this.lblBrojPogodaka.TabIndex = 4;
            this.lblBrojPogodaka.Text = "0";
            this.lblBrojPogodaka.Click += new System.EventHandler(this.lblBrojPogodaka_Click);
            // 
            // FrmLoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 282);
            this.Controls.Add(this.lblBrojPogodaka);
            this.Controls.Add(this.lblNatpis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxUplaceni);
            this.Name = "FrmLoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOTO 7/39";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUplaceni.ResumeLayout(false);
            this.groupBoxUplaceni.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.GroupBox groupBoxUplaceni;
        private System.Windows.Forms.TextBox txtUplaceniBroj6;
        private System.Windows.Forms.TextBox txtUplaceniBroj5;
        private System.Windows.Forms.TextBox txtUplaceniBroj4;
        private System.Windows.Forms.TextBox txtUplaceniBroj3;
        private System.Windows.Forms.TextBox txtUplaceniBroj2;
        private System.Windows.Forms.TextBox txtUplaceniBroj1;
        private System.Windows.Forms.TextBox txtUplaceniBroj7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDobitniBroj7;
        private System.Windows.Forms.Button btnOdigraj;
        private System.Windows.Forms.TextBox txtDobitniBroj4;
        private System.Windows.Forms.TextBox txtDobitniBroj6;
        private System.Windows.Forms.TextBox txtDobitniBroj3;
        private System.Windows.Forms.TextBox txtDobitniBroj2;
        private System.Windows.Forms.TextBox txtDobitniBroj5;
        private System.Windows.Forms.TextBox txtDobitniBroj1;
        private System.Windows.Forms.Label lblNatpis;
        private System.Windows.Forms.Label lblBrojPogodaka;
    }
}


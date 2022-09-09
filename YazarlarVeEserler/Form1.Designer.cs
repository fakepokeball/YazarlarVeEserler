namespace YazarlarVeEserler
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpYazar = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtResimYolu = new System.Windows.Forms.TextBox();
            this.txtTamAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lstEserler = new System.Windows.Forms.ListBox();
            this.grpEser = new System.Windows.Forms.GroupBox();
            this.btnEserEkle = new System.Windows.Forms.Button();
            this.btnEserIptal = new System.Windows.Forms.Button();
            this.txtEserIcerik = new System.Windows.Forms.TextBox();
            this.cmbEserYazarlar = new System.Windows.Forms.ComboBox();
            this.txtEserBaslik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAnasayfaYazarlar = new System.Windows.Forms.ComboBox();
            this.lstAnasayfaEserler = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbxAnasayfaResim = new System.Windows.Forms.PictureBox();
            this.txtAnasayfaEserler = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpYazar.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpEser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnasayfaResim)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtAnasayfaEserler);
            this.tabPage1.Controls.Add(this.pbxAnasayfaResim);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lstAnasayfaEserler);
            this.tabPage1.Controls.Add(this.cmbAnasayfaYazarlar);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AnaSayfa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstYazarlar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.grpYazar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yazarlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.Location = new System.Drawing.Point(8, 155);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(474, 147);
            this.lstYazarlar.TabIndex = 2;
            this.lstYazarlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstYazarlar_KeyDown);
            this.lstYazarlar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstYazarlar_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yazarlar";
            // 
            // grpYazar
            // 
            this.grpYazar.Controls.Add(this.btnEkle);
            this.grpYazar.Controls.Add(this.btnIptal);
            this.grpYazar.Controls.Add(this.txtResimYolu);
            this.grpYazar.Controls.Add(this.txtTamAd);
            this.grpYazar.Controls.Add(this.label2);
            this.grpYazar.Controls.Add(this.label1);
            this.grpYazar.Location = new System.Drawing.Point(8, 6);
            this.grpYazar.Name = "grpYazar";
            this.grpYazar.Size = new System.Drawing.Size(230, 133);
            this.grpYazar.TabIndex = 0;
            this.grpYazar.TabStop = false;
            this.grpYazar.Text = "Yazar Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(133, 89);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(91, 34);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(6, 89);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(91, 34);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtResimYolu
            // 
            this.txtResimYolu.Location = new System.Drawing.Point(86, 53);
            this.txtResimYolu.Name = "txtResimYolu";
            this.txtResimYolu.Size = new System.Drawing.Size(138, 20);
            this.txtResimYolu.TabIndex = 3;
            // 
            // txtTamAd
            // 
            this.txtTamAd.Location = new System.Drawing.Point(86, 26);
            this.txtTamAd.Name = "txtTamAd";
            this.txtTamAd.Size = new System.Drawing.Size(138, 20);
            this.txtTamAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resim Yolu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tam Ad:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.lstEserler);
            this.tabPage3.Controls.Add(this.grpEser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(490, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eserler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Eserler";
            // 
            // lstEserler
            // 
            this.lstEserler.FormattingEnabled = true;
            this.lstEserler.Location = new System.Drawing.Point(248, 32);
            this.lstEserler.Name = "lstEserler";
            this.lstEserler.Size = new System.Drawing.Size(234, 264);
            this.lstEserler.TabIndex = 1;
            this.lstEserler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEserler_KeyDown);
            this.lstEserler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstEserler_MouseDoubleClick);
            // 
            // grpEser
            // 
            this.grpEser.Controls.Add(this.btnEserEkle);
            this.grpEser.Controls.Add(this.btnEserIptal);
            this.grpEser.Controls.Add(this.txtEserIcerik);
            this.grpEser.Controls.Add(this.cmbEserYazarlar);
            this.grpEser.Controls.Add(this.txtEserBaslik);
            this.grpEser.Controls.Add(this.label5);
            this.grpEser.Controls.Add(this.label4);
            this.grpEser.Location = new System.Drawing.Point(9, 7);
            this.grpEser.Name = "grpEser";
            this.grpEser.Size = new System.Drawing.Size(233, 289);
            this.grpEser.TabIndex = 0;
            this.grpEser.TabStop = false;
            this.grpEser.Text = "Eser Ekle";
            // 
            // btnEserEkle
            // 
            this.btnEserEkle.Location = new System.Drawing.Point(119, 256);
            this.btnEserEkle.Name = "btnEserEkle";
            this.btnEserEkle.Size = new System.Drawing.Size(108, 23);
            this.btnEserEkle.TabIndex = 6;
            this.btnEserEkle.Text = "EKLE";
            this.btnEserEkle.UseVisualStyleBackColor = true;
            this.btnEserEkle.Click += new System.EventHandler(this.btnEserEkle_Click);
            // 
            // btnEserIptal
            // 
            this.btnEserIptal.Location = new System.Drawing.Point(5, 256);
            this.btnEserIptal.Name = "btnEserIptal";
            this.btnEserIptal.Size = new System.Drawing.Size(108, 23);
            this.btnEserIptal.TabIndex = 5;
            this.btnEserIptal.Text = "İptal";
            this.btnEserIptal.UseVisualStyleBackColor = true;
            this.btnEserIptal.Visible = false;
            this.btnEserIptal.Click += new System.EventHandler(this.btnEserIptal_Click);
            // 
            // txtEserIcerik
            // 
            this.txtEserIcerik.Location = new System.Drawing.Point(6, 75);
            this.txtEserIcerik.Multiline = true;
            this.txtEserIcerik.Name = "txtEserIcerik";
            this.txtEserIcerik.Size = new System.Drawing.Size(221, 174);
            this.txtEserIcerik.TabIndex = 4;
            // 
            // cmbEserYazarlar
            // 
            this.cmbEserYazarlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEserYazarlar.FormattingEnabled = true;
            this.cmbEserYazarlar.Location = new System.Drawing.Point(73, 48);
            this.cmbEserYazarlar.Name = "cmbEserYazarlar";
            this.cmbEserYazarlar.Size = new System.Drawing.Size(154, 21);
            this.cmbEserYazarlar.TabIndex = 3;
            // 
            // txtEserBaslik
            // 
            this.txtEserBaslik.Location = new System.Drawing.Point(73, 19);
            this.txtEserBaslik.Name = "txtEserBaslik";
            this.txtEserBaslik.Size = new System.Drawing.Size(154, 20);
            this.txtEserBaslik.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Eser Başlık:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yazarlar:";
            // 
            // cmbAnasayfaYazarlar
            // 
            this.cmbAnasayfaYazarlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnasayfaYazarlar.FormattingEnabled = true;
            this.cmbAnasayfaYazarlar.Location = new System.Drawing.Point(64, 10);
            this.cmbAnasayfaYazarlar.Name = "cmbAnasayfaYazarlar";
            this.cmbAnasayfaYazarlar.Size = new System.Drawing.Size(193, 21);
            this.cmbAnasayfaYazarlar.TabIndex = 1;
            this.cmbAnasayfaYazarlar.SelectedIndexChanged += new System.EventHandler(this.cmbAnasayfaYazarlar_SelectedIndexChanged);
            // 
            // lstAnasayfaEserler
            // 
            this.lstAnasayfaEserler.FormattingEnabled = true;
            this.lstAnasayfaEserler.Location = new System.Drawing.Point(263, 48);
            this.lstAnasayfaEserler.Name = "lstAnasayfaEserler";
            this.lstAnasayfaEserler.Size = new System.Drawing.Size(219, 108);
            this.lstAnasayfaEserler.TabIndex = 2;
            this.lstAnasayfaEserler.SelectedIndexChanged += new System.EventHandler(this.lstAnasayfaEserler_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Eserler";
            // 
            // pbxAnasayfaResim
            // 
            this.pbxAnasayfaResim.Location = new System.Drawing.Point(6, 48);
            this.pbxAnasayfaResim.Name = "pbxAnasayfaResim";
            this.pbxAnasayfaResim.Size = new System.Drawing.Size(251, 254);
            this.pbxAnasayfaResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAnasayfaResim.TabIndex = 4;
            this.pbxAnasayfaResim.TabStop = false;
            // 
            // txtAnasayfaEserler
            // 
            this.txtAnasayfaEserler.Location = new System.Drawing.Point(268, 186);
            this.txtAnasayfaEserler.Multiline = true;
            this.txtAnasayfaEserler.Name = "txtAnasayfaEserler";
            this.txtAnasayfaEserler.ReadOnly = true;
            this.txtAnasayfaEserler.Size = new System.Drawing.Size(214, 116);
            this.txtAnasayfaEserler.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Eser";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 336);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpYazar.ResumeLayout(false);
            this.grpYazar.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grpEser.ResumeLayout(false);
            this.grpEser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnasayfaResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstYazarlar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpYazar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtResimYolu;
        private System.Windows.Forms.TextBox txtTamAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstEserler;
        private System.Windows.Forms.GroupBox grpEser;
        private System.Windows.Forms.Button btnEserEkle;
        private System.Windows.Forms.Button btnEserIptal;
        private System.Windows.Forms.TextBox txtEserIcerik;
        private System.Windows.Forms.ComboBox cmbEserYazarlar;
        private System.Windows.Forms.TextBox txtEserBaslik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAnasayfaEserler;
        private System.Windows.Forms.PictureBox pbxAnasayfaResim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstAnasayfaEserler;
        private System.Windows.Forms.ComboBox cmbAnasayfaYazarlar;
        private System.Windows.Forms.Label label7;
    }
}


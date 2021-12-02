
namespace Ornek03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDTarihi = new System.Windows.Forms.Label();
            this.listBoxASinifi = new System.Windows.Forms.ListBox();
            this.listBoxBSinifi = new System.Windows.Forms.ListBox();
            this.lblSinifSecimi = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnSagaGonder = new System.Windows.Forms.Button();
            this.btnHepsiniSagaGonder = new System.Windows.Forms.Button();
            this.btnSolaGonder = new System.Windows.Forms.Button();
            this.btnHepsiniSolaGonder = new System.Windows.Forms.Button();
            this.dateTimePickerDTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSinifSecimi = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOgrenci = new System.Windows.Forms.GroupBox();
            this.checkBoxSecmeliTek = new System.Windows.Forms.CheckBox();
            this.groupBoxSecmeliDersler = new System.Windows.Forms.GroupBox();
            this.checkedListBoxSecmeli = new System.Windows.Forms.CheckedListBox();
            this.xmlDisaAktar = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlIceriAktar = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBoxOgrenci.SuspendLayout();
            this.groupBoxSecmeliDersler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(97, 50);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 20);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(75, 87);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(53, 20);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblDTarihi
            // 
            this.lblDTarihi.AutoSize = true;
            this.lblDTarihi.Location = new System.Drawing.Point(27, 123);
            this.lblDTarihi.Name = "lblDTarihi";
            this.lblDTarihi.Size = new System.Drawing.Size(101, 20);
            this.lblDTarihi.TabIndex = 2;
            this.lblDTarihi.Text = "Doğum Tarihi:";
            // 
            // listBoxASinifi
            // 
            this.listBoxASinifi.FormattingEnabled = true;
            this.listBoxASinifi.ItemHeight = 20;
            this.listBoxASinifi.Location = new System.Drawing.Point(32, 360);
            this.listBoxASinifi.Name = "listBoxASinifi";
            this.listBoxASinifi.Size = new System.Drawing.Size(359, 244);
            this.listBoxASinifi.TabIndex = 10;
            // 
            // listBoxBSinifi
            // 
            this.listBoxBSinifi.FormattingEnabled = true;
            this.listBoxBSinifi.ItemHeight = 20;
            this.listBoxBSinifi.Location = new System.Drawing.Point(519, 360);
            this.listBoxBSinifi.Name = "listBoxBSinifi";
            this.listBoxBSinifi.Size = new System.Drawing.Size(428, 244);
            this.listBoxBSinifi.TabIndex = 11;
            // 
            // lblSinifSecimi
            // 
            this.lblSinifSecimi.AutoSize = true;
            this.lblSinifSecimi.Location = new System.Drawing.Point(39, 156);
            this.lblSinifSecimi.Name = "lblSinifSecimi";
            this.lblSinifSecimi.Size = new System.Drawing.Size(89, 20);
            this.lblSinifSecimi.TabIndex = 5;
            this.lblSinifSecimi.Text = "Sınıf Seçimi:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(134, 84);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(250, 27);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(134, 47);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(250, 27);
            this.txtAd.TabIndex = 0;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.Teal;
            this.btnOgrenciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(427, 47);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(119, 188);
            this.btnOgrenciEkle.TabIndex = 5;
            this.btnOgrenciEkle.Text = "ÖĞRENCİ EKLE";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnSagaGonder
            // 
            this.btnSagaGonder.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSagaGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSagaGonder.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSagaGonder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSagaGonder.Location = new System.Drawing.Point(432, 406);
            this.btnSagaGonder.Name = "btnSagaGonder";
            this.btnSagaGonder.Size = new System.Drawing.Size(47, 36);
            this.btnSagaGonder.TabIndex = 6;
            this.btnSagaGonder.Text = ">";
            this.btnSagaGonder.UseVisualStyleBackColor = false;
            this.btnSagaGonder.Click += new System.EventHandler(this.btnSagaGonder_Click);
            // 
            // btnHepsiniSagaGonder
            // 
            this.btnHepsiniSagaGonder.BackColor = System.Drawing.Color.DarkBlue;
            this.btnHepsiniSagaGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHepsiniSagaGonder.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHepsiniSagaGonder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHepsiniSagaGonder.Location = new System.Drawing.Point(432, 448);
            this.btnHepsiniSagaGonder.Name = "btnHepsiniSagaGonder";
            this.btnHepsiniSagaGonder.Size = new System.Drawing.Size(47, 36);
            this.btnHepsiniSagaGonder.TabIndex = 7;
            this.btnHepsiniSagaGonder.Text = ">>";
            this.btnHepsiniSagaGonder.UseVisualStyleBackColor = false;
            this.btnHepsiniSagaGonder.Click += new System.EventHandler(this.btnHepsiniSagaGonder_Click);
            // 
            // btnSolaGonder
            // 
            this.btnSolaGonder.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSolaGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolaGonder.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSolaGonder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSolaGonder.Location = new System.Drawing.Point(432, 490);
            this.btnSolaGonder.Name = "btnSolaGonder";
            this.btnSolaGonder.Size = new System.Drawing.Size(47, 36);
            this.btnSolaGonder.TabIndex = 8;
            this.btnSolaGonder.Text = "<";
            this.btnSolaGonder.UseVisualStyleBackColor = false;
            this.btnSolaGonder.Click += new System.EventHandler(this.btnSolaGonder_Click);
            // 
            // btnHepsiniSolaGonder
            // 
            this.btnHepsiniSolaGonder.BackColor = System.Drawing.Color.DarkBlue;
            this.btnHepsiniSolaGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHepsiniSolaGonder.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHepsiniSolaGonder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHepsiniSolaGonder.Location = new System.Drawing.Point(432, 535);
            this.btnHepsiniSolaGonder.Name = "btnHepsiniSolaGonder";
            this.btnHepsiniSolaGonder.Size = new System.Drawing.Size(47, 36);
            this.btnHepsiniSolaGonder.TabIndex = 9;
            this.btnHepsiniSolaGonder.Text = "<<";
            this.btnHepsiniSolaGonder.UseVisualStyleBackColor = false;
            this.btnHepsiniSolaGonder.Click += new System.EventHandler(this.btnHepsiniSolaGonder_Click);
            // 
            // dateTimePickerDTarihi
            // 
            this.dateTimePickerDTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDTarihi.Location = new System.Drawing.Point(134, 120);
            this.dateTimePickerDTarihi.Name = "dateTimePickerDTarihi";
            this.dateTimePickerDTarihi.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerDTarihi.TabIndex = 3;
            // 
            // comboBoxSinifSecimi
            // 
            this.comboBoxSinifSecimi.FormattingEnabled = true;
            this.comboBoxSinifSecimi.Location = new System.Drawing.Point(134, 153);
            this.comboBoxSinifSecimi.Name = "comboBoxSinifSecimi";
            this.comboBoxSinifSecimi.Size = new System.Drawing.Size(250, 28);
            this.comboBoxSinifSecimi.TabIndex = 4;
            this.comboBoxSinifSecimi.Text = "Sınıfınızı seçiniz...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemlerToolStripMenuItem,
            this.cikisToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 29);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlMenu});
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.islemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // xmlMenu
            // 
            this.xmlMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlDisaAktar,
            this.xmlIceriAktar});
            this.xmlMenu.Name = "xmlMenu";
            this.xmlMenu.Size = new System.Drawing.Size(224, 26);
            this.xmlMenu.Text = "XML";
            // 
            // cikisToolStripMenuItem1
            // 
            this.cikisToolStripMenuItem1.Name = "cikisToolStripMenuItem1";
            this.cikisToolStripMenuItem1.Size = new System.Drawing.Size(61, 25);
            this.cikisToolStripMenuItem1.Text = "Çıkış";
            this.cikisToolStripMenuItem1.Click += new System.EventHandler(this.cikisToolStripMenuItem1_Click);
            // 
            // groupBoxOgrenci
            // 
            this.groupBoxOgrenci.Controls.Add(this.checkBoxSecmeliTek);
            this.groupBoxOgrenci.Controls.Add(this.btnOgrenciEkle);
            this.groupBoxOgrenci.Controls.Add(this.txtSoyad);
            this.groupBoxOgrenci.Controls.Add(this.comboBoxSinifSecimi);
            this.groupBoxOgrenci.Controls.Add(this.lblAd);
            this.groupBoxOgrenci.Controls.Add(this.dateTimePickerDTarihi);
            this.groupBoxOgrenci.Controls.Add(this.lblSoyad);
            this.groupBoxOgrenci.Controls.Add(this.lblDTarihi);
            this.groupBoxOgrenci.Controls.Add(this.lblSinifSecimi);
            this.groupBoxOgrenci.Controls.Add(this.txtAd);
            this.groupBoxOgrenci.Location = new System.Drawing.Point(32, 53);
            this.groupBoxOgrenci.Name = "groupBoxOgrenci";
            this.groupBoxOgrenci.Size = new System.Drawing.Size(589, 268);
            this.groupBoxOgrenci.TabIndex = 21;
            this.groupBoxOgrenci.TabStop = false;
            this.groupBoxOgrenci.Text = "Öğrenci Bilgileri";
            // 
            // checkBoxSecmeliTek
            // 
            this.checkBoxSecmeliTek.AutoSize = true;
            this.checkBoxSecmeliTek.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSecmeliTek.Location = new System.Drawing.Point(57, 211);
            this.checkBoxSecmeliTek.Name = "checkBoxSecmeliTek";
            this.checkBoxSecmeliTek.Size = new System.Drawing.Size(340, 24);
            this.checkBoxSecmeliTek.TabIndex = 6;
            this.checkBoxSecmeliTek.Text = "Seçmeli ders almak istiyor musnuz?";
            this.checkBoxSecmeliTek.UseVisualStyleBackColor = true;
            this.checkBoxSecmeliTek.CheckedChanged += new System.EventHandler(this.checkBoxSecmeliTek_CheckedChanged);
            // 
            // groupBoxSecmeliDersler
            // 
            this.groupBoxSecmeliDersler.Controls.Add(this.checkedListBoxSecmeli);
            this.groupBoxSecmeliDersler.Location = new System.Drawing.Point(662, 53);
            this.groupBoxSecmeliDersler.Name = "groupBoxSecmeliDersler";
            this.groupBoxSecmeliDersler.Size = new System.Drawing.Size(285, 268);
            this.groupBoxSecmeliDersler.TabIndex = 22;
            this.groupBoxSecmeliDersler.TabStop = false;
            this.groupBoxSecmeliDersler.Text = "Seçmeli Dersler";
            // 
            // checkedListBoxSecmeli
            // 
            this.checkedListBoxSecmeli.FormattingEnabled = true;
            this.checkedListBoxSecmeli.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Toplum Hizmetleri\t",
            "İtalyanca",
            "Halk Sağlığı",
            "Evrim Teorisi"});
            this.checkedListBoxSecmeli.Location = new System.Drawing.Point(17, 33);
            this.checkedListBoxSecmeli.Name = "checkedListBoxSecmeli";
            this.checkedListBoxSecmeli.Size = new System.Drawing.Size(253, 202);
            this.checkedListBoxSecmeli.TabIndex = 23;
            this.checkedListBoxSecmeli.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSecmeli_SelectedIndexChanged);
            // 
            // xmlDisaAktar
            // 
            this.xmlDisaAktar.Name = "xmlDisaAktar";
            this.xmlDisaAktar.Size = new System.Drawing.Size(242, 26);
            this.xmlDisaAktar.Text = "XML ile dışarı aktar";
            this.xmlDisaAktar.Click += new System.EventHandler(this.xmlDisaAktar_Click);
            // 
            // xmlIceriAktar
            // 
            this.xmlIceriAktar.Name = "xmlIceriAktar";
            this.xmlIceriAktar.Size = new System.Drawing.Size(242, 26);
            this.xmlIceriAktar.Text = "XML ile içeri aktar";
            this.xmlIceriAktar.Click += new System.EventHandler(this.xmlIceriAktar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(965, 616);
            this.Controls.Add(this.groupBoxSecmeliDersler);
            this.Controls.Add(this.groupBoxOgrenci);
            this.Controls.Add(this.btnHepsiniSolaGonder);
            this.Controls.Add(this.btnSolaGonder);
            this.Controls.Add(this.btnHepsiniSagaGonder);
            this.Controls.Add(this.btnSagaGonder);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBoxBSinifi);
            this.Controls.Add(this.listBoxASinifi);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Öğrenci Ekle Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxOgrenci.ResumeLayout(false);
            this.groupBoxOgrenci.PerformLayout();
            this.groupBoxSecmeliDersler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDTarihi;
        private System.Windows.Forms.ListBox listBoxASinifi;
        private System.Windows.Forms.ListBox listBoxBSinifi;
        private System.Windows.Forms.Label lblSinifSecimi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnSagaGonder;
        private System.Windows.Forms.Button btnHepsiniSagaGonder;
        private System.Windows.Forms.Button btnSolaGonder;
        private System.Windows.Forms.Button btnHepsiniSolaGonder;
        private System.Windows.Forms.DateTimePicker dateTimePickerDTarihi;
        private System.Windows.Forms.ComboBox comboBoxSinifSecimi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem islemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBoxOgrenci;
        private System.Windows.Forms.CheckBox checkBoxSecmeliTek;
        private System.Windows.Forms.GroupBox groupBoxSecmeliDersler;
        private System.Windows.Forms.CheckedListBox checkedListBoxSecmeli;
        private System.Windows.Forms.ToolStripMenuItem xmlMenu;
        private System.Windows.Forms.ToolStripMenuItem xmlDisaAktar;
        private System.Windows.Forms.ToolStripMenuItem xmlIceriAktar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


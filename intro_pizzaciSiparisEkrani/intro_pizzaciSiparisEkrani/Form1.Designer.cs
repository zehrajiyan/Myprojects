namespace intro_pizzaciSiparisEkrani
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
			this.comboboxebat = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxsalam = new System.Windows.Forms.CheckBox();
			this.checkBoxsosis = new System.Windows.Forms.CheckBox();
			this.checkBoxsucuk = new System.Windows.Forms.CheckBox();
			this.checkBoxjalepeno = new System.Windows.Forms.CheckBox();
			this.checkBoxancuez = new System.Windows.Forms.CheckBox();
			this.checkBoxzeytin = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbltoplamtutar = new System.Windows.Forms.Label();
			this.radioButtonincekenar = new System.Windows.Forms.RadioButton();
			this.radioButtonkalınkenar = new System.Windows.Forms.RadioButton();
			this.btnsiparisekle = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSil = new System.Windows.Forms.Button();
			this.btntoplamhesapla = new System.Windows.Forms.Button();
			this.lblsiparistoplami = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.listboxcesit = new System.Windows.Forms.ListBox();
			this.listBoxsiparis = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboboxebat
			// 
			this.comboboxebat.FormattingEnabled = true;
			this.comboboxebat.Items.AddRange(new object[] {
            "Büyük",
            "Küçük",
            "Orta"});
			this.comboboxebat.Location = new System.Drawing.Point(57, 54);
			this.comboboxebat.Name = "comboboxebat";
			this.comboboxebat.Size = new System.Drawing.Size(146, 21);
			this.comboboxebat.TabIndex = 0;
			this.comboboxebat.SelectedIndexChanged += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			this.comboboxebat.Click += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ebat :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(288, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Adet :";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(330, 58);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Çeşit :";
			// 
			// checkBoxsalam
			// 
			this.checkBoxsalam.AutoSize = true;
			this.checkBoxsalam.Location = new System.Drawing.Point(209, 101);
			this.checkBoxsalam.Name = "checkBoxsalam";
			this.checkBoxsalam.Size = new System.Drawing.Size(55, 17);
			this.checkBoxsalam.TabIndex = 6;
			this.checkBoxsalam.Text = "Salam";
			this.checkBoxsalam.UseVisualStyleBackColor = true;
			this.checkBoxsalam.Click += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			// 
			// checkBoxsosis
			// 
			this.checkBoxsosis.AutoSize = true;
			this.checkBoxsosis.Location = new System.Drawing.Point(209, 125);
			this.checkBoxsosis.Name = "checkBoxsosis";
			this.checkBoxsosis.Size = new System.Drawing.Size(51, 17);
			this.checkBoxsosis.TabIndex = 7;
			this.checkBoxsosis.Text = "Sosis";
			this.checkBoxsosis.UseVisualStyleBackColor = true;
			this.checkBoxsosis.Click += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			// 
			// checkBoxsucuk
			// 
			this.checkBoxsucuk.AutoSize = true;
			this.checkBoxsucuk.Location = new System.Drawing.Point(210, 149);
			this.checkBoxsucuk.Name = "checkBoxsucuk";
			this.checkBoxsucuk.Size = new System.Drawing.Size(57, 17);
			this.checkBoxsucuk.TabIndex = 8;
			this.checkBoxsucuk.Text = "Sucuk";
			this.checkBoxsucuk.UseVisualStyleBackColor = true;
			this.checkBoxsucuk.Click += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			// 
			// checkBoxjalepeno
			// 
			this.checkBoxjalepeno.AutoSize = true;
			this.checkBoxjalepeno.Location = new System.Drawing.Point(209, 173);
			this.checkBoxjalepeno.Name = "checkBoxjalepeno";
			this.checkBoxjalepeno.Size = new System.Drawing.Size(69, 17);
			this.checkBoxjalepeno.TabIndex = 9;
			this.checkBoxjalepeno.Text = "Jalepeno";
			this.checkBoxjalepeno.UseVisualStyleBackColor = true;
			this.checkBoxjalepeno.Click += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			// 
			// checkBoxancuez
			// 
			this.checkBoxancuez.AutoSize = true;
			this.checkBoxancuez.Location = new System.Drawing.Point(210, 197);
			this.checkBoxancuez.Name = "checkBoxancuez";
			this.checkBoxancuez.Size = new System.Drawing.Size(62, 17);
			this.checkBoxancuez.TabIndex = 10;
			this.checkBoxancuez.Text = "Ançüez";
			this.checkBoxancuez.UseVisualStyleBackColor = true;
			this.checkBoxancuez.Click += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			// 
			// checkBoxzeytin
			// 
			this.checkBoxzeytin.AutoSize = true;
			this.checkBoxzeytin.Location = new System.Drawing.Point(210, 221);
			this.checkBoxzeytin.Name = "checkBoxzeytin";
			this.checkBoxzeytin.Size = new System.Drawing.Size(55, 17);
			this.checkBoxzeytin.TabIndex = 11;
			this.checkBoxzeytin.Text = "Zeytin";
			this.checkBoxzeytin.UseVisualStyleBackColor = true;
			this.checkBoxzeytin.Click += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(327, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Toplam Tutar :";
			// 
			// lbltoplamtutar
			// 
			this.lbltoplamtutar.AutoSize = true;
			this.lbltoplamtutar.Location = new System.Drawing.Point(370, 176);
			this.lbltoplamtutar.Name = "lbltoplamtutar";
			this.lbltoplamtutar.Size = new System.Drawing.Size(16, 13);
			this.lbltoplamtutar.TabIndex = 13;
			this.lbltoplamtutar.Text = "...";
			// 
			// radioButtonincekenar
			// 
			this.radioButtonincekenar.AutoSize = true;
			this.radioButtonincekenar.Location = new System.Drawing.Point(57, 272);
			this.radioButtonincekenar.Name = "radioButtonincekenar";
			this.radioButtonincekenar.Size = new System.Drawing.Size(77, 17);
			this.radioButtonincekenar.TabIndex = 14;
			this.radioButtonincekenar.TabStop = true;
			this.radioButtonincekenar.Text = "İnce Kenar";
			this.radioButtonincekenar.UseVisualStyleBackColor = true;
			// 
			// radioButtonkalınkenar
			// 
			this.radioButtonkalınkenar.AutoSize = true;
			this.radioButtonkalınkenar.Checked = true;
			this.radioButtonkalınkenar.Location = new System.Drawing.Point(164, 272);
			this.radioButtonkalınkenar.Name = "radioButtonkalınkenar";
			this.radioButtonkalınkenar.Size = new System.Drawing.Size(79, 17);
			this.radioButtonkalınkenar.TabIndex = 15;
			this.radioButtonkalınkenar.TabStop = true;
			this.radioButtonkalınkenar.Text = "Kalın Kenar";
			this.radioButtonkalınkenar.UseVisualStyleBackColor = true;
			// 
			// btnsiparisekle
			// 
			this.btnsiparisekle.Location = new System.Drawing.Point(57, 295);
			this.btnsiparisekle.Name = "btnsiparisekle";
			this.btnsiparisekle.Size = new System.Drawing.Size(423, 29);
			this.btnsiparisekle.TabIndex = 16;
			this.btnsiparisekle.Text = "Seçilen özellikteki pizzayı sparişe ekle";
			this.btnsiparisekle.UseVisualStyleBackColor = true;
			this.btnsiparisekle.Click += new System.EventHandler(this.btnsiparisekle_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(54, 331);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Spariş detayı";
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(330, 347);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(150, 23);
			this.btnSil.TabIndex = 19;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btntoplamhesapla
			// 
			this.btntoplamhesapla.Location = new System.Drawing.Point(330, 389);
			this.btntoplamhesapla.Name = "btntoplamhesapla";
			this.btntoplamhesapla.Size = new System.Drawing.Size(150, 23);
			this.btntoplamhesapla.TabIndex = 20;
			this.btntoplamhesapla.Text = "Sipariş toplamını hesapla";
			this.btntoplamhesapla.UseVisualStyleBackColor = true;
			// 
			// lblsiparistoplami
			// 
			this.lblsiparistoplami.AutoSize = true;
			this.lblsiparistoplami.Location = new System.Drawing.Point(461, 456);
			this.lblsiparistoplami.Name = "lblsiparistoplami";
			this.lblsiparistoplami.Size = new System.Drawing.Size(19, 13);
			this.lblsiparistoplami.TabIndex = 21;
			this.lblsiparistoplami.Text = "....";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(327, 456);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "Siparis toplamı :";
			// 
			// listboxcesit
			// 
			this.listboxcesit.FormattingEnabled = true;
			this.listboxcesit.Items.AddRange(new object[] {
            "Classic",
            "Turkish",
            "ExtraKavanoz",
            "Kumrucuk",
            "Biberli",
            "Mexican",
            "Kızıl"});
			this.listboxcesit.Location = new System.Drawing.Point(62, 101);
			this.listboxcesit.Name = "listboxcesit";
			this.listboxcesit.Size = new System.Drawing.Size(141, 147);
			this.listboxcesit.TabIndex = 23;
			this.listboxcesit.Click += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			this.listboxcesit.SelectedIndexChanged += new System.EventHandler(this.listboxcesit_SelectedIndexChanged);
			// 
			// listBoxsiparis
			// 
			this.listBoxsiparis.FormattingEnabled = true;
			this.listBoxsiparis.Location = new System.Drawing.Point(57, 347);
			this.listBoxsiparis.Name = "listBoxsiparis";
			this.listBoxsiparis.Size = new System.Drawing.Size(243, 134);
			this.listBoxsiparis.TabIndex = 24;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 514);
			this.Controls.Add(this.listBoxsiparis);
			this.Controls.Add(this.listboxcesit);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblsiparistoplami);
			this.Controls.Add(this.btntoplamhesapla);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnsiparisekle);
			this.Controls.Add(this.radioButtonkalınkenar);
			this.Controls.Add(this.radioButtonincekenar);
			this.Controls.Add(this.lbltoplamtutar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkBoxzeytin);
			this.Controls.Add(this.checkBoxancuez);
			this.Controls.Add(this.checkBoxjalepeno);
			this.Controls.Add(this.checkBoxsucuk);
			this.Controls.Add(this.checkBoxsosis);
			this.Controls.Add(this.checkBoxsalam);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboboxebat);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboboxebat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBoxsalam;
		private System.Windows.Forms.CheckBox checkBoxsosis;
		private System.Windows.Forms.CheckBox checkBoxsucuk;
		private System.Windows.Forms.CheckBox checkBoxjalepeno;
		private System.Windows.Forms.CheckBox checkBoxancuez;
		private System.Windows.Forms.CheckBox checkBoxzeytin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbltoplamtutar;
		private System.Windows.Forms.RadioButton radioButtonincekenar;
		private System.Windows.Forms.RadioButton radioButtonkalınkenar;
		private System.Windows.Forms.Button btnsiparisekle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btntoplamhesapla;
		private System.Windows.Forms.Label lblsiparistoplami;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox listboxcesit;
		private System.Windows.Forms.ListBox listBoxsiparis;
	}
}


namespace BiletSatis
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.satbutton = new System.Windows.Forms.Button();
            this.iptalbutton = new System.Windows.Forms.Button();
            this.bakiyebutton = new System.Windows.Forms.Button();
            this.bosbutton = new System.Windows.Forms.Button();
            this.olusturbutton = new System.Windows.Forms.Button();
            this.salontext = new System.Windows.Forms.TextBox();
            this.koltuktext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.indirimlicheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // satbutton
            // 
            this.satbutton.Location = new System.Drawing.Point(6, 90);
            this.satbutton.Name = "satbutton";
            this.satbutton.Size = new System.Drawing.Size(75, 49);
            this.satbutton.TabIndex = 0;
            this.satbutton.Text = "BİLET SAT";
            this.satbutton.UseVisualStyleBackColor = true;
            this.satbutton.Click += new System.EventHandler(this.satbutton_Click);
            // 
            // iptalbutton
            // 
            this.iptalbutton.Location = new System.Drawing.Point(101, 90);
            this.iptalbutton.Name = "iptalbutton";
            this.iptalbutton.Size = new System.Drawing.Size(93, 49);
            this.iptalbutton.TabIndex = 1;
            this.iptalbutton.Text = "BİLET İPTAL";
            this.iptalbutton.UseVisualStyleBackColor = true;
            this.iptalbutton.Click += new System.EventHandler(this.iptalbutton_Click);
            // 
            // bakiyebutton
            // 
            this.bakiyebutton.Location = new System.Drawing.Point(6, 90);
            this.bakiyebutton.Name = "bakiyebutton";
            this.bakiyebutton.Size = new System.Drawing.Size(75, 49);
            this.bakiyebutton.TabIndex = 2;
            this.bakiyebutton.Text = "BAKİYE";
            this.bakiyebutton.UseVisualStyleBackColor = true;
            this.bakiyebutton.Click += new System.EventHandler(this.bakiyebutton_Click);
            // 
            // bosbutton
            // 
            this.bosbutton.Location = new System.Drawing.Point(112, 90);
            this.bosbutton.Name = "bosbutton";
            this.bosbutton.Size = new System.Drawing.Size(75, 49);
            this.bosbutton.TabIndex = 3;
            this.bosbutton.Text = "BOŞ KOLTUK";
            this.bosbutton.UseVisualStyleBackColor = true;
            this.bosbutton.Click += new System.EventHandler(this.bosbutton_Click);
            // 
            // olusturbutton
            // 
            this.olusturbutton.Location = new System.Drawing.Point(334, 74);
            this.olusturbutton.Name = "olusturbutton";
            this.olusturbutton.Size = new System.Drawing.Size(100, 55);
            this.olusturbutton.TabIndex = 4;
            this.olusturbutton.Text = "OLUŞTUR";
            this.olusturbutton.UseVisualStyleBackColor = true;
            this.olusturbutton.Click += new System.EventHandler(this.olusturbutton_Click);
            // 
            // salontext
            // 
            this.salontext.Location = new System.Drawing.Point(151, 69);
            this.salontext.Name = "salontext";
            this.salontext.Size = new System.Drawing.Size(142, 20);
            this.salontext.TabIndex = 5;
            // 
            // koltuktext
            // 
            this.koltuktext.Location = new System.Drawing.Point(151, 104);
            this.koltuktext.Name = "koltuktext";
            this.koltuktext.Size = new System.Drawing.Size(142, 20);
            this.koltuktext.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Salon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Koltuk Sayısı";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.indirimlicheckBox);
            this.groupBox1.Controls.Add(this.satbutton);
            this.groupBox1.Controls.Add(this.iptalbutton);
            this.groupBox1.Location = new System.Drawing.Point(50, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 145);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATIŞ-İPTAL";
            // 
            // indirimlicheckBox
            // 
            this.indirimlicheckBox.AutoSize = true;
            this.indirimlicheckBox.Location = new System.Drawing.Point(6, 35);
            this.indirimlicheckBox.Name = "indirimlicheckBox";
            this.indirimlicheckBox.Size = new System.Drawing.Size(77, 17);
            this.indirimlicheckBox.TabIndex = 2;
            this.indirimlicheckBox.Text = "İNDİRİMLİ";
            this.indirimlicheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bosbutton);
            this.groupBox2.Controls.Add(this.bakiyebutton);
            this.groupBox2.Location = new System.Drawing.Point(273, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 145);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAPOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.koltuktext);
            this.Controls.Add(this.salontext);
            this.Controls.Add(this.olusturbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button satbutton;
        private System.Windows.Forms.Button iptalbutton;
        private System.Windows.Forms.Button bakiyebutton;
        private System.Windows.Forms.Button bosbutton;
        private System.Windows.Forms.Button olusturbutton;
        private System.Windows.Forms.TextBox salontext;
        private System.Windows.Forms.TextBox koltuktext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox indirimlicheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}


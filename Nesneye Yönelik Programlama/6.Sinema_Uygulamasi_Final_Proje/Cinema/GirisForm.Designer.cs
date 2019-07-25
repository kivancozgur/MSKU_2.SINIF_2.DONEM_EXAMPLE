namespace Cinema
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.GirisButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.usernameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.GirisPanel = new System.Windows.Forms.Panel();
            this.KayitLabel = new System.Windows.Forms.LinkLabel();
            this.CikisButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KayitPanel = new System.Windows.Forms.Panel();
            this.CikisButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.GirisLabel = new System.Windows.Forms.LinkLabel();
            this.KayitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.YeniSifreText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.YeniAdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GirisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.KayitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisButton
            // 
            this.GirisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisButton.Depth = 0;
            this.GirisButton.Location = new System.Drawing.Point(125, 206);
            this.GirisButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Primary = true;
            this.GirisButton.Size = new System.Drawing.Size(106, 41);
            this.GirisButton.TabIndex = 3;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Depth = 0;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTextBox.Hint = "";
            this.usernameTextBox.Location = new System.Drawing.Point(125, 85);
            this.usernameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.Size = new System.Drawing.Size(228, 26);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.UseSystemPasswordChar = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AccessibleName = "";
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Hint = "";
            this.passwordTextBox.Location = new System.Drawing.Point(125, 138);
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.Size = new System.Drawing.Size(228, 26);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Tag = "";
            this.passwordTextBox.UseSystemPasswordChar = false;
            // 
            // GirisPanel
            // 
            this.GirisPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GirisPanel.Controls.Add(this.KayitLabel);
            this.GirisPanel.Controls.Add(this.CikisButton);
            this.GirisPanel.Controls.Add(this.pictureBox2);
            this.GirisPanel.Controls.Add(this.pictureBox1);
            this.GirisPanel.Controls.Add(this.GirisButton);
            this.GirisPanel.Controls.Add(this.passwordTextBox);
            this.GirisPanel.Controls.Add(this.usernameTextBox);
            this.GirisPanel.Location = new System.Drawing.Point(662, 285);
            this.GirisPanel.Name = "GirisPanel";
            this.GirisPanel.Size = new System.Drawing.Size(416, 341);
            this.GirisPanel.TabIndex = 5;
            // 
            // KayitLabel
            // 
            this.KayitLabel.AutoSize = true;
            this.KayitLabel.Font = new System.Drawing.Font("Roboto", 10F);
            this.KayitLabel.Location = new System.Drawing.Point(276, 283);
            this.KayitLabel.Name = "KayitLabel";
            this.KayitLabel.Size = new System.Drawing.Size(77, 20);
            this.KayitLabel.TabIndex = 8;
            this.KayitLabel.TabStop = true;
            this.KayitLabel.Text = "KAYIT OL";
            this.KayitLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KayitLabel_LinkClicked);
            // 
            // CikisButton
            // 
            this.CikisButton.BackColor = System.Drawing.Color.Silver;
            this.CikisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CikisButton.Depth = 0;
            this.CikisButton.Location = new System.Drawing.Point(259, 206);
            this.CikisButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CikisButton.Name = "CikisButton";
            this.CikisButton.Primary = true;
            this.CikisButton.Size = new System.Drawing.Size(94, 41);
            this.CikisButton.TabIndex = 4;
            this.CikisButton.Text = "ÇIKIŞ";
            this.CikisButton.UseVisualStyleBackColor = false;
            this.CikisButton.Click += new System.EventHandler(this.CikisButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(80, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(196)))), ((int)(((byte)(155)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1219, 96);
            this.panel4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 28.14545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(60, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 52);
            this.label5.TabIndex = 0;
            this.label5.Text = "KIVANCSOFT";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.KayitPanel);
            this.panel1.Controls.Add(this.GirisPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 738);
            this.panel1.TabIndex = 8;
            // 
            // KayitPanel
            // 
            this.KayitPanel.Controls.Add(this.CikisButton2);
            this.KayitPanel.Controls.Add(this.GirisLabel);
            this.KayitPanel.Controls.Add(this.KayitButton);
            this.KayitPanel.Controls.Add(this.YeniSifreText);
            this.KayitPanel.Controls.Add(this.YeniAdText);
            this.KayitPanel.Controls.Add(this.pictureBox3);
            this.KayitPanel.Controls.Add(this.pictureBox4);
            this.KayitPanel.Location = new System.Drawing.Point(665, 282);
            this.KayitPanel.Name = "KayitPanel";
            this.KayitPanel.Size = new System.Drawing.Size(416, 341);
            this.KayitPanel.TabIndex = 6;
            this.KayitPanel.Visible = false;
            // 
            // CikisButton2
            // 
            this.CikisButton2.BackColor = System.Drawing.Color.Silver;
            this.CikisButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CikisButton2.Depth = 0;
            this.CikisButton2.Location = new System.Drawing.Point(239, 206);
            this.CikisButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.CikisButton2.Name = "CikisButton2";
            this.CikisButton2.Primary = true;
            this.CikisButton2.Size = new System.Drawing.Size(111, 48);
            this.CikisButton2.TabIndex = 18;
            this.CikisButton2.Text = "ÇIKIŞ";
            this.CikisButton2.UseVisualStyleBackColor = false;
            this.CikisButton2.Click += new System.EventHandler(this.CikisButton2_Click);
            // 
            // GirisLabel
            // 
            this.GirisLabel.AutoSize = true;
            this.GirisLabel.Font = new System.Drawing.Font("Roboto", 10F);
            this.GirisLabel.Location = new System.Drawing.Point(269, 283);
            this.GirisLabel.Name = "GirisLabel";
            this.GirisLabel.Size = new System.Drawing.Size(81, 20);
            this.GirisLabel.TabIndex = 17;
            this.GirisLabel.TabStop = true;
            this.GirisLabel.Text = "GİRİŞ YAP";
            this.GirisLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GirisLabel_LinkClicked);
            // 
            // KayitButton
            // 
            this.KayitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KayitButton.Depth = 0;
            this.KayitButton.Location = new System.Drawing.Point(86, 206);
            this.KayitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.KayitButton.Name = "KayitButton";
            this.KayitButton.Primary = true;
            this.KayitButton.Size = new System.Drawing.Size(127, 48);
            this.KayitButton.TabIndex = 16;
            this.KayitButton.Text = "KAYIT OL";
            this.KayitButton.UseVisualStyleBackColor = true;
            this.KayitButton.Click += new System.EventHandler(this.KayitButton_Click);
            // 
            // YeniSifreText
            // 
            this.YeniSifreText.Depth = 0;
            this.YeniSifreText.Hint = "";
            this.YeniSifreText.Location = new System.Drawing.Point(140, 127);
            this.YeniSifreText.MouseState = MaterialSkin.MouseState.HOVER;
            this.YeniSifreText.Name = "YeniSifreText";
            this.YeniSifreText.PasswordChar = '*';
            this.YeniSifreText.SelectedText = "";
            this.YeniSifreText.SelectionLength = 0;
            this.YeniSifreText.SelectionStart = 0;
            this.YeniSifreText.Size = new System.Drawing.Size(193, 26);
            this.YeniSifreText.TabIndex = 15;
            this.YeniSifreText.UseSystemPasswordChar = false;
            // 
            // YeniAdText
            // 
            this.YeniAdText.Depth = 0;
            this.YeniAdText.Hint = "";
            this.YeniAdText.Location = new System.Drawing.Point(140, 74);
            this.YeniAdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.YeniAdText.Name = "YeniAdText";
            this.YeniAdText.PasswordChar = '\0';
            this.YeniAdText.SelectedText = "";
            this.YeniAdText.SelectionLength = 0;
            this.YeniAdText.SelectionStart = 0;
            this.YeniAdText.Size = new System.Drawing.Size(193, 26);
            this.YeniAdText.TabIndex = 14;
            this.YeniAdText.UseSystemPasswordChar = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(86, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(86, 74);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 834);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GirisForm_Load);
            this.GirisPanel.ResumeLayout(false);
            this.GirisPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.KayitPanel.ResumeLayout(false);
            this.KayitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton GirisButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextBox;
        private System.Windows.Forms.Panel GirisPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialRaisedButton CikisButton;
        private System.Windows.Forms.LinkLabel KayitLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel KayitPanel;
        private System.Windows.Forms.LinkLabel GirisLabel;
        private MaterialSkin.Controls.MaterialRaisedButton KayitButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField YeniSifreText;
        private MaterialSkin.Controls.MaterialSingleLineTextField YeniAdText;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialRaisedButton CikisButton2;
    }
}


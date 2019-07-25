namespace WindowsFormsApp1
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.kapinoText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.adText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.adresText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(126, 324);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(86, 28);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Ekle";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(33, 161);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 22);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Kapı No";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(60, 208);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(43, 22);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "İsim";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(48, 264);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 22);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Adres";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Roboto Cn", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(387, 161);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 324);
            this.listBox1.TabIndex = 6;
            // 
            // kapinoText
            // 
            this.kapinoText.Depth = 0;
            this.kapinoText.Hint = "";
            this.kapinoText.Location = new System.Drawing.Point(126, 161);
            this.kapinoText.MouseState = MaterialSkin.MouseState.HOVER;
            this.kapinoText.Name = "kapinoText";
            this.kapinoText.PasswordChar = '\0';
            this.kapinoText.SelectedText = "";
            this.kapinoText.SelectionLength = 0;
            this.kapinoText.SelectionStart = 0;
            this.kapinoText.Size = new System.Drawing.Size(58, 26);
            this.kapinoText.TabIndex = 10;
            this.kapinoText.UseSystemPasswordChar = false;
            // 
            // adText
            // 
            this.adText.Depth = 0;
            this.adText.Hint = "";
            this.adText.Location = new System.Drawing.Point(126, 208);
            this.adText.MouseState = MaterialSkin.MouseState.HOVER;
            this.adText.Name = "adText";
            this.adText.PasswordChar = '\0';
            this.adText.SelectedText = "";
            this.adText.SelectionLength = 0;
            this.adText.SelectionStart = 0;
            this.adText.Size = new System.Drawing.Size(164, 26);
            this.adText.TabIndex = 11;
            this.adText.UseSystemPasswordChar = false;
            // 
            // adresText
            // 
            this.adresText.Depth = 0;
            this.adresText.Hint = "";
            this.adresText.Location = new System.Drawing.Point(126, 264);
            this.adresText.MouseState = MaterialSkin.MouseState.HOVER;
            this.adresText.Name = "adresText";
            this.adresText.PasswordChar = '\0';
            this.adresText.SelectedText = "";
            this.adresText.SelectionLength = 0;
            this.adresText.SelectionStart = 0;
            this.adresText.Size = new System.Drawing.Size(214, 26);
            this.adresText.TabIndex = 12;
            this.adresText.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(238, 324);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(91, 28);
            this.materialRaisedButton2.TabIndex = 13;
            this.materialRaisedButton2.Text = "SIFIRLA";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 589);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.adresText);
            this.Controls.Add(this.adText);
            this.Controls.Add(this.kapinoText);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField kapinoText;
        private MaterialSkin.Controls.MaterialSingleLineTextField adText;
        private MaterialSkin.Controls.MaterialSingleLineTextField adresText;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}


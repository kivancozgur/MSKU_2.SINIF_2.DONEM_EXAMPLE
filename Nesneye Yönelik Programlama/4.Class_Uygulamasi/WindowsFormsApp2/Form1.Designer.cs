namespace WindowsFormsApp2
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
            this.yilText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.yakitText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.kmText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.fiyatText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // yilText
            // 
            this.yilText.Depth = 0;
            this.yilText.Hint = "";
            this.yilText.Location = new System.Drawing.Point(142, 107);
            this.yilText.MouseState = MaterialSkin.MouseState.HOVER;
            this.yilText.Name = "yilText";
            this.yilText.PasswordChar = '\0';
            this.yilText.SelectedText = "";
            this.yilText.SelectionLength = 0;
            this.yilText.SelectionStart = 0;
            this.yilText.Size = new System.Drawing.Size(135, 26);
            this.yilText.TabIndex = 0;
            this.yilText.UseSystemPasswordChar = false;
            // 
            // yakitText
            // 
            this.yakitText.Depth = 0;
            this.yakitText.Hint = "";
            this.yakitText.Location = new System.Drawing.Point(142, 139);
            this.yakitText.MouseState = MaterialSkin.MouseState.HOVER;
            this.yakitText.Name = "yakitText";
            this.yakitText.PasswordChar = '\0';
            this.yakitText.SelectedText = "";
            this.yakitText.SelectionLength = 0;
            this.yakitText.SelectionStart = 0;
            this.yakitText.Size = new System.Drawing.Size(135, 26);
            this.yakitText.TabIndex = 1;
            this.yakitText.UseSystemPasswordChar = false;
            // 
            // kmText
            // 
            this.kmText.Depth = 0;
            this.kmText.Hint = "";
            this.kmText.Location = new System.Drawing.Point(142, 171);
            this.kmText.MouseState = MaterialSkin.MouseState.HOVER;
            this.kmText.Name = "kmText";
            this.kmText.PasswordChar = '\0';
            this.kmText.SelectedText = "";
            this.kmText.SelectionLength = 0;
            this.kmText.SelectionStart = 0;
            this.kmText.Size = new System.Drawing.Size(135, 26);
            this.kmText.TabIndex = 2;
            this.kmText.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(105, 111);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(28, 22);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Yıl";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(18, 143);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(118, 22);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Yakıt (100km)";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(97, 175);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(36, 22);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Km";
            // 
            // fiyatText
            // 
            this.fiyatText.Depth = 0;
            this.fiyatText.Hint = "";
            this.fiyatText.Location = new System.Drawing.Point(142, 203);
            this.fiyatText.MouseState = MaterialSkin.MouseState.HOVER;
            this.fiyatText.Name = "fiyatText";
            this.fiyatText.PasswordChar = '\0';
            this.fiyatText.SelectedText = "";
            this.fiyatText.SelectionLength = 0;
            this.fiyatText.SelectionStart = 0;
            this.fiyatText.Size = new System.Drawing.Size(135, 26);
            this.fiyatText.TabIndex = 4;
            this.fiyatText.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(49, 207);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(84, 22);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Litre Fiyat";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(189, 258);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(88, 39);
            this.materialRaisedButton1.TabIndex = 7;
            this.materialRaisedButton1.Text = "99";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(60, 265);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.fiyatText);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.kmText);
            this.Controls.Add(this.yakitText);
            this.Controls.Add(this.yilText);
            this.Name = "Form1";
            this.Text = "Araba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField yilText;
        private MaterialSkin.Controls.MaterialSingleLineTextField yakitText;
        private MaterialSkin.Controls.MaterialSingleLineTextField kmText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField fiyatText;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel label1;
    }
}


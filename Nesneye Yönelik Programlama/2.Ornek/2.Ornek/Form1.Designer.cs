﻿namespace _2.Ornek
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
            this.button1 = new System.Windows.Forms.Button();
            this.vizetext = new System.Windows.Forms.TextBox();
            this.finaltext = new System.Windows.Forms.TextBox();
            this.kvizetext = new System.Windows.Forms.TextBox();
            this.kfinaltext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vizetext
            // 
            this.vizetext.Location = new System.Drawing.Point(105, 69);
            this.vizetext.Name = "vizetext";
            this.vizetext.Size = new System.Drawing.Size(100, 20);
            this.vizetext.TabIndex = 1;
            // 
            // finaltext
            // 
            this.finaltext.Location = new System.Drawing.Point(105, 113);
            this.finaltext.Name = "finaltext";
            this.finaltext.Size = new System.Drawing.Size(100, 20);
            this.finaltext.TabIndex = 2;
            // 
            // kvizetext
            // 
            this.kvizetext.Location = new System.Drawing.Point(105, 159);
            this.kvizetext.Name = "kvizetext";
            this.kvizetext.Size = new System.Drawing.Size(100, 20);
            this.kvizetext.TabIndex = 3;
            // 
            // kfinaltext
            // 
            this.kfinaltext.Location = new System.Drawing.Point(105, 208);
            this.kfinaltext.Name = "kfinaltext";
            this.kfinaltext.Size = new System.Drawing.Size(100, 20);
            this.kfinaltext.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vize Katkı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Final Katkı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kfinaltext);
            this.Controls.Add(this.kvizetext);
            this.Controls.Add(this.finaltext);
            this.Controls.Add(this.vizetext);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox vizetext;
        private System.Windows.Forms.TextBox finaltext;
        private System.Windows.Forms.TextBox kvizetext;
        private System.Windows.Forms.TextBox kfinaltext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


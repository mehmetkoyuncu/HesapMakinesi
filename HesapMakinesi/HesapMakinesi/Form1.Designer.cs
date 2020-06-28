namespace HesapMakinesi
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
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.txt2Sayi = new System.Windows.Forms.TextBox();
            this.ddlIslem = new System.Windows.Forms.ComboBox();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirinciSayi.Location = new System.Drawing.Point(21, 69);
            this.txtBirinciSayi.Multiline = true;
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(168, 41);
            this.txtBirinciSayi.TabIndex = 0;
            this.txtBirinciSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirinciSayi_KeyPress);
            // 
            // txt2Sayi
            // 
            this.txt2Sayi.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.txt2Sayi.Location = new System.Drawing.Point(247, 69);
            this.txt2Sayi.Multiline = true;
            this.txt2Sayi.Name = "txt2Sayi";
            this.txt2Sayi.Size = new System.Drawing.Size(168, 41);
            this.txt2Sayi.TabIndex = 2;
            this.txt2Sayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt2Sayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2Sayi_KeyPress);
            // 
            // ddlIslem
            // 
            this.ddlIslem.BackColor = System.Drawing.Color.Snow;
            this.ddlIslem.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.ddlIslem.FormattingEnabled = true;
            this.ddlIslem.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.ddlIslem.Location = new System.Drawing.Point(200, 69);
            this.ddlIslem.Name = "ddlIslem";
            this.ddlIslem.Size = new System.Drawing.Size(36, 41);
            this.ddlIslem.TabIndex = 1;
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSonuc.ForeColor = System.Drawing.Color.Snow;
            this.labelSonuc.Location = new System.Drawing.Point(121, 176);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(137, 58);
            this.labelSonuc.TabIndex = 4;
            this.labelSonuc.Text = "Sonuç :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btnHesapla.Location = new System.Drawing.Point(142, 131);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(162, 42);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(440, 243);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.ddlIslem);
            this.Controls.Add(this.txt2Sayi);
            this.Controls.Add(this.txtBirinciSayi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.TextBox txt2Sayi;
        private System.Windows.Forms.ComboBox ddlIslem;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Button btnHesapla;
    }
}



namespace Proje2
{
    partial class KullanıcıGirisi
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
            this.Kullaniciadilbl = new System.Windows.Forms.Label();
            this.Sifrelbl = new System.Windows.Forms.Label();
            this.txtboxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.GirisButton = new System.Windows.Forms.Button();
            this.yöneticirbutton = new System.Windows.Forms.RadioButton();
            this.musterirbutton = new System.Windows.Forms.RadioButton();
            this.txtboxSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Kullaniciadilbl
            // 
            this.Kullaniciadilbl.AutoSize = true;
            this.Kullaniciadilbl.Location = new System.Drawing.Point(112, 134);
            this.Kullaniciadilbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Kullaniciadilbl.Name = "Kullaniciadilbl";
            this.Kullaniciadilbl.Size = new System.Drawing.Size(124, 25);
            this.Kullaniciadilbl.TabIndex = 1;
            this.Kullaniciadilbl.Text = "Kullanıcı Adı:";
            // 
            // Sifrelbl
            // 
            this.Sifrelbl.AutoSize = true;
            this.Sifrelbl.Location = new System.Drawing.Point(197, 166);
            this.Sifrelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Sifrelbl.Name = "Sifrelbl";
            this.Sifrelbl.Size = new System.Drawing.Size(56, 25);
            this.Sifrelbl.TabIndex = 2;
            this.Sifrelbl.Text = "Şifre:";
            // 
            // txtboxKullaniciAdi
            // 
            this.txtboxKullaniciAdi.Location = new System.Drawing.Point(275, 126);
            this.txtboxKullaniciAdi.Name = "txtboxKullaniciAdi";
            this.txtboxKullaniciAdi.Size = new System.Drawing.Size(183, 33);
            this.txtboxKullaniciAdi.TabIndex = 3;
            // 
            // GirisButton
            // 
            this.GirisButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.GirisButton.Location = new System.Drawing.Point(340, 223);
            this.GirisButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(118, 49);
            this.GirisButton.TabIndex = 0;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.UseVisualStyleBackColor = false;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // yöneticirbutton
            // 
            this.yöneticirbutton.AutoSize = true;
            this.yöneticirbutton.Location = new System.Drawing.Point(147, 63);
            this.yöneticirbutton.Name = "yöneticirbutton";
            this.yöneticirbutton.Size = new System.Drawing.Size(140, 29);
            this.yöneticirbutton.TabIndex = 5;
            this.yöneticirbutton.TabStop = true;
            this.yöneticirbutton.Text = "YöneticiGirişi";
            this.yöneticirbutton.UseVisualStyleBackColor = true;
            // 
            // musterirbutton
            // 
            this.musterirbutton.AutoSize = true;
            this.musterirbutton.Location = new System.Drawing.Point(319, 63);
            this.musterirbutton.Name = "musterirbutton";
            this.musterirbutton.Size = new System.Drawing.Size(139, 29);
            this.musterirbutton.TabIndex = 6;
            this.musterirbutton.TabStop = true;
            this.musterirbutton.Text = "MüsteriGirişi";
            this.musterirbutton.UseVisualStyleBackColor = true;
            // 
            // txtboxSifre
            // 
            this.txtboxSifre.Location = new System.Drawing.Point(275, 166);
            this.txtboxSifre.Name = "txtboxSifre";
            this.txtboxSifre.PasswordChar = '*';
            this.txtboxSifre.Size = new System.Drawing.Size(183, 33);
            this.txtboxSifre.TabIndex = 4;
            // 
            // KullanıcıGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(638, 319);
            this.Controls.Add(this.musterirbutton);
            this.Controls.Add(this.yöneticirbutton);
            this.Controls.Add(this.txtboxSifre);
            this.Controls.Add(this.txtboxKullaniciAdi);
            this.Controls.Add(this.Sifrelbl);
            this.Controls.Add(this.Kullaniciadilbl);
            this.Controls.Add(this.GirisButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "KullanıcıGirisi";
            this.Text = "KullanıcıGirisi";
            this.Load += new System.EventHandler(this.KullanıcıGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Kullaniciadilbl;
        private System.Windows.Forms.Label Sifrelbl;
        private System.Windows.Forms.TextBox txtboxKullaniciAdi;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.RadioButton yöneticirbutton;
        private System.Windows.Forms.RadioButton musterirbutton;
        private System.Windows.Forms.TextBox txtboxSifre;
    }
}


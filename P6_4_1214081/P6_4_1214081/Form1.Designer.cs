namespace P6_4_1214081
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbNama = new System.Windows.Forms.Label();
            this.lbPendidikanTerakhir = new System.Windows.Forms.Label();
            this.lbKotaAsal = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbBeratSekarang = new System.Windows.Forms.Label();
            this.lbBeratTahunKemaren = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbPendidikanTerakhir = new System.Windows.Forms.TextBox();
            this.tbKotaAsal = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbBeratSekarang = new System.Windows.Forms.TextBox();
            this.tbBeratTahunKemaren = new System.Windows.Forms.TextBox();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.btTampilkan = new System.Windows.Forms.Button();
            this.tbUsernameValorant = new System.Windows.Forms.TextBox();
            this.lbUsernameValorant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(133, 53);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(35, 13);
            this.lbNama.TabIndex = 0;
            this.lbNama.Text = "Nama";
            // 
            // lbPendidikanTerakhir
            // 
            this.lbPendidikanTerakhir.AutoSize = true;
            this.lbPendidikanTerakhir.Location = new System.Drawing.Point(133, 123);
            this.lbPendidikanTerakhir.Name = "lbPendidikanTerakhir";
            this.lbPendidikanTerakhir.Size = new System.Drawing.Size(102, 13);
            this.lbPendidikanTerakhir.TabIndex = 1;
            this.lbPendidikanTerakhir.Text = "Pendidikan Terakhir";
            // 
            // lbKotaAsal
            // 
            this.lbKotaAsal.AutoSize = true;
            this.lbKotaAsal.Location = new System.Drawing.Point(133, 158);
            this.lbKotaAsal.Name = "lbKotaAsal";
            this.lbKotaAsal.Size = new System.Drawing.Size(52, 13);
            this.lbKotaAsal.TabIndex = 2;
            this.lbKotaAsal.Text = "Kota Asal";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(133, 193);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // lbBeratSekarang
            // 
            this.lbBeratSekarang.AutoSize = true;
            this.lbBeratSekarang.Location = new System.Drawing.Point(133, 228);
            this.lbBeratSekarang.Name = "lbBeratSekarang";
            this.lbBeratSekarang.Size = new System.Drawing.Size(139, 13);
            this.lbBeratSekarang.TabIndex = 6;
            this.lbBeratSekarang.Text = "Berat Badan Sekarang (KG)";
            // 
            // lbBeratTahunKemaren
            // 
            this.lbBeratTahunKemaren.AutoSize = true;
            this.lbBeratTahunKemaren.Location = new System.Drawing.Point(133, 263);
            this.lbBeratTahunKemaren.Name = "lbBeratTahunKemaren";
            this.lbBeratTahunKemaren.Size = new System.Drawing.Size(169, 13);
            this.lbBeratTahunKemaren.TabIndex = 7;
            this.lbBeratTahunKemaren.Text = "Berat Badan Tahun Kemaren (KG)";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(343, 50);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(216, 20);
            this.tbNama.TabIndex = 8;
            this.tbNama.Leave += new System.EventHandler(this.tbNama_Leave);
            // 
            // tbPendidikanTerakhir
            // 
            this.tbPendidikanTerakhir.Location = new System.Drawing.Point(343, 120);
            this.tbPendidikanTerakhir.Name = "tbPendidikanTerakhir";
            this.tbPendidikanTerakhir.Size = new System.Drawing.Size(216, 20);
            this.tbPendidikanTerakhir.TabIndex = 9;
            this.tbPendidikanTerakhir.Leave += new System.EventHandler(this.tbPendidikanTerakhir_Leave);
            // 
            // tbKotaAsal
            // 
            this.tbKotaAsal.Location = new System.Drawing.Point(343, 155);
            this.tbKotaAsal.Name = "tbKotaAsal";
            this.tbKotaAsal.Size = new System.Drawing.Size(216, 20);
            this.tbKotaAsal.TabIndex = 10;
            this.tbKotaAsal.Leave += new System.EventHandler(this.tbKotaAsal_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(343, 190);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(216, 20);
            this.tbEmail.TabIndex = 12;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbBeratSekarang
            // 
            this.tbBeratSekarang.Location = new System.Drawing.Point(343, 225);
            this.tbBeratSekarang.Name = "tbBeratSekarang";
            this.tbBeratSekarang.Size = new System.Drawing.Size(216, 20);
            this.tbBeratSekarang.TabIndex = 13;
            this.tbBeratSekarang.Leave += new System.EventHandler(this.tbBeratSekarang_Leave);
            // 
            // tbBeratTahunKemaren
            // 
            this.tbBeratTahunKemaren.Location = new System.Drawing.Point(343, 260);
            this.tbBeratTahunKemaren.Name = "tbBeratTahunKemaren";
            this.tbBeratTahunKemaren.Size = new System.Drawing.Size(216, 20);
            this.tbBeratTahunKemaren.TabIndex = 14;
            this.tbBeratTahunKemaren.Leave += new System.EventHandler(this.tbBeratTahunKemaren_Leave);
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // btTampilkan
            // 
            this.btTampilkan.AutoSize = true;
            this.btTampilkan.Location = new System.Drawing.Point(309, 310);
            this.btTampilkan.Name = "btTampilkan";
            this.btTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btTampilkan.TabIndex = 15;
            this.btTampilkan.Text = "Tampilkan";
            this.btTampilkan.UseVisualStyleBackColor = true;
            this.btTampilkan.Click += new System.EventHandler(this.btTampilkan_Click);
            // 
            // tbUsernameValorant
            // 
            this.tbUsernameValorant.Location = new System.Drawing.Point(343, 85);
            this.tbUsernameValorant.Name = "tbUsernameValorant";
            this.tbUsernameValorant.Size = new System.Drawing.Size(216, 20);
            this.tbUsernameValorant.TabIndex = 17;
            this.tbUsernameValorant.Leave += new System.EventHandler(this.tbUsernameValorant_Leave);
            // 
            // lbUsernameValorant
            // 
            this.lbUsernameValorant.AutoSize = true;
            this.lbUsernameValorant.Location = new System.Drawing.Point(133, 88);
            this.lbUsernameValorant.Name = "lbUsernameValorant";
            this.lbUsernameValorant.Size = new System.Drawing.Size(97, 13);
            this.lbUsernameValorant.TabIndex = 16;
            this.lbUsernameValorant.Text = "Username Valorant";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 370);
            this.Controls.Add(this.tbUsernameValorant);
            this.Controls.Add(this.lbUsernameValorant);
            this.Controls.Add(this.btTampilkan);
            this.Controls.Add(this.tbBeratTahunKemaren);
            this.Controls.Add(this.tbBeratSekarang);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbKotaAsal);
            this.Controls.Add(this.tbPendidikanTerakhir);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lbBeratTahunKemaren);
            this.Controls.Add(this.lbBeratSekarang);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbKotaAsal);
            this.Controls.Add(this.lbPendidikanTerakhir);
            this.Controls.Add(this.lbNama);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbPendidikanTerakhir;
        private System.Windows.Forms.Label lbKotaAsal;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbBeratSekarang;
        private System.Windows.Forms.Label lbBeratTahunKemaren;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbPendidikanTerakhir;
        private System.Windows.Forms.TextBox tbKotaAsal;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbBeratSekarang;
        private System.Windows.Forms.TextBox tbBeratTahunKemaren;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.Button btTampilkan;
        private System.Windows.Forms.TextBox tbUsernameValorant;
        private System.Windows.Forms.Label lbUsernameValorant;
    }
}


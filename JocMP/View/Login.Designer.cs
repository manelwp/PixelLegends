namespace View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textnom = new System.Windows.Forms.TextBox();
            this.textcontra = new System.Windows.Forms.TextBox();
            this.textconficontra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfi = new System.Windows.Forms.Label();
            this.btini = new System.Windows.Forms.Button();
            this.btregis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(152, 167);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(100, 20);
            this.textnom.TabIndex = 0;
            this.textnom.TextChanged += new System.EventHandler(this.textnom_TextChanged);
            // 
            // textcontra
            // 
            this.textcontra.Location = new System.Drawing.Point(152, 205);
            this.textcontra.Name = "textcontra";
            this.textcontra.PasswordChar = '*';
            this.textcontra.Size = new System.Drawing.Size(100, 20);
            this.textcontra.TabIndex = 1;
            // 
            // textconficontra
            // 
            this.textconficontra.Location = new System.Drawing.Point(152, 240);
            this.textconficontra.Name = "textconficontra";
            this.textconficontra.PasswordChar = '*';
            this.textconficontra.Size = new System.Drawing.Size(100, 20);
            this.textconficontra.TabIndex = 4;
            this.textconficontra.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "BENVINGUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contrasenya";
            // 
            // txtConfi
            // 
            this.txtConfi.AutoSize = true;
            this.txtConfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfi.ForeColor = System.Drawing.Color.Red;
            this.txtConfi.Location = new System.Drawing.Point(55, 238);
            this.txtConfi.Name = "txtConfi";
            this.txtConfi.Size = new System.Drawing.Size(81, 20);
            this.txtConfi.TabIndex = 10;
            this.txtConfi.Text = "Confirma";
            this.txtConfi.Visible = false;
            // 
            // btini
            // 
            this.btini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btini.Location = new System.Drawing.Point(39, 272);
            this.btini.Name = "btini";
            this.btini.Size = new System.Drawing.Size(97, 54);
            this.btini.TabIndex = 11;
            this.btini.Text = "INICIA SESSIÓ";
            this.btini.UseVisualStyleBackColor = true;
            // 
            // btregis
            // 
            this.btregis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregis.Location = new System.Drawing.Point(152, 283);
            this.btregis.Name = "btregis";
            this.btregis.Size = new System.Drawing.Size(128, 32);
            this.btregis.TabIndex = 12;
            this.btregis.Text = "REGISTRAR";
            this.btregis.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.LogoPixelPequeño;
            this.pictureBox1.Location = new System.Drawing.Point(108, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 80);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 349);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btregis);
            this.Controls.Add(this.btini);
            this.Controls.Add(this.txtConfi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textconficontra);
            this.Controls.Add(this.textcontra);
            this.Controls.Add(this.textnom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixel Legends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textnom;
        public System.Windows.Forms.TextBox textcontra;
        public System.Windows.Forms.TextBox textconficontra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btini;
        public System.Windows.Forms.Button btregis;
        public System.Windows.Forms.Label txtConfi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


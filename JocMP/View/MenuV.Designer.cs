namespace View
{
    partial class MenuV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuV));
            this.btcrearjug = new System.Windows.Forms.Button();
            this.btJugMenu = new System.Windows.Forms.Button();
            this.btMirJug = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btcrearjug
            // 
            this.btcrearjug.BackColor = System.Drawing.Color.Transparent;
            this.btcrearjug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcrearjug.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btcrearjug.Image = global::View.Properties.Resources.cj;
            this.btcrearjug.Location = new System.Drawing.Point(105, 284);
            this.btcrearjug.Name = "btcrearjug";
            this.btcrearjug.Size = new System.Drawing.Size(573, 101);
            this.btcrearjug.TabIndex = 1;
            this.btcrearjug.UseVisualStyleBackColor = false;
            // 
            // btJugMenu
            // 
            this.btJugMenu.BackColor = System.Drawing.Color.Transparent;
            this.btJugMenu.FlatAppearance.BorderSize = 0;
            this.btJugMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btJugMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btJugMenu.Image = global::View.Properties.Resources.jugar;
            this.btJugMenu.Location = new System.Drawing.Point(257, 31);
            this.btJugMenu.Name = "btJugMenu";
            this.btJugMenu.Size = new System.Drawing.Size(254, 99);
            this.btJugMenu.TabIndex = 2;
            this.btJugMenu.UseVisualStyleBackColor = false;
            // 
            // btMirJug
            // 
            this.btMirJug.BackColor = System.Drawing.Color.Transparent;
            this.btMirJug.FlatAppearance.BorderSize = 0;
            this.btMirJug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMirJug.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btMirJug.Image = global::View.Properties.Resources.Jugadors;
            this.btMirJug.Location = new System.Drawing.Point(203, 158);
            this.btMirJug.Name = "btMirJug";
            this.btMirJug.Size = new System.Drawing.Size(368, 109);
            this.btMirJug.TabIndex = 3;
            this.btMirJug.UseVisualStyleBackColor = false;
            this.btMirJug.Click += new System.EventHandler(this.BtMirJug_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::View.Properties.Resources.LogoPixelPequeño;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 79);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MenuV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(773, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btMirJug);
            this.Controls.Add(this.btJugMenu);
            this.Controls.Add(this.btcrearjug);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixel Legends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btcrearjug;
        public System.Windows.Forms.Button btJugMenu;
        public System.Windows.Forms.Button btMirJug;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
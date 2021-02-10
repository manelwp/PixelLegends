namespace View
{
    partial class MenuJoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuJoc));
            this.btsur = new System.Windows.Forms.Button();
            this.btraid = new System.Windows.Forms.Button();
            this.btenrere = new System.Windows.Forms.Button();
            this.comboTriajuga = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btsur
            // 
            this.btsur.BackColor = System.Drawing.Color.Transparent;
            this.btsur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsur.BackgroundImage")));
            this.btsur.Location = new System.Drawing.Point(250, 190);
            this.btsur.Name = "btsur";
            this.btsur.Size = new System.Drawing.Size(305, 31);
            this.btsur.TabIndex = 0;
            this.btsur.UseVisualStyleBackColor = false;
            // 
            // btraid
            // 
            this.btraid.BackColor = System.Drawing.Color.Transparent;
            this.btraid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btraid.BackgroundImage")));
            this.btraid.Location = new System.Drawing.Point(319, 298);
            this.btraid.Name = "btraid";
            this.btraid.Size = new System.Drawing.Size(154, 32);
            this.btraid.TabIndex = 1;
            this.btraid.UseVisualStyleBackColor = false;
            this.btraid.Click += new System.EventHandler(this.Btraid_Click);
            // 
            // btenrere
            // 
            this.btenrere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenrere.ForeColor = System.Drawing.Color.Red;
            this.btenrere.Location = new System.Drawing.Point(671, 391);
            this.btenrere.Name = "btenrere";
            this.btenrere.Size = new System.Drawing.Size(117, 47);
            this.btenrere.TabIndex = 5;
            this.btenrere.Text = "ENRERE";
            this.btenrere.UseVisualStyleBackColor = true;
            // 
            // comboTriajuga
            // 
            this.comboTriajuga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTriajuga.FormattingEnabled = true;
            this.comboTriajuga.Location = new System.Drawing.Point(224, 102);
            this.comboTriajuga.Name = "comboTriajuga";
            this.comboTriajuga.Size = new System.Drawing.Size(347, 21);
            this.comboTriajuga.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::View.Properties.Resources.LogoPixelPequeño;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 83);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MenuJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboTriajuga);
            this.Controls.Add(this.btenrere);
            this.Controls.Add(this.btraid);
            this.Controls.Add(this.btsur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuJoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixel Legends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btsur;
        public System.Windows.Forms.Button btraid;
        public System.Windows.Forms.Button btenrere;
        public System.Windows.Forms.ComboBox comboTriajuga;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
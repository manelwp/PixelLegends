namespace View
{
    partial class MirarJugadors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MirarJugadors));
            this.dtJug = new System.Windows.Forms.DataGridView();
            this.btcerca = new System.Windows.Forms.Button();
            this.txtcerca = new System.Windows.Forms.TextBox();
            this.rbidjug = new System.Windows.Forms.RadioButton();
            this.rbnom = new System.Windows.Forms.RadioButton();
            this.rbtots = new System.Windows.Forms.RadioButton();
            this.rbidusr = new System.Windows.Forms.RadioButton();
            this.btenrere = new System.Windows.Forms.Button();
            this.pctarma = new System.Windows.Forms.PictureBox();
            this.pctarmadura = new System.Windows.Forms.PictureBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtJug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctarma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctarmadura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtJug
            // 
            this.dtJug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtJug.Location = new System.Drawing.Point(12, 134);
            this.dtJug.MultiSelect = false;
            this.dtJug.Name = "dtJug";
            this.dtJug.ReadOnly = true;
            this.dtJug.RowHeadersWidth = 62;
            this.dtJug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtJug.Size = new System.Drawing.Size(776, 304);
            this.dtJug.TabIndex = 0;
            // 
            // btcerca
            // 
            this.btcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcerca.ForeColor = System.Drawing.Color.Red;
            this.btcerca.Location = new System.Drawing.Point(677, 39);
            this.btcerca.Name = "btcerca";
            this.btcerca.Size = new System.Drawing.Size(93, 39);
            this.btcerca.TabIndex = 1;
            this.btcerca.Text = "CERCA";
            this.btcerca.UseVisualStyleBackColor = true;
            // 
            // txtcerca
            // 
            this.txtcerca.Location = new System.Drawing.Point(353, 12);
            this.txtcerca.Name = "txtcerca";
            this.txtcerca.Size = new System.Drawing.Size(100, 20);
            this.txtcerca.TabIndex = 2;
            // 
            // rbidjug
            // 
            this.rbidjug.AutoSize = true;
            this.rbidjug.BackColor = System.Drawing.Color.Transparent;
            this.rbidjug.Image = ((System.Drawing.Image)(resources.GetObject("rbidjug.Image")));
            this.rbidjug.Location = new System.Drawing.Point(447, 92);
            this.rbidjug.Name = "rbidjug";
            this.rbidjug.Size = new System.Drawing.Size(194, 31);
            this.rbidjug.TabIndex = 3;
            this.rbidjug.TabStop = true;
            this.rbidjug.UseVisualStyleBackColor = false;
            this.rbidjug.CheckedChanged += new System.EventHandler(this.Rbidjug_CheckedChanged);
            // 
            // rbnom
            // 
            this.rbnom.AutoSize = true;
            this.rbnom.BackColor = System.Drawing.Color.Transparent;
            this.rbnom.Image = ((System.Drawing.Image)(resources.GetObject("rbnom.Image")));
            this.rbnom.Location = new System.Drawing.Point(429, 44);
            this.rbnom.Name = "rbnom";
            this.rbnom.Size = new System.Drawing.Size(228, 31);
            this.rbnom.TabIndex = 4;
            this.rbnom.TabStop = true;
            this.rbnom.UseVisualStyleBackColor = false;
            // 
            // rbtots
            // 
            this.rbtots.AutoSize = true;
            this.rbtots.BackColor = System.Drawing.Color.Transparent;
            this.rbtots.Image = ((System.Drawing.Image)(resources.GetObject("rbtots.Image")));
            this.rbtots.Location = new System.Drawing.Point(127, 44);
            this.rbtots.Name = "rbtots";
            this.rbtots.Size = new System.Drawing.Size(262, 31);
            this.rbtots.TabIndex = 5;
            this.rbtots.TabStop = true;
            this.rbtots.UseVisualStyleBackColor = false;
            // 
            // rbidusr
            // 
            this.rbidusr.AutoSize = true;
            this.rbidusr.BackColor = System.Drawing.Color.Transparent;
            this.rbidusr.Image = ((System.Drawing.Image)(resources.GetObject("rbidusr.Image")));
            this.rbidusr.Location = new System.Drawing.Point(161, 97);
            this.rbidusr.Name = "rbidusr";
            this.rbidusr.Size = new System.Drawing.Size(166, 26);
            this.rbidusr.TabIndex = 6;
            this.rbidusr.TabStop = true;
            this.rbidusr.UseVisualStyleBackColor = false;
            // 
            // btenrere
            // 
            this.btenrere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenrere.ForeColor = System.Drawing.Color.Red;
            this.btenrere.Location = new System.Drawing.Point(677, 92);
            this.btenrere.Name = "btenrere";
            this.btenrere.Size = new System.Drawing.Size(93, 31);
            this.btenrere.TabIndex = 7;
            this.btenrere.Text = "ENRERE";
            this.btenrere.UseVisualStyleBackColor = true;
            // 
            // pctarma
            // 
            this.pctarma.BackColor = System.Drawing.Color.Transparent;
            this.pctarma.Location = new System.Drawing.Point(816, 305);
            this.pctarma.Name = "pctarma";
            this.pctarma.Size = new System.Drawing.Size(100, 133);
            this.pctarma.TabIndex = 9;
            this.pctarma.TabStop = false;
            // 
            // pctarmadura
            // 
            this.pctarmadura.BackColor = System.Drawing.Color.Transparent;
            this.pctarmadura.Location = new System.Drawing.Point(816, 134);
            this.pctarmadura.Name = "pctarmadura";
            this.pctarmadura.Size = new System.Drawing.Size(100, 143);
            this.pctarmadura.TabIndex = 10;
            this.pctarmadura.TabStop = false;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.BackColor = System.Drawing.Color.Transparent;
            this.lblnom.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.Color.Red;
            this.lblnom.Location = new System.Drawing.Point(831, 45);
            this.lblnom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(60, 30);
            this.lblnom.TabIndex = 11;
            this.lblnom.Text = "Nom";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::View.Properties.Resources.LogoPixelPequeño;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 83);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MirarJugadors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.pctarmadura);
            this.Controls.Add(this.pctarma);
            this.Controls.Add(this.btenrere);
            this.Controls.Add(this.rbidusr);
            this.Controls.Add(this.rbtots);
            this.Controls.Add(this.rbnom);
            this.Controls.Add(this.rbidjug);
            this.Controls.Add(this.txtcerca);
            this.Controls.Add(this.btcerca);
            this.Controls.Add(this.dtJug);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MirarJugadors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixel Legends";
            ((System.ComponentModel.ISupportInitialize)(this.dtJug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctarma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctarmadura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtJug;
        public System.Windows.Forms.Button btcerca;
        public System.Windows.Forms.TextBox txtcerca;
        public System.Windows.Forms.RadioButton rbidjug;
        public System.Windows.Forms.RadioButton rbnom;
        public System.Windows.Forms.RadioButton rbtots;
        public System.Windows.Forms.RadioButton rbidusr;
        public System.Windows.Forms.Button btenrere;
        public System.Windows.Forms.PictureBox pctarma;
        public System.Windows.Forms.PictureBox pctarmadura;
        public System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
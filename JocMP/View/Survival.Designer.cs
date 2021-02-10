namespace View
{
    partial class Survival
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Survival));
            this.pbPersonaje = new System.Windows.Forms.PictureBox();
            this.pbMonster = new System.Windows.Forms.PictureBox();
            this.pbArma = new System.Windows.Forms.PictureBox();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btneAtack = new System.Windows.Forms.Button();
            this.txtnommons = new System.Windows.Forms.Label();
            this.txtvidamons = new System.Windows.Forms.Label();
            this.pctcormons = new System.Windows.Forms.PictureBox();
            this.pctcorjug = new System.Windows.Forms.PictureBox();
            this.txtvidajug = new System.Windows.Forms.Label();
            this.pctcofre = new System.Windows.Forms.PictureBox();
            this.pctnouitem = new System.Windows.Forms.PictureBox();
            this.btcanvi = new System.Windows.Forms.Button();
            this.pbfelis = new System.Windows.Forms.PictureBox();
            this.pbyouwin = new System.Windows.Forms.PictureBox();
            this.btmante = new System.Windows.Forms.Button();
            this.lblnormalnou = new System.Windows.Forms.Label();
            this.lblespecialnou = new System.Windows.Forms.Label();
            this.lblatac = new System.Windows.Forms.Label();
            this.lblatacespecial = new System.Windows.Forms.Label();
            this.lbldefensa = new System.Windows.Forms.Label();
            this.lbldefensaespecial = new System.Windows.Forms.Label();
            this.btsortir = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPotion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctcormons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctcorjug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctcofre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctnouitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfelis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbyouwin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPersonaje
            // 
            this.pbPersonaje.BackColor = System.Drawing.Color.Transparent;
            this.pbPersonaje.Image = global::View.Properties.Resources.armadura1;
            this.pbPersonaje.Location = new System.Drawing.Point(44, 397);
            this.pbPersonaje.Name = "pbPersonaje";
            this.pbPersonaje.Size = new System.Drawing.Size(89, 128);
            this.pbPersonaje.TabIndex = 1;
            this.pbPersonaje.TabStop = false;
            // 
            // pbMonster
            // 
            this.pbMonster.BackColor = System.Drawing.Color.Transparent;
            this.pbMonster.Location = new System.Drawing.Point(610, 35);
            this.pbMonster.Name = "pbMonster";
            this.pbMonster.Size = new System.Drawing.Size(332, 295);
            this.pbMonster.TabIndex = 2;
            this.pbMonster.TabStop = false;
            // 
            // pbArma
            // 
            this.pbArma.BackColor = System.Drawing.Color.Transparent;
            this.pbArma.Location = new System.Drawing.Point(228, 397);
            this.pbArma.Name = "pbArma";
            this.pbArma.Size = new System.Drawing.Size(124, 152);
            this.pbArma.TabIndex = 3;
            this.pbArma.TabStop = false;
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackColor = System.Drawing.Color.Black;
            this.btnAtacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtacar.ForeColor = System.Drawing.Color.Red;
            this.btnAtacar.Location = new System.Drawing.Point(711, 397);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(130, 50);
            this.btnAtacar.TabIndex = 4;
            this.btnAtacar.Text = "ATAC FISIC";
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.BtnAtacar_Click);
            // 
            // btneAtack
            // 
            this.btneAtack.BackColor = System.Drawing.Color.Black;
            this.btneAtack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneAtack.ForeColor = System.Drawing.Color.Red;
            this.btneAtack.Location = new System.Drawing.Point(711, 494);
            this.btneAtack.Name = "btneAtack";
            this.btneAtack.Size = new System.Drawing.Size(130, 48);
            this.btneAtack.TabIndex = 5;
            this.btneAtack.Text = "ATAC MÀGIC";
            this.btneAtack.UseVisualStyleBackColor = false;
            // 
            // txtnommons
            // 
            this.txtnommons.AutoSize = true;
            this.txtnommons.BackColor = System.Drawing.Color.Transparent;
            this.txtnommons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnommons.ForeColor = System.Drawing.Color.Red;
            this.txtnommons.Location = new System.Drawing.Point(379, 9);
            this.txtnommons.Name = "txtnommons";
            this.txtnommons.Size = new System.Drawing.Size(59, 25);
            this.txtnommons.TabIndex = 6;
            this.txtnommons.Text = "Nom";
            // 
            // txtvidamons
            // 
            this.txtvidamons.AutoSize = true;
            this.txtvidamons.BackColor = System.Drawing.Color.Transparent;
            this.txtvidamons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvidamons.ForeColor = System.Drawing.Color.Red;
            this.txtvidamons.Location = new System.Drawing.Point(381, 49);
            this.txtvidamons.Name = "txtvidamons";
            this.txtvidamons.Size = new System.Drawing.Size(59, 25);
            this.txtvidamons.TabIndex = 7;
            this.txtvidamons.Text = "Vida";
            // 
            // pctcormons
            // 
            this.pctcormons.BackColor = System.Drawing.Color.Transparent;
            this.pctcormons.Location = new System.Drawing.Point(265, 35);
            this.pctcormons.Name = "pctcormons";
            this.pctcormons.Size = new System.Drawing.Size(100, 50);
            this.pctcormons.TabIndex = 8;
            this.pctcormons.TabStop = false;
            // 
            // pctcorjug
            // 
            this.pctcorjug.BackColor = System.Drawing.Color.Transparent;
            this.pctcorjug.Location = new System.Drawing.Point(42, 332);
            this.pctcorjug.Name = "pctcorjug";
            this.pctcorjug.Size = new System.Drawing.Size(57, 50);
            this.pctcorjug.TabIndex = 9;
            this.pctcorjug.TabStop = false;
            // 
            // txtvidajug
            // 
            this.txtvidajug.AutoSize = true;
            this.txtvidajug.BackColor = System.Drawing.Color.Transparent;
            this.txtvidajug.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvidajug.ForeColor = System.Drawing.Color.Red;
            this.txtvidajug.Location = new System.Drawing.Point(105, 342);
            this.txtvidajug.Name = "txtvidajug";
            this.txtvidajug.Size = new System.Drawing.Size(59, 25);
            this.txtvidajug.TabIndex = 10;
            this.txtvidajug.Text = "Vida";
            // 
            // pctcofre
            // 
            this.pctcofre.BackColor = System.Drawing.Color.Transparent;
            this.pctcofre.Image = global::View.Properties.Resources.imagen_animada_cofre_14;
            this.pctcofre.Location = new System.Drawing.Point(314, 174);
            this.pctcofre.Name = "pctcofre";
            this.pctcofre.Size = new System.Drawing.Size(280, 217);
            this.pctcofre.TabIndex = 11;
            this.pctcofre.TabStop = false;
            this.pctcofre.Visible = false;
            // 
            // pctnouitem
            // 
            this.pctnouitem.BackColor = System.Drawing.Color.Transparent;
            this.pctnouitem.Location = new System.Drawing.Point(423, 397);
            this.pctnouitem.Name = "pctnouitem";
            this.pctnouitem.Size = new System.Drawing.Size(129, 152);
            this.pctnouitem.TabIndex = 12;
            this.pctnouitem.TabStop = false;
            // 
            // btcanvi
            // 
            this.btcanvi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btcanvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcanvi.ForeColor = System.Drawing.Color.Red;
            this.btcanvi.Location = new System.Drawing.Point(672, 397);
            this.btcanvi.Name = "btcanvi";
            this.btcanvi.Size = new System.Drawing.Size(180, 63);
            this.btcanvi.TabIndex = 13;
            this.btcanvi.Text = "CANVIAR";
            this.btcanvi.UseVisualStyleBackColor = false;
            this.btcanvi.Visible = false;
            // 
            // pbfelis
            // 
            this.pbfelis.BackColor = System.Drawing.Color.Transparent;
            this.pbfelis.Image = ((System.Drawing.Image)(resources.GetObject("pbfelis.Image")));
            this.pbfelis.Location = new System.Drawing.Point(622, 316);
            this.pbfelis.Name = "pbfelis";
            this.pbfelis.Size = new System.Drawing.Size(37, 51);
            this.pbfelis.TabIndex = 14;
            this.pbfelis.TabStop = false;
            this.pbfelis.Visible = false;
            // 
            // pbyouwin
            // 
            this.pbyouwin.BackColor = System.Drawing.Color.Transparent;
            this.pbyouwin.Image = ((System.Drawing.Image)(resources.GetObject("pbyouwin.Image")));
            this.pbyouwin.Location = new System.Drawing.Point(314, 314);
            this.pbyouwin.Name = "pbyouwin";
            this.pbyouwin.Size = new System.Drawing.Size(290, 53);
            this.pbyouwin.TabIndex = 15;
            this.pbyouwin.TabStop = false;
            this.pbyouwin.Visible = false;
            // 
            // btmante
            // 
            this.btmante.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmante.ForeColor = System.Drawing.Color.Red;
            this.btmante.Location = new System.Drawing.Point(672, 485);
            this.btmante.Name = "btmante";
            this.btmante.Size = new System.Drawing.Size(180, 65);
            this.btmante.TabIndex = 16;
            this.btmante.Text = "MANTENIR";
            this.btmante.UseVisualStyleBackColor = false;
            this.btmante.Visible = false;
            // 
            // lblnormalnou
            // 
            this.lblnormalnou.AutoSize = true;
            this.lblnormalnou.BackColor = System.Drawing.Color.Transparent;
            this.lblnormalnou.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnormalnou.ForeColor = System.Drawing.Color.Lime;
            this.lblnormalnou.Location = new System.Drawing.Point(556, 413);
            this.lblnormalnou.Name = "lblnormalnou";
            this.lblnormalnou.Size = new System.Drawing.Size(25, 25);
            this.lblnormalnou.TabIndex = 17;
            this.lblnormalnou.Text = "+";
            this.lblnormalnou.Visible = false;
            // 
            // lblespecialnou
            // 
            this.lblespecialnou.AutoSize = true;
            this.lblespecialnou.BackColor = System.Drawing.Color.Transparent;
            this.lblespecialnou.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblespecialnou.ForeColor = System.Drawing.Color.Red;
            this.lblespecialnou.Location = new System.Drawing.Point(557, 476);
            this.lblespecialnou.Name = "lblespecialnou";
            this.lblespecialnou.Size = new System.Drawing.Size(19, 25);
            this.lblespecialnou.TabIndex = 18;
            this.lblespecialnou.Text = "-";
            this.lblespecialnou.Visible = false;
            // 
            // lblatac
            // 
            this.lblatac.AutoSize = true;
            this.lblatac.BackColor = System.Drawing.Color.Transparent;
            this.lblatac.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblatac.ForeColor = System.Drawing.Color.Lime;
            this.lblatac.Location = new System.Drawing.Point(357, 413);
            this.lblatac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblatac.Name = "lblatac";
            this.lblatac.Size = new System.Drawing.Size(25, 25);
            this.lblatac.TabIndex = 19;
            this.lblatac.Text = "+";
            // 
            // lblatacespecial
            // 
            this.lblatacespecial.AutoSize = true;
            this.lblatacespecial.BackColor = System.Drawing.Color.Transparent;
            this.lblatacespecial.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblatacespecial.ForeColor = System.Drawing.Color.Red;
            this.lblatacespecial.Location = new System.Drawing.Point(357, 476);
            this.lblatacespecial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblatacespecial.Name = "lblatacespecial";
            this.lblatacespecial.Size = new System.Drawing.Size(19, 25);
            this.lblatacespecial.TabIndex = 20;
            this.lblatacespecial.Text = "-";
            // 
            // lbldefensa
            // 
            this.lbldefensa.AutoSize = true;
            this.lbldefensa.BackColor = System.Drawing.Color.Transparent;
            this.lbldefensa.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldefensa.ForeColor = System.Drawing.Color.Lime;
            this.lbldefensa.Location = new System.Drawing.Point(142, 413);
            this.lbldefensa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldefensa.Name = "lbldefensa";
            this.lbldefensa.Size = new System.Drawing.Size(25, 25);
            this.lbldefensa.TabIndex = 21;
            this.lbldefensa.Text = "+";
            // 
            // lbldefensaespecial
            // 
            this.lbldefensaespecial.AutoSize = true;
            this.lbldefensaespecial.BackColor = System.Drawing.Color.Transparent;
            this.lbldefensaespecial.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldefensaespecial.ForeColor = System.Drawing.Color.Red;
            this.lbldefensaespecial.Location = new System.Drawing.Point(146, 476);
            this.lbldefensaespecial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldefensaespecial.Name = "lbldefensaespecial";
            this.lbldefensaespecial.Size = new System.Drawing.Size(19, 25);
            this.lbldefensaespecial.TabIndex = 22;
            this.lbldefensaespecial.Text = "-";
            // 
            // btsortir
            // 
            this.btsortir.BackColor = System.Drawing.Color.Black;
            this.btsortir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsortir.ForeColor = System.Drawing.Color.Red;
            this.btsortir.Location = new System.Drawing.Point(42, 13);
            this.btsortir.Name = "btsortir";
            this.btsortir.Size = new System.Drawing.Size(204, 72);
            this.btsortir.TabIndex = 23;
            this.btsortir.Text = "SORTIR";
            this.btsortir.UseVisualStyleBackColor = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Red;
            this.btnNewGame.Location = new System.Drawing.Point(692, 437);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(132, 70);
            this.btnNewGame.TabIndex = 24;
            this.btnNewGame.Text = "Augmentar Dificultad";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Visible = false;
            // 
            // btnPotion
            // 
            this.btnPotion.BackColor = System.Drawing.Color.Transparent;
            this.btnPotion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPotion.BackgroundImage")));
            this.btnPotion.Location = new System.Drawing.Point(878, 474);
            this.btnPotion.Name = "btnPotion";
            this.btnPotion.Size = new System.Drawing.Size(75, 76);
            this.btnPotion.TabIndex = 25;
            this.btnPotion.UseVisualStyleBackColor = false;
            // 
            // Survival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources.fondo7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 603);
            this.Controls.Add(this.btnPotion);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btsortir);
            this.Controls.Add(this.lbldefensaespecial);
            this.Controls.Add(this.lbldefensa);
            this.Controls.Add(this.lblatacespecial);
            this.Controls.Add(this.lblatac);
            this.Controls.Add(this.lblespecialnou);
            this.Controls.Add(this.lblnormalnou);
            this.Controls.Add(this.btmante);
            this.Controls.Add(this.pbyouwin);
            this.Controls.Add(this.pbfelis);
            this.Controls.Add(this.btcanvi);
            this.Controls.Add(this.pctnouitem);
            this.Controls.Add(this.pctcofre);
            this.Controls.Add(this.txtvidajug);
            this.Controls.Add(this.pctcorjug);
            this.Controls.Add(this.pctcormons);
            this.Controls.Add(this.txtvidamons);
            this.Controls.Add(this.txtnommons);
            this.Controls.Add(this.btneAtack);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.pbArma);
            this.Controls.Add(this.pbMonster);
            this.Controls.Add(this.pbPersonaje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Survival";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixel Legends";
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctcormons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctcorjug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctcofre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctnouitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfelis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbyouwin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnAtacar;
        public System.Windows.Forms.Button btneAtack;
        public System.Windows.Forms.PictureBox pbPersonaje;
        public System.Windows.Forms.PictureBox pbMonster;
        public System.Windows.Forms.PictureBox pbArma;
        public System.Windows.Forms.Label txtnommons;
        public System.Windows.Forms.Label txtvidamons;
        public System.Windows.Forms.PictureBox pctcormons;
        public System.Windows.Forms.PictureBox pctcorjug;
        public System.Windows.Forms.Label txtvidajug;
        public System.Windows.Forms.PictureBox pctcofre;
        public System.Windows.Forms.PictureBox pctnouitem;
        public System.Windows.Forms.Button btcanvi;
        public System.Windows.Forms.PictureBox pbfelis;
        public System.Windows.Forms.PictureBox pbyouwin;
        public System.Windows.Forms.Button btmante;
        public System.Windows.Forms.Label lblnormalnou;
        public System.Windows.Forms.Label lblespecialnou;
        public System.Windows.Forms.Label lblatac;
        public System.Windows.Forms.Label lblatacespecial;
        public System.Windows.Forms.Label lbldefensa;
        public System.Windows.Forms.Label lbldefensaespecial;
        public System.Windows.Forms.Button btsortir;
        public System.Windows.Forms.Button btnNewGame;
        public System.Windows.Forms.Button btnPotion;
    }
}
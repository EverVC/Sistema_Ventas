namespace Sistema_de_Ventas
{
    partial class PMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMenu));
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.lblDescripMenu = new System.Windows.Forms.Label();
            this.btnCerrarMenu = new System.Windows.Forms.PictureBox();
            this.MinimizarMenu = new System.Windows.Forms.PictureBox();
            this.MaximizarMenu = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlMenuRight = new System.Windows.Forms.Panel();
            this.lblNameUserMenu = new System.Windows.Forms.Label();
            this.imgUserMasculino = new System.Windows.Forms.PictureBox();
            this.imgUserFemenino = new System.Windows.Forms.PictureBox();
            this.dragControlMenu1 = new Sistema_de_Ventas.DragControl();
            this.dragControlMenu2 = new Sistema_de_Ventas.DragControl();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarMenu)).BeginInit();
            this.pnlMenuRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserMasculino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserFemenino)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.White;
            this.pnlTopMenu.Controls.Add(this.lblDescripMenu);
            this.pnlTopMenu.Controls.Add(this.btnCerrarMenu);
            this.pnlTopMenu.Controls.Add(this.MinimizarMenu);
            this.pnlTopMenu.Controls.Add(this.MaximizarMenu);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(800, 35);
            this.pnlTopMenu.TabIndex = 2;
            // 
            // lblDescripMenu
            // 
            this.lblDescripMenu.AutoSize = true;
            this.lblDescripMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripMenu.Location = new System.Drawing.Point(13, 13);
            this.lblDescripMenu.Name = "lblDescripMenu";
            this.lblDescripMenu.Size = new System.Drawing.Size(185, 13);
            this.lblDescripMenu.TabIndex = 3;
            this.lblDescripMenu.Text = "SISTEMA DE VENTAS / MENU";
            // 
            // btnCerrarMenu
            // 
            this.btnCerrarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarMenu.Image = global::Sistema_de_Ventas.Properties.Resources.Cerrar2;
            this.btnCerrarMenu.Location = new System.Drawing.Point(768, 10);
            this.btnCerrarMenu.Name = "btnCerrarMenu";
            this.btnCerrarMenu.Size = new System.Drawing.Size(14, 14);
            this.btnCerrarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarMenu.TabIndex = 2;
            this.btnCerrarMenu.TabStop = false;
            this.btnCerrarMenu.Click += new System.EventHandler(this.btnCerrarMenu_Click);
            // 
            // MinimizarMenu
            // 
            this.MinimizarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarMenu.Image = global::Sistema_de_Ventas.Properties.Resources.MinimizaR;
            this.MinimizarMenu.Location = new System.Drawing.Point(670, 4);
            this.MinimizarMenu.Name = "MinimizarMenu";
            this.MinimizarMenu.Size = new System.Drawing.Size(25, 25);
            this.MinimizarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizarMenu.TabIndex = 1;
            this.MinimizarMenu.TabStop = false;
            this.MinimizarMenu.Click += new System.EventHandler(this.MinimizarMenu_Click);
            // 
            // MaximizarMenu
            // 
            this.MaximizarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizarMenu.Image = global::Sistema_de_Ventas.Properties.Resources.Maximizar;
            this.MaximizarMenu.Location = new System.Drawing.Point(722, 10);
            this.MaximizarMenu.Name = "MaximizarMenu";
            this.MaximizarMenu.Size = new System.Drawing.Size(15, 15);
            this.MaximizarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaximizarMenu.TabIndex = 1;
            this.MaximizarMenu.TabStop = false;
            this.MaximizarMenu.Click += new System.EventHandler(this.MaximizarMenu_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(256, 171);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 3;
            // 
            // pnlMenuRight
            // 
            this.pnlMenuRight.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlMenuRight.Controls.Add(this.lblNameUserMenu);
            this.pnlMenuRight.Controls.Add(this.imgUserMasculino);
            this.pnlMenuRight.Controls.Add(this.imgUserFemenino);
            this.pnlMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenuRight.Location = new System.Drawing.Point(722, 35);
            this.pnlMenuRight.Name = "pnlMenuRight";
            this.pnlMenuRight.Size = new System.Drawing.Size(78, 415);
            this.pnlMenuRight.TabIndex = 4;
            // 
            // lblNameUserMenu
            // 
            this.lblNameUserMenu.AutoSize = true;
            this.lblNameUserMenu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUserMenu.ForeColor = System.Drawing.Color.White;
            this.lblNameUserMenu.Location = new System.Drawing.Point(20, 91);
            this.lblNameUserMenu.Name = "lblNameUserMenu";
            this.lblNameUserMenu.Size = new System.Drawing.Size(0, 13);
            this.lblNameUserMenu.TabIndex = 6;
            // 
            // imgUserMasculino
            // 
            this.imgUserMasculino.Image = ((System.Drawing.Image)(resources.GetObject("imgUserMasculino.Image")));
            this.imgUserMasculino.Location = new System.Drawing.Point(7, 20);
            this.imgUserMasculino.Name = "imgUserMasculino";
            this.imgUserMasculino.Size = new System.Drawing.Size(62, 60);
            this.imgUserMasculino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUserMasculino.TabIndex = 5;
            this.imgUserMasculino.TabStop = false;
            // 
            // imgUserFemenino
            // 
            this.imgUserFemenino.Image = ((System.Drawing.Image)(resources.GetObject("imgUserFemenino.Image")));
            this.imgUserFemenino.Location = new System.Drawing.Point(3, 16);
            this.imgUserFemenino.Name = "imgUserFemenino";
            this.imgUserFemenino.Size = new System.Drawing.Size(72, 68);
            this.imgUserFemenino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUserFemenino.TabIndex = 5;
            this.imgUserFemenino.TabStop = false;
            // 
            // dragControlMenu1
            // 
            this.dragControlMenu1.SelectControl = this.pnlTopMenu;
            // 
            // dragControlMenu2
            // 
            this.dragControlMenu2.SelectControl = this.lblDescripMenu;
            // 
            // PMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMenuRight);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pnlTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMenu";
            this.Load += new System.EventHandler(this.PMenu_Load);
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarMenu)).EndInit();
            this.pnlMenuRight.ResumeLayout(false);
            this.pnlMenuRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserMasculino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserFemenino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Label lblDescripMenu;
        private System.Windows.Forms.PictureBox btnCerrarMenu;
        private System.Windows.Forms.PictureBox MinimizarMenu;
        private System.Windows.Forms.PictureBox MaximizarMenu;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel pnlMenuRight;
        private System.Windows.Forms.PictureBox imgUserMasculino;
        private System.Windows.Forms.PictureBox imgUserFemenino;
        public System.Windows.Forms.Label lblNameUserMenu;
        private DragControl dragControlMenu1;
        private DragControl dragControlMenu2;
    }
}
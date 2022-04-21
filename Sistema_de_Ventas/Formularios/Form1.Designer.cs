namespace Sistema_de_Ventas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop1 = new System.Windows.Forms.Panel();
            this.lblDescrip1Home = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Fond1 = new System.Windows.Forms.Panel();
            this.btnNoVerPass = new System.Windows.Forms.PictureBox();
            this.btnVerPass = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxNameUser = new System.Windows.Forms.TextBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnNoPass = new System.Windows.Forms.PictureBox();
            this.dragControl3 = new Sistema_de_Ventas.DragControl();
            this.dragControl4 = new Sistema_de_Ventas.DragControl();
            this.pnlTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            this.Fond1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoVerPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoPass)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop1
            // 
            this.pnlTop1.BackColor = System.Drawing.Color.White;
            this.pnlTop1.Controls.Add(this.lblDescrip1Home);
            this.pnlTop1.Controls.Add(this.btnCerrar);
            this.pnlTop1.Controls.Add(this.Minimizar);
            this.pnlTop1.Controls.Add(this.Maximizar);
            this.pnlTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop1.Location = new System.Drawing.Point(0, 0);
            this.pnlTop1.Name = "pnlTop1";
            this.pnlTop1.Size = new System.Drawing.Size(800, 35);
            this.pnlTop1.TabIndex = 0;
            // 
            // lblDescrip1Home
            // 
            this.lblDescrip1Home.AutoSize = true;
            this.lblDescrip1Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip1Home.Location = new System.Drawing.Point(13, 13);
            this.lblDescrip1Home.Name = "lblDescrip1Home";
            this.lblDescrip1Home.Size = new System.Drawing.Size(135, 13);
            this.lblDescrip1Home.TabIndex = 3;
            this.lblDescrip1Home.Text = "SISTEMA DE VENTAS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Sistema_de_Ventas.Properties.Resources.Cerrar2;
            this.btnCerrar.Location = new System.Drawing.Point(768, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(14, 14);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = global::Sistema_de_Ventas.Properties.Resources.MinimizaR;
            this.Minimizar.Location = new System.Drawing.Point(670, 4);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 1;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Image = global::Sistema_de_Ventas.Properties.Resources.Maximizar;
            this.Maximizar.Location = new System.Drawing.Point(722, 10);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(15, 15);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 1;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Fond1
            // 
            this.Fond1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fond1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Fond1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fond1.Controls.Add(this.btnNoVerPass);
            this.Fond1.Controls.Add(this.btnVerPass);
            this.Fond1.Controls.Add(this.lblInfo);
            this.Fond1.Controls.Add(this.btnRegistrarse);
            this.Fond1.Controls.Add(this.btnIngresar);
            this.Fond1.Controls.Add(this.label2);
            this.Fond1.Controls.Add(this.label1);
            this.Fond1.Controls.Add(this.txtBoxPass);
            this.Fond1.Controls.Add(this.txtBoxNameUser);
            this.Fond1.Location = new System.Drawing.Point(268, 184);
            this.Fond1.Name = "Fond1";
            this.Fond1.Size = new System.Drawing.Size(269, 254);
            this.Fond1.TabIndex = 2;
            // 
            // btnNoVerPass
            // 
            this.btnNoVerPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoVerPass.Image = global::Sistema_de_Ventas.Properties.Resources.PassNo;
            this.btnNoVerPass.Location = new System.Drawing.Point(231, 81);
            this.btnNoVerPass.Name = "btnNoVerPass";
            this.btnNoVerPass.Size = new System.Drawing.Size(20, 17);
            this.btnNoVerPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNoVerPass.TabIndex = 3;
            this.btnNoVerPass.TabStop = false;
            this.btnNoVerPass.Click += new System.EventHandler(this.btnNoVerPass_Click);
            // 
            // btnVerPass
            // 
            this.btnVerPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPass.Image = global::Sistema_de_Ventas.Properties.Resources.PassSi;
            this.btnVerPass.Location = new System.Drawing.Point(235, 81);
            this.btnVerPass.Name = "btnVerPass";
            this.btnVerPass.Size = new System.Drawing.Size(13, 18);
            this.btnVerPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVerPass.TabIndex = 3;
            this.btnVerPass.TabStop = false;
            this.btnVerPass.Click += new System.EventHandler(this.btnVerPass_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(61, 175);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(150, 13);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "¿AUN NO TIENES CUENTA?";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRegistrarse.Location = new System.Drawing.Point(95, 201);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarse.TabIndex = 8;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnIngresar.Location = new System.Drawing.Point(95, 129);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario:";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(110, 80);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(141, 20);
            this.txtBoxPass.TabIndex = 1;
            // 
            // txtBoxNameUser
            // 
            this.txtBoxNameUser.Location = new System.Drawing.Point(110, 42);
            this.txtBoxNameUser.Name = "txtBoxNameUser";
            this.txtBoxNameUser.Size = new System.Drawing.Size(141, 20);
            this.txtBoxNameUser.TabIndex = 0;
            // 
            // imgUser
            // 
            this.imgUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgUser.Image = global::Sistema_de_Ventas.Properties.Resources.avatarUser;
            this.imgUser.Location = new System.Drawing.Point(364, 95);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(88, 83);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 1;
            this.imgUser.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(231, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnNoVerPass_Click);
            // 
            // btnNoPass
            // 
            this.btnNoPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoPass.Location = new System.Drawing.Point(231, 81);
            this.btnNoPass.Name = "btnNoPass";
            this.btnNoPass.Size = new System.Drawing.Size(20, 18);
            this.btnNoPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNoPass.TabIndex = 3;
            this.btnNoPass.TabStop = false;
            this.btnNoPass.Click += new System.EventHandler(this.btnNoVerPass_Click);
            // 
            // dragControl3
            // 
            this.dragControl3.SelectControl = this.pnlTop1;
            // 
            // dragControl4
            // 
            this.dragControl4.SelectControl = this.lblDescrip1Home;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.Fond1);
            this.Controls.Add(this.pnlTop1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlTop1.ResumeLayout(false);
            this.pnlTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            this.Fond1.ResumeLayout(false);
            this.Fond1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoVerPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblDescrip1Home;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.Panel Fond1;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxNameUser;
        private System.Windows.Forms.PictureBox btnVerPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnNoVerPass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnNoPass;
        private DragControl dragControl3;
        private DragControl dragControl4;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblInfo;
    }
}


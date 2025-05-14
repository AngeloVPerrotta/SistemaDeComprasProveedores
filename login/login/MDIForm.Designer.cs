namespace login
{
    partial class MDIForm
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuperUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipal,
            this.menuLogin,
            this.menuLogout});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 28);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuReportes";
            this.menuStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip3_ItemClicked);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdmin,
            this.menuSuperUsuario,
            this.menuUsuario,
            this.menuVisitante,
            this.menuReportes,
            this.menuUsuarios,
            this.menuConfig,
            this.menuDatos});
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(121, 24);
            this.menuPrincipal.Text = "Menú Principal";
            this.menuPrincipal.Visible = false;
            // 
            // menuAdmin
            // 
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(224, 26);
            this.menuAdmin.Text = "Administrador";
            this.menuAdmin.Click += new System.EventHandler(this.menuAdmin_Click);
            // 
            // menuSuperUsuario
            // 
            this.menuSuperUsuario.Name = "menuSuperUsuario";
            this.menuSuperUsuario.Size = new System.Drawing.Size(224, 26);
            this.menuSuperUsuario.Text = "SuperUsuario";
            this.menuSuperUsuario.Click += new System.EventHandler(this.menuSuperUsuario_Click);
            // 
            // menuUsuario
            // 
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(224, 26);
            this.menuUsuario.Text = "Usuario";
            this.menuUsuario.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuVisitante
            // 
            this.menuVisitante.Name = "menuVisitante";
            this.menuVisitante.Size = new System.Drawing.Size(224, 26);
            this.menuVisitante.Text = "Visitante";
            this.menuVisitante.Click += new System.EventHandler(this.menuVisitante_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(224, 26);
            this.menuReportes.Text = "Reportes";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(224, 26);
            this.menuUsuarios.Text = "Usuarios";
            // 
            // menuConfig
            // 
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(224, 26);
            this.menuConfig.Text = "Configuracion";
            // 
            // menuDatos
            // 
            this.menuDatos.Name = "menuDatos";
            this.menuDatos.Size = new System.Drawing.Size(224, 26);
            this.menuDatos.Text = "Visualizar datos";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(60, 24);
            this.menuLogin.Text = "Login";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(70, 24);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Visible = false;
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.Name = "MDIForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem menuSuperUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuVisitante;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuDatos;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
    }
}


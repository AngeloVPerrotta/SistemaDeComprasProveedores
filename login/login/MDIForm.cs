using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void AbrirFormularioInicialPorFamilia()
        {
            var familia = autenticador.UsuarioActual.Familia;
            Form formulario = null;

            switch (familia)
            {
                case "Administrador":
                    formulario = new FormAdmin();
                    break;
                case "SuperUsuario":
                    formulario = new FormSuperUsuario();
                    break;
                case "Usuario":
                    formulario = new FormUsuario();
                    break;
                case "Visitante":
                    formulario = new FormVisitante();
                    break;
            }

            if (formulario != null)
            {
                formulario.MdiParent = this;
                formulario.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void HabilitarMenuPorUsuario()
        {
            var usuario = autenticador.UsuarioActual;

            // Desactivar todo
            menuAdmin.Visible = false;
            menuSuperUsuario.Visible = false;
            menuUsuario.Visible = false;
            menuVisitante.Visible = false;
            menuReportes.Visible = false;
            menuUsuarios.Visible = false;
            menuConfig.Visible = false;
            menuDatos.Visible = false;

            // Activar por familia
            switch (usuario.Familia)
            {
                case "Administrador":
                    menuAdmin.Visible = true;
                    break;
                case "SuperUsuario":
                    menuSuperUsuario.Visible = true;
                    break;
                case "Usuario":
                    menuUsuario.Visible = true;
                    break;
                case "Visitante":
                    menuVisitante.Visible = true;
                    break;
            }

            // Activar por patentes
            var patentes = repositoriopatentes.CargarPatentes();
            foreach (var patente in patentes)
            {
                if (usuario.PatentesIds.Contains(patente.Id))
                {
                    switch (patente.Nombre)
                    {
                        case "Reportes":
                            menuReportes.Visible = true;
                            break;
                        case "Usuarios":
                            menuUsuarios.Visible = true;
                            break;
                        case "VisualizarDatos":
                            menuDatos.Visible = true;
                            break;
                        case "Configuraciones":
                            menuConfig.Visible = true;
                            break;
                    }
                }
            }
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            // Mostrar solo Login
            menuLogin.Visible = true;
            menuLogout.Visible = false;

            // Ocultar todos los ítems del menú principal
            menuAdmin.Visible = false;
            menuSuperUsuario.Visible = false;
            menuUsuario.Visible = false;
            menuVisitante.Visible = false;
            menuReportes.Visible = false;
            menuUsuarios.Visible = false;
            menuConfig.Visible = false;
            menuDatos.Visible = false;
            menuPrincipal.Visible = false; // Este es clave
        }

        private void menuAdmin_Click(object sender, EventArgs e)
        {
            var formAdmin = new FormAdmin(); // Asegurate de tener un formulario llamado así
            formAdmin.MdiParent = this; // Lo hace hijo del MDI
            formAdmin.Show();
        }

        private void menuSuperUsuario_Click(object sender, EventArgs e)
        {
            var FormSuperUsuario = new FormSuperUsuario(); // Asegurate de tener un formulario llamado así
            FormSuperUsuario.MdiParent = this; // Lo hace hijo del MDI
            FormSuperUsuario.Show();
        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            var FormUsuario = new FormUsuario(); // Asegurate de tener un formulario llamado así
            FormUsuario.MdiParent = this; // Lo hace hijo del MDI
            FormUsuario.Show();
        }

        private void menuVisitante_Click(object sender, EventArgs e)
        {
            var FormVisitante = new FormVisitante(); // Asegurate de tener un formulario llamado así
            FormVisitante.MdiParent = this; // Lo hace hijo del MDI
            FormVisitante.Show();
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new FormLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                menuLogin.Visible = false;
                menuLogout.Visible = true;

                HabilitarMenuPorUsuario();
                AbrirFormularioInicialPorFamilia();
                menuPrincipal.Visible = true; // habilita el acceso al menú general
            }
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            autenticador.Logout();

            // Cerrar todos los formularios hijos abiertos
            foreach (Form formHijo in this.MdiChildren)
            {
                formHijo.Close();
            }

            // Ocultar menús
            menuLogin.Visible = true;
            menuLogout.Visible = false;
            menuAdmin.Visible = false;
            menuSuperUsuario.Visible = false;
            menuUsuario.Visible = false;
            menuVisitante.Visible = false;
            menuReportes.Visible = false;
            menuUsuarios.Visible = false;
            menuConfig.Visible = false;
            menuDatos.Visible = false;
            menuPrincipal.Visible = false;

            MessageBox.Show("Sesión cerrada.");
        }
    }
}

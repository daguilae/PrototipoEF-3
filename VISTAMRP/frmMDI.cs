using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaReporteador;
using CapaVistaReporteador.Mantenimientos;
using CapaVistaReporteador.ReportesModulos;
using CapaVistaSeguridad;
using CapaVistaSeguridad.Formularios;
using CapaVistaSeguridad.Formularios.Mantenimientos;
using VISTAMRP.Reportes;

namespace VISTAMRP
{
    public partial class frmMDI : Form
    {
        private int childFormNumber = 0;
        //instancias de seguridad.
        clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();//instancia para los permisos por aplicacion
        clsVistaBitacora bit = new clsVistaBitacora();//instancia para la bitacora.

        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            //Este codigo es para el login.
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tiposDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void estadosDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo los usuarios pueden acceder a esta ventana para cambiar su contraseña.
            frmCambioContraseña cambioContraseña = new frmCambioContraseña(txtUsuario.Text);
            cambioContraseña.MdiParent = this;
            cambioContraseña.Show();
            bit.user(txtUsuario.Text);
            bit.insert("Ingreso A Cambio de Contraseña", 11);
        }
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso A Mantenimiento Usuario", 2);
                frmMantenimientoUsuario mantenimientoUsuario = new frmMantenimientoUsuario(txtUsuario.Text);
                mantenimientoUsuario.MdiParent = this;
                mantenimientoUsuario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a Mantenimiento Usuario", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso A Mantenimiento Aplicaciones", 3);
                frmAplicativo aplicativo = new frmAplicativo();
                aplicativo.MdiParent = this;
                aplicativo.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar A Mantenimiento Aplicaciones", 3);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignaciónDePerfílYAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("6", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a Asignacion de Perfil y Aplicaciones", 6);
                frmAsignacionDeAplicaciones perfil = new frmAsignacionDeAplicaciones();
                perfil.MdiParent = this;
                perfil.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar a Asignacion de perfil y aplicaciones", 6);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void móduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("8", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("ingreso a Mantenimiento Modulo", 8);
                frmModulo modulo = new frmModulo(txtUsuario.Text);
                modulo.MdiParent = this;
                modulo.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar A Mantenimiento Modulo", 8);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoPerfílToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("4", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a Mantenimiento Perfil", 4);
                frmMantenimientoPerfil perfil = new frmMantenimientoPerfil(txtUsuario.Text);
                perfil.MdiParent = this;
                perfil.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar A Mantenimiento Modulo", 4);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignaciónDeAplicaciónAPerfílToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("5", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a Asignacion de Aplicaciones a Perfil", 5);
                frmAsignarAplicacionesAPerfil perfil = new frmAsignarAplicacionesAPerfil();
                perfil.MdiParent = this;
                perfil.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar A Asignacion de Aplicaciones a perfil", 5);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoLineaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a Mantenimiento De Receta", 3306);
                frmRecetaEncabezado perfil = new frmRecetaEncabezado(txtUsuario.Text);
                perfil.MdiParent = this;
                perfil.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar a Mantenimiento De Receta", 3306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void detalleRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3307", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a Detalle De Receta", 3307);
                frmRecetas perfil = new frmRecetas(txtUsuario.Text);
                perfil.MdiParent = this;
                perfil.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar a Detalle De Receta", 3307);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void recepcionDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3308", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso Recepcion Pedido", 3308);
                frmRecepcionPedidos perfil = new frmRecepcionPedidos(txtUsuario.Text);
                perfil.MdiParent = this;
                perfil.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar a Recepcion Pedido", 3308);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void pedidoDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void generarOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void procesoControlDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gestorDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            frmGestorReportes frmFormulario;
            bit.user(txtUsuario.Text);
            bit.insert("Ingreso a Gestor de Reportes", 101);

            frmFormulario = new frmGestorReportes();
            frmFormulario.MdiParent = this;
            frmFormulario.Show();
        }

        private void asignarReporteAMóduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            frmReporteMod frmFormulario;
            bit.user(txtUsuario.Text);
            bit.insert("Ingreso a Asignación de Reportes a Módulos", 104);

            frmFormulario = new frmReporteMod();
            frmFormulario.MdiParent = this;
            frmFormulario.Show();
        }

        private void asignarReporteAAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteApp frmFormulario;
            clsVistaBitacora bit = new clsVistaBitacora();
            bit.user(txtUsuario.Text);
            bit.insert("Ingreso a Asignación de Reportes a Aplicación ", 105);

            frmFormulario = new frmReporteApp();
            frmFormulario.MdiParent = this;
            frmFormulario.Show();
        }

        private void verReportesDeMóduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportesModulos frmFormulario;
            clsVistaBitacora bit = new clsVistaBitacora();
            bit.user(txtUsuario.Text);
            bit.insert("Ingreso a Asignación de Reportes a Aplicación ", 102);

            frmFormulario = new frmReportesModulos(7);
            frmFormulario.MdiParent = this;
            frmFormulario.Show();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {

        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aca para abrir

            if (seguridad.PermisosAcceso("3308", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso Recepcion Pedido", 3308);
                frmBitacora bitac = new frmBitacora();
                bitac.MdiParent = this;
                bitac.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar a Recepcion Pedido", 3308);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoRecetaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3308", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a reporte receta", 3308);
                frmRepoMantenimiento bitac = new frmRepoMantenimiento();
                bitac.MdiParent = this;
                bitac.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar a Recepcion Pedido", 3308);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void procesoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3308", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a Reporte proceso", 3308);
                frmRepoProceso bitac = new frmRepoProceso();
                bitac.MdiParent = this;
                bitac.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de Ingresar a Recepcion Pedido", 3308);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
    }
}

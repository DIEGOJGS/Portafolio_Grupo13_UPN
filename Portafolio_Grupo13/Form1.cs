using System.Diagnostics; // Para poder usar "Process"
using System.IO;
namespace Portafolio_Grupo13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            string ruta = @"T1\GestorTareasTechSolutions.exe";

            if (File.Exists(ruta))
            {
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("PENDIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTarea1_Click(object sender, EventArgs e)
        {
            string ruta = @"Tarea1\CasoWow.AppVisual.exe";

            if (File.Exists(ruta))
            {
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("PENDIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnT2_Click(object sender, EventArgs e)
        {
            // Este fallará y dirá "PENDIENTE" hasta que pongas el .exe en la carpeta T2
            string ruta = @"T2\ProyectoT2.exe";

            if (File.Exists(ruta))
            {
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("PENDIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEF_Click(object sender, EventArgs e)
        {
            // Este fallará y dirá "PENDIENTE" hasta que pongas el .exe en la carpeta EF
            string ruta = @"EF\ExamenFinal.exe";

            if (File.Exists(ruta))
            {
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("PENDIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTarea2_Click(object sender, EventArgs e)
        {
            string ruta = @"Tarea2\CajeroATM.exe";

            if (File.Exists(ruta))
            {
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("PENDIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            // ¡¡CAMBIA ESTA URL POR LA DE TU REPOSITORIO!!
            string url = "https://github.com/DIEGOJGS/Portafolio_Grupo13_UPN";

            try
            {
                // Esta línea abre el navegador por defecto
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el enlace. Error: {ex.Message}", "Error al Abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        DataTable CONTACTOS = new DataTable();

        private void InicializarTabla()
        {
            CONTACTOS.Columns.Add("Nombres", typeof(System.String));
            CONTACTOS.Columns.Add("Apellidos", typeof(System.String));
            CONTACTOS.Columns.Add("Correo", typeof(System.String));
            CONTACTOS.Columns.Add("Telefono", typeof(System.String));
            CONTACTOS.Columns.Add("Nacimiento", typeof(System.String));

        }

        public Form1()
        {
            InitializeComponent();
            InicializarTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionContactos frm = new EdicionContactos();
            frm.ShowDialog();
            if(frm.Valido)
            {
                DataRow NuevaFila = CONTACTOS.NewRow();
                NuevaFila["Nombres"] = frm.txbNombres.Text;
                NuevaFila["Apellidos"] = frm.txbApellidos.Text;
                NuevaFila["Correo"] = frm.txbCorreo.Text;
                NuevaFila["Telefono"] = frm.txbTelefono.Text;
                NuevaFila["Nacimiento"] = frm.dtpNacimiento.Text;
                CONTACTOS.Rows.Add(NuevaFila);
                crearArchivo(NuevaFila["Nombres"].ToString(), NuevaFila["Apellidos"].ToString(), NuevaFila["Nacimiento"].ToString(), NuevaFila["Correo"].ToString(), NuevaFila["Telefono"].ToString());
                MessageBox.Show("Registro agregado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgContactos.AutoGenerateColumns = false;
            dtgContactos.DataSource = CONTACTOS;
            leer();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea modificar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EdicionContactos frm = new EdicionContactos();
                    frm.txbNombres.Text = dtgContactos.CurrentRow.Cells["cNombres"].Value.ToString();
                    frm.txbApellidos.Text = dtgContactos.CurrentRow.Cells["cApellidos"].Value.ToString();
                    frm.txbCorreo.Text = dtgContactos.CurrentRow.Cells["cCorreo"].Value.ToString();
                    frm.txbTelefono.Text = dtgContactos.CurrentRow.Cells["cTelefono"].Value.ToString();
                    frm.dtpNacimiento.Text = dtgContactos.CurrentRow.Cells["cFechaNacimiento"].Value.ToString();
                    frm.Actualizando = true;
                    frm.ShowDialog();

                    if (frm.Valido && frm.Actualizando)
                    {
                        dtgContactos.CurrentRow.Cells["cNombres"].Value = frm.txbNombres.Text;
                        dtgContactos.CurrentRow.Cells["cApellidos"].Value = frm.txbApellidos.Text;
                        dtgContactos.CurrentRow.Cells["cCorreo"].Value = frm.txbCorreo.Text;
                        dtgContactos.CurrentRow.Cells["cTelefono"].Value = frm.txbTelefono.Text;
                        dtgContactos.CurrentRow.Cells["cFechaNacimiento"].Value = frm.dtpNacimiento.Text;
                    }
                }
                catch
                {
                    MessageBox.Show("Seleccione un registro válido","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dtgContactos.Rows.RemoveAt(dtgContactos.CurrentRow.Index);
                }
                catch
                {
                    MessageBox.Show("Seleccione un registro válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            
            String Ruta = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+ @"\agenda.txt";
            StreamWriter ArchivoTxt = new StreamWriter(Ruta);
            foreach (DataGridViewRow Fila in dtgContactos.Rows)
            {
                ArchivoTxt.WriteLine(Fila.Cells["cNombres"].Value.ToString() + " " + Fila.Cells["cApellidos"].Value.ToString() + " " + Fila.Cells["cTelefono"].Value.ToString());
            }
            
            ArchivoTxt.Close();
        }

        private void crearArchivo(String nombre,String apellido,String nacimiento,String Correo,String Telefono)
        {
            String Ruta = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\agenda.txt";
            StreamWriter ArchivoTxt = new StreamWriter(Ruta,true);
            ArchivoTxt.WriteLine(nombre+";"+apellido+";"+nacimiento+";"+Correo+";"+Telefono);
            
            ArchivoTxt.Close();
        }
        private void leer()
        {
            String Ruta = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\agenda.txt";
            
            String[] campos;
            String linea;
            if (File.Exists(Ruta))
            {
                StreamReader ArchivoText = new StreamReader(Ruta);
                while ((linea = ArchivoText.ReadLine()) != null)
                {
                    campos = linea.Split(';');
                    DataRow NuevaFila = CONTACTOS.NewRow();
                    NuevaFila["Nombres"] = campos[0];
                    NuevaFila["Apellidos"] = campos[1];
                    NuevaFila["Correo"] = campos[3];
                    NuevaFila["Telefono"] = campos[4];
                    NuevaFila["Nacimiento"] = campos[2];
                    CONTACTOS.Rows.Add(NuevaFila);
                }
            }
        }
    }
}

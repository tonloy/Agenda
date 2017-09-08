using System;
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
    public partial class EdicionContactos : Form
    {
        //ATRIBUTO
        Boolean _Valido = false;
        Boolean _Actualizando = false;

        public Boolean Actualizando
        {
            get { return _Actualizando; }
            set { _Actualizando = value; }
        }
        //PROPIEDAD
        public Boolean Valido
        {
            get { return _Valido; }
        }

        private Boolean ValidarDatos()
        {
            Boolean Validado = true;
            Notificador.Clear();
            if(txbNombres.TextLength==0)
            {
                Notificador.SetError(txbNombres, "El nombre no puede quedar vacio.");
                Validado = false;
            }
            if (txbApellidos.TextLength == 0)
            {
                Notificador.SetError(txbApellidos, "El apellido no puede quedar vacio.");
                Validado = false;
            }
            if (txbTelefono.TextLength == 0)
            {
                Notificador.SetError(txbTelefono, "El teléfono no puede quedar vacio.");
                Validado = false;
            }
            return Validado;
        }
        public EdicionContactos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                _Valido = true;
                Close();
            }
        }

        private void EdicionContactos_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

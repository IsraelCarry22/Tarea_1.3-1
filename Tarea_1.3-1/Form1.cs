using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1._3_1
{
    public partial class Form1 : Form
    {
        ArrayList personas = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void tsbnuevo_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Nombres no ingresados");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtNombres, "");

            if (txtApellidoPaterno.Text == "")
            {
                errorProvider1.SetError(txtApellidoPaterno, "Apellido no ingresados");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidoPaterno, "");

            if (txtApellidoMaterno.Text == "")
            {
                errorProvider1.SetError(txtApellidoMaterno, "Apellido no ingresados");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidoMaterno, "");

            Regex regemailo = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+" + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@" + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}" + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+" + @"[]" + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!regemailo.IsMatch(txtGmail.Text))
            {
                errorProvider1.SetError(txtGmail, "Gmail no es valida");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtGmail, "");

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "Telefono no es valido");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            Person mipersona = new Person();
            mipersona.Nombre = txtNombres.Text;
            mipersona.Apellido_paterno = txtApellidoPaterno.Text;
            mipersona.Apellido_materno = txtApellidoMaterno.Text;
            mipersona.Fecha_cumpeaños = dtpFechadenacimientp.Value;
            mipersona.Gmail = txtGmail.Text;
            mipersona.Telefono = txtTelefono.Text;
            personas.Add(mipersona);
            

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = personas;

            txtNombres.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtTelefono.Clear();
            txtGmail.Clear();
            txtNombres.Focus();
        }
    }
}
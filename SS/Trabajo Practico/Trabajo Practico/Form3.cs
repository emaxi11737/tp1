using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico
{
    public partial class frmPersonas : Form
    {
        private BindingList<Persona> listaPersonas = new BindingList<Persona>();
        private string listaGeneros;
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            dgvPersonas.DataSource = listaPersonas;
            dgvPersonas.MultiSelect = false;



        }
        private void refrescarGrilla()
        {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = listaPersonas;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || cbbColor.SelectedIndex < 0 || dtpNac.Value.Date > DateTime.Today.Date || chkGen.CheckedItems.Count == 0 )
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            int r = int.Parse(txtEdad.Text);
            

            Persona p = new Persona(txtNombre.Text,txtApellido.Text,r,determinarSexo(),cbbColor.Text,dtpNac.Text,generosFav());
            listaPersonas.Add(p);
            refrescarGrilla();
        }

        private string generosFav()
        {
            listaGeneros = "";
            foreach (string item in chkGen.CheckedItems)
            {

                listaGeneros += item.ToString();
                listaGeneros += " ";

            }
            return listaGeneros;
            throw new NotImplementedException();
        }

        private int calcularEdad()
        {
            
            var hoy = DateTime.Today;
   
            var edad = hoy.Year - dtpNac.Value.Date.Year;
            if(dtpNac.Value.Date.Month > hoy.Month && dtpNac.Value.Day > hoy.Month)
            {
                edad--;
            }
            return (int)edad;
            throw new NotImplementedException();
        }

        private string determinarSexo()
        {
           
            if(rbtHombre.Checked==true)
            {
                return "Hombre";
            }
            if (rbtMujer.Checked == true)
            {
                return "Mujer";
            }
            if (rbtND.Checked == true)
            {
                return "No disponible";
            }
            if (rbtHeli.Checked == true)
            {
                return "Helicoptero Apache";
            }
            throw new NotImplementedException();
        }

        private void dtpNac_ValueChanged(object sender, EventArgs e)
        {
            
            txtEdad.Text = calcularEdad().ToString(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvPersonas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una persona");
                return;
            }

            foreach (DataGridViewRow item in this.dgvPersonas.SelectedRows)
            {
                dgvPersonas.Rows.RemoveAt(item.Index);
                
            }

        }

        private void btnelTodo_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = null;
            listaPersonas.Clear();
            dgvPersonas.Rows.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || cbbColor.SelectedIndex < 0 || dtpNac.Value.Date > DateTime.Today.Date || chkGen.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            int r = int.Parse(txtEdad.Text);
            listaPersonas.ElementAt(dgvPersonas.CurrentCell.RowIndex).modificarDatos(txtNombre.Text, txtApellido.Text, r, determinarSexo(), cbbColor.Text, dtpNac.Text, generosFav());
            refrescarGrilla();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }
    }
}

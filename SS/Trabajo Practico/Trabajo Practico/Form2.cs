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
    public partial class frmObjetos : Form
    {


        public frmObjetos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem listaObjetos = new ListViewItem(txtNombre.Text);
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            lvObjetos1.Items.Add(listaObjetos);
            actualizarContadores();


        }

        private void frmObjetos_Load(object sender, EventArgs e)
        {

            lvObjetos1.GridLines = true;
            lvObjetos1.FullRowSelect = true;
            lvObjetos2.GridLines = true;
            lvObjetos2.FullRowSelect = true;

        }

        private void lvObjetos1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvObjetos2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private bool itemsSeleccionados(ListView fuente)
        {
            if(fuente.SelectedItems.Count > 0)
            {
                return true;
            }
            return false;
            
        }
        private void borrarObjetos(ListView fuente)
        {
            foreach (ListViewItem item in fuente.SelectedItems)
            {
                fuente.Items.Remove(item);
            }
        }
        private bool verificarRepeticion(string text)
        {
            foreach (ListViewItem item in lvObjetos2.Items)
            {
                if(text.Contains(item.Text))
                {
                    return false;
                }

            }
            return true;
        }
        private void copiarobjRep(ListView fuente, ListView destino)
        {
            foreach (ListViewItem item in fuente.SelectedItems)
            {
                if(verificarRepeticion(item.Text))
                {
                    destino.Items.Add((ListViewItem)item.Clone());
                    fuente.Items.Remove(item);
                }
               
                
            }
            
        }

        private void copiarobjsRep(ListView fuente, ListView destino)
        {
            foreach (ListViewItem item in fuente.SelectedItems)
            {
                
                    destino.Items.Add((ListViewItem)item.Clone());
                    fuente.Items.Remove(item);
                


            }
        }

        private void copiartodoRep(ListView fuente, ListView destino)
        {
            foreach (ListViewItem item in fuente.Items)
            {
                if(verificarRepeticion(item.Text))
                {
                    destino.Items.Add((ListViewItem)item.Clone());
                    fuente.Items.Remove(item);
                }
       

            }
            
        }
       
      
        private void button2_Click(object sender, EventArgs e)
        {
            if (itemsSeleccionados(lvObjetos1))
            {
                
                    copiarobjRep(lvObjetos1, lvObjetos2);
                actualizarContadores();
                    
                    return;
                
            }

            MessageBox.Show("Debe seleccionar al menos un item");

        }

        private bool comprobarRepeticion(string text)
        {
            foreach (ListViewItem item in lvObjetos2.Items)
            {
                
                if(Equals(item.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                copiartodoRep(lvObjetos1, lvObjetos2);
                actualizarContadores();



        }

        private void button3_Click(object sender, EventArgs e)
        {
        if (itemsSeleccionados(lvObjetos2))
        {
           copiarobjsRep(lvObjetos2, lvObjetos1);
           
                actualizarContadores();
                return;
            }
            MessageBox.Show("Debe seleccionar al menos un item");


        }

       

        private void actualizarContadores()
        {
             lblcantlbl1.Text = lvObjetos1.Items.Count.ToString();
            lblcantlbl2.Text = lvObjetos2.Items.Count.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (itemsSeleccionados(lvObjetos2))
            {
                borrarObjetos(lvObjetos2);
                actualizarContadores();
                return;
            }
            MessageBox.Show("Debe seleccionar al menos un item");
        }

        
    }

}

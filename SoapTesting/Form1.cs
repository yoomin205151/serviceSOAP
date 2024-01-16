using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOAP;

namespace SoapTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void listarProducto()
        {
            Service1 objService = new Service1();
            dgv_producto.DataSource = objService.SP_LISTARPRODUCTO().Tables[0];
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Producto prod = new Producto();
            prod.detail = txtDescripcion.Text;
            prod.quantity = Convert.ToInt32(txtStock.Text);
            prod.price = Convert.ToDouble(txtPrecio.Text);
            prod.dates = pk_dates.Value;

            Service1 objService = new Service1();
            objService.SP_INSERTARPRODUCTO(prod);

            MessageBox.Show("Producto Creado Exitosamente");
            listarProducto();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listarProducto();
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Producto prod = new Producto();
            prod.id = Convert.ToInt32(dgv_producto.CurrentRow.Cells[0].Value.ToString());

            Service1 objService = new Service1();
            objService.SP_ELIMINARPRODUCTO(prod);

            MessageBox.Show("Producto Eliminado Exitosamente");
            listarProducto();

        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.id = Convert.ToInt32(dgv_producto.CurrentRow.Cells[0].Value.ToString());
            prod.detail = txtDescripcion.Text;
            prod.quantity = Convert.ToInt32(txtStock.Text);
            prod.price = Convert.ToDouble(txtPrecio.Text);
            prod.dates = pk_dates.Value;

            Service1 objService = new Service1();
            objService.SP_ACTUALIZARPRODUCTO(prod);

            MessageBox.Show("Producto Modificado Exitosamente");
            listarProducto();
        }

        private void dgv_producto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDescripcion.Text = dgv_producto.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgv_producto.CurrentRow.Cells[3].Value.ToString();
            txtStock.Text = dgv_producto.CurrentRow.Cells[2].Value.ToString();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Producto prod = new Producto();

            prod.detail = txtBuscar.Text;

            Service1 objService = new Service1();
            dgv_producto.DataSource = objService.SP_BUSCARPRODUCTO(prod).Tables[0];
       
        }

        private void lIMPIARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

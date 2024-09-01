using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Abrir_form(new ver_donantes());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fecha_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Abrir_form(new registrar_donante());
        }

        private void Abrir_form(object formulario)
        {
            if(this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void Abrir_ventana(object ventana)
        {
            Form fh = ventana as Form;
            fh.TopLevel = true;
            fh.Show();
        }

        private void btndonar_Click(object sender, EventArgs e)
        {
            Abrir_form(new realizar_donacion());
            Abrir_ventana(new cuestionario());
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            Abrir_form(new ver_stock());
        }
    }
}

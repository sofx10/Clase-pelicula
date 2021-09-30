using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pelicula pelicula= new Pelicula();

            pelicula.set_peliculadirigida(1);
            pelicula.set_nombre("Shrek");
            pelicula.set_fechaestreno("2022");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.set_peliculadirigida(Convert.ToInt32(txtpeliculadirigida.Text));
            pelicula.set_nombre(txtnombre.Text);
            pelicula.set_fechaestreno(txtfechaestreno.Text);

            Pelicula pelicula1 = new Pelicula(Convert.ToInt32(txtpeliculadirigida.Text),
               txtnombre.Text, txtfechaestreno.Text);


            lstPeliculaInfo.Items.Add("Mediante constructor vacío: " + pelicula.getPelicula());
            lstPeliculaInfo.Items.Add("Mediante constructor inicializando las propiedades: " + pelicula.getPelicula());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nope.clases;


namespace nope
{
    public partial class Form1 : Form
    {
        Crud miCrud = new Crud();
        Crud2 miCrud2 = new Crud2();

        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            textBoxEstudiante.Text = miCrud.MostrarCarnet(textBoxCarnet.Text);
            textBoxSeccion.Text = miCrud.MostrarSeccion(textBoxCarnet.Text);
            textBoxCorreo.Text = miCrud.MostrarCorreo(textBoxCarnet.Text);
            textBoxNota1.Text = miCrud2.MostrarNota1(textBoxCarnet.Text);
            textBoxNota2.Text = miCrud2.MostrarNota2(textBoxCarnet.Text);
            textBoxNota3.Text = miCrud2.MostrarNota3(textBoxCarnet.Text);
            textBoxNota4.Text = miCrud2.MostrarNota4(textBoxCarnet.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            string nombre = textBoxEstudiante.Text;
            string carnet = textBoxCarnet.Text;
            string email = textBoxCorreo.Text;
            string seccion = textBoxSeccion.Text;
            string respuesta = miCrud.AgregarAlumno(carnet, nombre, email, seccion);
            string nota1 = textBoxNota1.Text;
            string nota2 = textBoxNota2.Text;
            string nota3 = textBoxNota3.Text;
            string nota4 = textBoxNota4.Text;
           
            MessageBox.Show(respuesta);

        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            string nota1 = textBoxNota1.Text;
            string nota2 = textBoxNota2.Text;
            string nota3 = textBoxNota3.Text;
            string nota4 = textBoxNota4.Text;
            string carnet = textBoxCarnet.Text;
            string respuesta = miCrud2.ActualizarNotas(carnet, nota1, nota2, nota3, nota4);
            MessageBox.Show(respuesta);
        }

        private void textBoxCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNota1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxNota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNota3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNota4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

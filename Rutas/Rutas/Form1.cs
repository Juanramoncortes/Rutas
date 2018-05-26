using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rutas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Base nuevo;
        string nom,hrinicio,hrfin;
        Estructura Estructura;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            nom = txtNombreBase.Text;
            Base encontrado = Estructura.Buscar(nom);
            if (encontrado != null)
                txtList.Text = encontrado.ToString();
            else
                txtList.Text = "/No encontrado/";
            Num();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Estructura = new Estructura();
            lblTotal.Text = Convert.ToString(Estructura.contador);
            Num();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            txtList.Text = Estructura.Lista();
            Num();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nom = txtNombreBase.Text;
            Base elimindado = Estructura.Eliminar(nom);
            if(elimindado != null)
            txtList.Text = elimindado.ToString() + "\t//Elimidado";
            Num();
        }

        private void btnEliminaralultimo_Click(object sender, EventArgs e)
        {
            Base elimindado = Estructura.EliminarUltimo();
            if (elimindado != null)
                txtList.Text = elimindado.ToString()+"\t//Ultimo Elimidado";
            Num();
        }

        private void btnEliminarprimero_Click(object sender, EventArgs e)
        {
            Base elimindado = Estructura.EliminarPrimero();
            if (elimindado != null)
                txtList.Text = elimindado.ToString() + "\t//Primero Elimidado";
            Num();
        }

        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            Leer();
            nuevo = new Base(nom,hrinicio,hrfin);
            Estructura.AgregarFinal(nuevo);
            Num();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            Leer();
            nuevo = new Base(nom, hrinicio, hrfin);
            int pos = Convert.ToInt32(numericUpDown1.Value);
            Estructura.Insertar(nuevo,pos);
            Num();
        }

        private void Leer()
        {
            nom = txtNombreBase.Text;
            hrinicio = dateTimeinicio.Text;
            hrfin = dateTimeFin.Text;
           
        }
        private void Num()
        {
            lblTotal.Text = Convert.ToString(Estructura.contador);
            numericUpDown1.Maximum = Estructura.contador;

        }
    }
}

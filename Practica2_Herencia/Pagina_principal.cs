using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_Herencia
{
    public partial class Pagina_principal : Form
    {
        //metodo constructor
        public Pagina_principal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //boton de salir
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//al presionarlo cierra la ventana
        }


        //BOTON PARA ESTUDIOS  QS3
        private void button2_Click(object sender, EventArgs e)
        {
            //al presionarlo creea una bandera que pasara como parametro
            int bandera = 1;
            this.Hide();//esconde la ventana principal
            Estudios_QS3 estudios = new Estudios_QS3(bandera);//hago una instancia de la clase hija Estudios_QS3 crenado un objeto y le paso como parametro la bandera
            estudios.Show();//muestro esta ventana creada


        }

        //PARA ESTUDIOS A QS6
        private void button3_Click(object sender, EventArgs e)
        { //al presionarlo creea una bandera que pasara como parametro
            int bandera = 0;
            this.Hide();//escondo la ventana principal
            Estudios_QS6 estudios = new Estudios_QS6(bandera);//hago una instancia de la clase hija Estudios_QS3 crenado un objeto y le paso como parametro la bandera
            estudios.Show();//muestro esta ventana creada
        }
    }
}

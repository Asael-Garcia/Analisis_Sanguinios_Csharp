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

    //esta es mi clase madre
    public partial class Madre : Form
    {
        private int bandera;//creo una variable privada que sera la bandera que indique que calculo se va a realizar
        public Madre(int bandera)//metodo constructor, le paso como perimetro una variable
        {
            InitializeComponent();//metodo inicializador
            this.bandera = bandera;//asigno la variable que pase como perimetro a la local que creee
        }

        //METODO PARA HACER EL CALCULO DE LOS ESTUDIOS S3
        private void calculo_QS3()
        {
            //este metodo sirve para hacer los calculos de los estudios S3 y asignarlos a un luar, en este caso a labels
            //que cree especificamente para presentar el resutltado, lo que entra para la conversion entra como string 
            //asi que lo convierto a float con un parse, hago la operacion y concateno "mg/dl" para hacerlo string
            resultado_glucosa.Text = float.Parse(glucosa.Text) * 18.02 + " mg/dL";
            resultado_urico.Text = float.Parse(acido_urico.Text) * 0.02 + " mg/dL";
            resultado_colesterol.Text = float.Parse(colesterol.Text) * 380.66 + " mg/dL";
        }

       

        //PARA HACER EL CALCULO DE LA UREA
        private void calcular_QS6()
        {
            //este metodo sirve para hacer los calculos de los estudios S6 y asignarlos a un luar, en este caso a labels
            //que cree especificamente para presentar el resutltado, lo que entra para la conversion entra como string 
            //asi que lo convierto a float con un parse, hago la operacion y concateno "mg/dl" para hacerlo string
            resultado_urea.Text = float.Parse(urea.Text) * 6.01 + " mg/dL";
            resultados_tri.Text = float.Parse(tri.Text) * 87.5 + " mg/dL";
            resultados_crea.Text = float.Parse(creatinina.Text) * 0.01 + " mg/dL";
        }


        //este es un metodo que se ejecutara al presionar el boton de salir
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//primero cierra la ventana exitente
            Pagina_principal menu = new Pagina_principal();//hago una instancia a la clase de la pagina principal
            menu.Show();//la presento
        }


        //este es un metodo que indicara que calculos hacer dependiendo de la vandera, este se le asigna al boton de calcular
        private void button1_Click(object sender, EventArgs e)
        {
            //PARA QS3
            if (this.bandera == 1)//si la bandera es uno
            {//manda a llamar al metodo del calculo para estudios S3
                this.calculo_QS3();
            }
            
            //para QS6
            else if (this.bandera == 0)//si la bandera es cero
            {//manda a llamar al metodo del calculo para estudios S3
                //ademas del metodo para el calculo de los estudios S6
                this.calculo_QS3();
                this.calcular_QS6();
            }
            
        }
    }
}

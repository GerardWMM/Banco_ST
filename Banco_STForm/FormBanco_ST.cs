using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Banco_STForm
{
    public partial class FormBanco_ST : Form
    {
        public FormBanco_ST()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int monto = int.Parse(txtMonto.Text);
            validarMonto(monto);
            int cuotas = int.Parse(txtCuotas.Text);
            validarCuotas(cuotas);
            calculoMonto(cuotas, monto);

            


            Cliente c = new Cliente(nombre, apellido, monto, cuotas);
            MessageBox.Show("¡Simulación creada con exito!");
        }

        //Metodos de validación
        private void validarMonto(int monto)
        {
            if(monto < 500000)
            {
                MessageBox.Show($"Error: Ingresaste un monto menor a $500.000 ({monto})");
            }
        }

        private void validarCuotas(int cuotas)
        {
            if(cuotas < 1 || cuotas > 36)
            {
                MessageBox.Show($"Error: La cantidad de cuotas no está entre 1 y 36 (Cuotas: {cuotas})");
            }
        }

        private void calculoMonto(int cuotas, int monto)
        {
            double montoA;
            double montoTotal;
            double montoCuota;


            if(cuotas >= 1 && cuotas <= 12)
            {
                //Monto total
                montoA = monto * 0.1;
                montoTotal = monto + montoA;

                //Monto cuota
                montoCuota = montoTotal / cuotas;

                //Mostrar resultado en las textbox
                txtResultadoCuotas.Text = montoCuota.ToString();
                txtResultadoTotal.Text = montoTotal.ToString();

            }else if(cuotas >= 13 && cuotas < 24)
            {
                //Monto total
                montoA = monto * 0.2;
                montoTotal = monto + montoA;

                //Monto cuota
                montoCuota = montoTotal / cuotas;

                //Mostrar resultado en las textbox
                txtResultadoCuotas.Text = montoCuota.ToString();
                txtResultadoTotal.Text = montoTotal.ToString();

            }
            else if(cuotas >= 24 && cuotas <= 36)
            {
                montoA = monto * 0.35;
                montoTotal = monto + montoA;

                //Monto cuota
                montoCuota = montoTotal / cuotas;
                Console.WriteLine($"{montoTotal} \n{montoCuota}");

                //Mostrar resultado en las textbox
                txtResultadoCuotas.Text = montoCuota.ToString();
                txtResultadoTotal.Text = montoTotal.ToString();
            }
        }

        private void txtResultadoTotal_TextChanged(object sender, EventArgs e)
        {

        }       
     
    }
}

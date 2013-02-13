using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventarios
{
    public partial class Form1 : Form
    {
        double d, co, ch, q, c, da, cai, r = 0, l; int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pgb.Value = 0;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txt_anios.Text == " " || txt_conservacion.Text == " " || txt_orden.Text == " " || txt_anios.Text == "" || txt_conservacion.Text == "" || txt_orden.Text == "")
            {
                MessageBox.Show("No se puede calcular sin los datos necesarios verifique que ha ingresado los 3 Datos necesarios");
            }
            else
            {
            d = double.Parse(txt_anios.Text);
            co = double.Parse(txt_orden.Text);
            ch = double.Parse(txt_conservacion.Text);


            pgb.Value = 0;
            r = 0;
                if (txt_dias.Text != " " && txt_dias.Text != "")
                {
                                 
                    l = double.Parse(txt_dias.Text);
                    r = l * d / 365;

                }

                q = Math.Sqrt((2 * d * co) / ch);
                c = d / q;
                da = 365 / c;
                cai = (d / q * co) + (q / 2 * ch);


                timer1.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgb.Value < 100)
            {
                lbl_calculando.Text = "Calculando " + pgb.Value + "%...";
                pgb.Value += 1;
            }
            else
            {
                lbl_calculando.Text = "Calculado a la Precision";
                lbl_Resultado.Text = "Resultados: ";
                lbl_Resultado.Text += ("La cantidald a ordenar en unidades es :" + q);
                lbl_Resultado.Text += ("\nEl numero de ordenes es :" + c);
                lbl_Resultado.Text += ("\nDias entre orden :" + da);
                lbl_Resultado.Text += ("\nEl costo anual de inventario  es :" + cai);
                if (r != 0)
                {
                    lbl_Resultado.Text += ("\nEl punto de reorden es: " + r);
                }
                timer1.Enabled = false;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

    }
}

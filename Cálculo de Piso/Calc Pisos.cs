using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cálculo_de_Piso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calc_Qtd_Pisos_Click_1(object sender, EventArgs e)
        {
            decimal compComodo, largComodo, areaComodo, compPisos, largPisos, areaPisos, qtdPisos;

            if (txt_Comp_Cômodo.Text == "")
            {
                MessageBox.Show("Digite a medida do comprimento do cômodo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Larg_Cômodo.Text == "")
            {
                MessageBox.Show("Digite a medida da largura do cômodo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmb_Comp_Piso.Text == "")
            {
                MessageBox.Show("Selecione o comprimento do piso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmb_Larg_Piso.Text == "")
            {
                MessageBox.Show("Selecione a largura do piso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                compComodo = Convert.ToDecimal(txt_Comp_Cômodo.Text);
                largComodo = Convert.ToDecimal(txt_Larg_Cômodo.Text);
                compPisos = Convert.ToDecimal(cmb_Comp_Piso.Text);
                largPisos = Convert.ToDecimal(cmb_Larg_Piso.Text);

                // Convertendo as medidas do piso de cm para m
                compPisos /= 100;
                largPisos /= 100;

                areaComodo = compComodo * largComodo;

                areaPisos = compPisos * largPisos;

                qtdPisos = areaComodo / areaPisos;

                qtdPisos /= 1000;
                txt_Qtd_Pisos.Text = String.Format("{0:n2}", qtdPisos);
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class form_Qtd_Pisos : Form
    {
        public form_Qtd_Pisos()
        {
            InitializeComponent();
        }

        private void btn_Calc_Qtd_Pisos_Click_1(object sender, EventArgs e)
        {
            double compComodo, largComodo, areaComodo, compPisos, largPisos, areaPisos, qtdPisos;

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
                compComodo = Convert.ToDouble(txt_Comp_Cômodo.Text);
                largComodo = Convert.ToDouble(txt_Larg_Cômodo.Text);
                compPisos = Convert.ToDouble(cmb_Comp_Piso.Text);
                largPisos = Convert.ToDouble(cmb_Larg_Piso.Text);

                // Convertendo as medidas do piso de cm para m
                compPisos /= 100;
                largPisos /= 100;

                areaComodo = compComodo * largComodo;

                areaPisos = compPisos * largPisos;

                qtdPisos = areaComodo / areaPisos;

                txt_Qtd_Pisos.Text = String.Format("{0:n2}", qtdPisos);
            }
        }

        private void txt_Comp_Cômodo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Larg_Cômodo.Focus();
            }
        }

        private void txt_Larg_Cômodo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Comp_Piso.Focus();
            }
        }

        private void cmb_Comp_Piso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Larg_Piso.Focus();
            }
        }

        private void txt_Comp_Cômodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txt_Larg_Cômodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void form_Qtd_Pisos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do formulário?", "Mensagem de aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Larg_Cômodo.Clear();
            txt_Comp_Cômodo.Clear();
            cmb_Comp_Piso.SelectedIndex = -1;
            cmb_Larg_Piso.SelectedIndex = -1;
            txt_Comp_Cômodo.Focus();
        }
    }
}

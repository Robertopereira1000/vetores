using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Decimal resultado {  get; set; }
        public Decimal valor { get; set; }
        private operacao  OperacaoSelecionada {  get; set; }
        private enum operacao 
        {
            adicao,
                subtracao,
                multiplicacao,
                divisao,
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            text_resultado.Text += "0";
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            text_resultado.Text += "1";
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            text_resultado.Text +="2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            text_resultado.Text += "3";
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            text_resultado.Text += "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            text_resultado.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            text_resultado.Text += "6";
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            text_resultado.Text += "7";
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            text_resultado.Text += "8";
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            text_resultado.Text += "9";
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.adicao;
            valor = Convert.ToDecimal(text_resultado.Text);
            text_resultado.Text = "";
            lbloperacao.Text = "+";
            
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.subtracao;
            valor = Convert.ToDecimal(text_resultado.Text);
            text_resultado.Text = "";
            lbloperacao.Text = "-";
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.multiplicacao;
            valor = Convert.ToDecimal(text_resultado.Text);
            text_resultado.Text = "";
            lbloperacao.Text = "*";
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.divisao;
            valor = Convert.ToDecimal(text_resultado.Text);
            text_resultado.Text = "";
            lbloperacao.Text = "/";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            switch(OperacaoSelecionada)
            {
                case operacao.adicao:
                    resultado = valor + Convert.ToDecimal(text_resultado.Text);
                    break;
                case operacao.subtracao:
                    resultado = valor - Convert.ToDecimal(text_resultado.Text);
                    break;
                case operacao.multiplicacao:
                    resultado = valor * Convert.ToDecimal(text_resultado.Text);
                    break;         
                case operacao .divisao:
                    resultado = valor / Convert.ToDecimal(text_resultado.Text);
                    break;
            }
            text_resultado.Text = Convert.ToString(resultado);
            lbloperacao.Text = "=";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (text_resultado.Text.Contains(","))
           text_resultado.Text += "";
            
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            text_resultado.Text = "";
            lbloperacao.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N1_FolhaPagamento2
{
    public partial class Form1 : Form
    {
        double salariob, salarioliquido, contri, descontocontri, descontovale, descontosaude, descontoirf, descontoInss,
            descontoOdonto, registro, departamento;

        private void button2_Click_1(object sender, EventArgs e)
        {
            salariob = 0;
            salarioliquido = 0;
            txtSalarioB.Text = string.Empty;
            txtContri.Text = string.Empty;
            txtDepartamento.Text = string.Empty;
            txtInss.Text = string.Empty;
            txtIrf.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtOdonto.Text = string.Empty;
            txtRegistro.Text = string.Empty;
            txtSalarioL.Text = string.Empty;
            txtSaude.Text = string.Empty;
            txtVale.Text = string.Empty;
            cbSaude.CheckState = CheckState.Unchecked;
            cbContri.CheckState = CheckState.Unchecked;
            cbVale.CheckState = CheckState.Unchecked;
            cbOdonto.CheckState = CheckState.Unchecked;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            salariob = Convert.ToDouble(txtSalarioB.Text.Trim());

            // DESCONTO INSS
            if (salariob <= 1830)
            {
                descontoInss = salariob * 0.08;
                txtInss.Text = descontoInss.ToString();

            }
            if (salariob > 1830 && salariob < 3050)
            {
                descontoInss = salariob * 0.09;
                txtInss.Text = descontoInss.ToString();
            }
            if (salariob > 3050 && salariob < 6101)
            {
                descontoInss = salariob * 0.11;
                txtInss.Text = descontoInss.ToString();

            }
            if (salariob > 6101)
            {
                descontoInss = salariob * 0.11;
                txtInss.Text = descontoInss.ToString();

            }

            //DESCONTO IRF

            if (salariob <= 1903)
            {
                descontoirf = 0;
                txtIrf.Text = descontoirf.ToString();

            }
            if (salariob > 1903 && salariob < 2826)
            {
                descontoirf = salariob * 0.075;
                txtIrf.Text = descontoirf.ToString();
            }
            if (salariob > 2826 && salariob < 3751)
            {
                descontoirf = salariob * 0.15;
                txtIrf.Text = descontoirf.ToString();

            }
            if (salariob > 3715 && salariob < 4664)
            {
                descontoirf = salariob * 0.225;
                txtIrf.Text = descontoirf.ToString();

            }

            if (salariob > 4664)
            {
                descontoirf = salariob * 0.275;
                txtIrf.Text = descontoirf.ToString();
            }

            // DESCONTO CONTRIBUIÇÃO SINDICAL
            if (cbContri.Checked)
            {
                descontocontri = salariob * 0.02;
                txtContri.Text = descontocontri.ToString();
            }
            // DESCONTO VALE TRANSPORTE
            if (cbVale.Checked)
            {
                descontovale = salariob * 0.06;
                txtVale.Text = descontovale.ToString();
            }
            // DESCONTO PLANO DE SAUDE
            if (cbSaude.Checked)
            {
                descontosaude = 75.60;
                txtSaude.Text = descontosaude.ToString();
            }
            // DESCONTO PLANO ODONTOLOGICO
            if (cbOdonto.Checked)
            {
                descontoOdonto = 32.45;
                txtOdonto.Text = descontoOdonto.ToString();
            }

            //NOME
            nome = txtNome.Text;
            txtNome.Text = nome;

            //REGISTRO
            {
                txtRegistro.Text = registro.ToString();

            }
            //DEPARTAMENTO
            {
                txtDepartamento.Text = departamento.ToString();

            }
            //SALARIO LIQUIDO

            salarioliquido = salariob - (descontoOdonto + descontosaude + descontovale + descontocontri + descontoirf + descontoInss);
            txtSalarioL.Text = salarioliquido.ToString();
        }

        string nome;

       

        public Form1()
        {
            InitializeComponent();
        }



      

    }
}


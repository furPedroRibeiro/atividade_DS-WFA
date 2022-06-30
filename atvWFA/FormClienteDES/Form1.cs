using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClienteDES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        //este botão é o de sair
        private void Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PcbFoto_Click(object sender, EventArgs e)
        {
            
        }

        //botão de carregar foto
        private void Button7_Click(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.furia;
        }

        private void LimparFoto_Click(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            TB_codigo.Clear();
            TB_nome.Clear();
            TB_rg.Clear(); 
            TB_cpf.Clear(); 
            TB_telRes.Clear(); 
            TB_tel.Clear(); 
            TB_cep.Clear(); 
            TB_logr.Clear(); 
            TB_numero.Clear();
            TB_bairro.Clear(); 
            TB_cidade.Clear(); 
            TB_email.Clear(); 
            TB_insta.Clear();
            //radius
            CB_email.Checked = false;
            CB_insta.Checked = false;
            RB_masc.Checked = false;
            RB_fem.Checked = false;
        }

        private void ButtonIncluir_Click(object sender, EventArgs e)
        {
            //textBox
            TB_codigo.Text = "001";
            TB_nome.Text = "Rafael 'Saffe' Costa";
            TB_rg.Text = "1234567-8";
            TB_cpf.Text = "12345678901";
            TB_telRes.Text = "3455-9808";
            TB_tel.Text = "13-996356704";
            TB_cep.Text = "11750-000";
            TB_logr.Text = "Darcy Lacerda";
            TB_numero.Text = "970";
            TB_bairro.Text = "Park D'aville";
            TB_cidade.Text = "Peruíbe";
            TB_email.Text = "guiLindoSales@gmail.com";
            TB_insta.Text = "pedrol_art";
            //radios
            RB_masc.Checked = true;
            //checkbox
            CB_email.Checked = true;
            CB_insta.Checked = true;
            //adc img
            pcbFoto.Image = Properties.Resources.furia;
        }

        private void CB_email_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_email.Checked == true)
            {
                TB_email.Focus();
            }
            else
            {

            }
        }

        private void CB_insta_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_insta.Checked == true)
            {
                TB_insta.Focus();
            }
            else
            {

            }
        }

        private void ButtonConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Código: "+TB_codigo.Text+"\n Nome: "+TB_nome.Text+"\n RG:"+TB_rg.Text+"\n CPF: "+TB_cpf.Text+"\n Tel.Res.: "+TB_telRes.Text+"\n Tel: "+TB_tel+"\n Sexo: "+RB_fem.Text+"\n CEP: "+TB_cep+"\n Logradouro: "+TB_logr+"\n Cidade: "+TB_cidade+"\n Bairro: "+TB_bairro+"\n Número: "+TB_numero+"\n Email: "+TB_email+"\n Instagram: "+TB_insta);
        }
    }
}

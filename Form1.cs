using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Idade
{
    public partial class FrmProjetoIdade : Form
    {
        string nome1, nome2;
        int nascimento1, nascimento2, ano_atual, idade1, idade2;

        private void Txtdatadenascimento1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtnome2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)
            {
                if (Txtnome2.Text != "")
                {
                    nome2 = Txtnome2.Text;
                    TxtIdade2.Enabled = true;
                    TxtIdade2.Focus();
                }
                else
                    MessageBox.Show("Você não digitou o Nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) &&  !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) 
            {
                e.Handled = true;
                MessageBox.Show("Somente Letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtIdade1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(TxtIdade1.Text != "")
                {
                    nascimento1 = int.Parse(TxtIdade1.Text);
                    Txtnome2.Enabled = true;
                    Txtnome2.Focus();

                }
                else
                    MessageBox.Show("Você não digitou o ano de nascimento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
               e.Handled = true;
               MessageBox.Show("Não é permitido digitar letras!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TxtIdade2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)
            {
                if(TxtIdade2.Text != "")
                {
                    nascimento2 = int.Parse(TxtIdade2.Text);
                    TxtAno.Enabled = true;
                    TxtAno.Focus();
                }
                else
                    MessageBox.Show("Você não digitou o ano de nascimento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
               e.Handled = true;
               MessageBox.Show("Não é permitido Digitar Letras!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)
            {
                if (TxtAno.Text !="")
                {
                    ano_atual = int.Parse(TxtAno.Text);

                    idade1 = ano_atual - nascimento1;
                    idade2 = ano_atual - nascimento2;

                    if ((ano_atual > nascimento1) && (ano_atual > nascimento2)) //O Ano tem que ser sempre Maior
                    {
                        if (idade1 > idade2)
                        {
                            MessageBox.Show(nome1 + " É mais Velho(a) com" + idade1.ToString() + "anos." + "\n" + "\n" + nome2 + " é mais novo(a) com" + idade2.ToString() + " anos.", "Resultado", MessageBoxButtons.OK);
                        }
                        else if (idade1 < idade2)
                        {
                            MessageBox.Show(nome2 + " É mais velho(a) com" + idade2.ToString() + "anos." + "\n" + "\n" + nome1 + " é mais novo(a) com" + idade1.ToString() + " anos", "Resultado", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show(nome1 +" E " + nome2+" São Gemeos", "Resultado", MessageBoxButtons.OK);
                        }
                    }

                }
            }
           if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
               e.Handled = true;
               MessageBox.Show("Não é permitido digitar letras!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } //Ano atual - o Ano de Nascimento

        private void FrmProjetoIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void PicFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txtnome1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Txtnome1.Text != "")
                {
                    nome1 = Txtnome1.Text;
                    TxtIdade1.Enabled = true;
                    TxtIdade1.Focus();
                }
                else
                    MessageBox.Show("você não digitou o Nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) &&  !(e.KeyChar ==(char)Keys.Back) &&  !(e.KeyChar ==(char) Keys.Space))
                
            {
              e.Handled = true;
              MessageBox.Show("Somente Letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public FrmProjetoIdade()
        {
            InitializeComponent();
        }

        private void FrmProjetoIdade_Load(object sender, EventArgs e)
        {

        }
    }
}

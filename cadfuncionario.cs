using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mecanica
{
    public partial class cadfuncionario : Form
    {
        public cadfuncionario()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
           /* try
            {
                if (!cadnome.Text.Equals(""))
                {
                    cadastrofuncionarios cadfuncionarioss = new cadastrofuncionarios();
                    cadfuncionarioss.NOME = cadnome.Text;
                    cadfuncionarioss.SENHA = cadsenha.Text;

                    if (cadfuncionarioss.cadastrarfuncionarios())
                    {
                        MessageBox.Show($"deu boom o{cadfuncionarioss.NOME} ");

                    }
                    else
                    {
                        MessageBox.Show("não foi possivel cadastrar funcionario");
                    }
                }
                else
                {
                    MessageBox.Show("deu ruim");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("erro a cadastrar o usuario" + ex.Message);
            }*/
        }

        private void cadfuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}

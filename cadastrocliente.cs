using MongoDB.Driver;
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
    public partial class cadastrocliente : Form
    {
        public cadastrocliente()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!txtnome.Text.Equals("") && !txtcpf.Text.Equals("") && !txtend.Text.Equals("") && !txtemail.Text.Equals("") && !txtfone.Text.Equals(""))
            {
                var pessoa = new pessoas();
                pessoa.Nome = txtnome.Text;
                pessoa.CPF = txtcpf.Text;
                pessoa.Endereco = txtend.Text;
                pessoa.email = txtemail.Text;
                pessoa.telefone = txtfone.Text;

                var colletionCliente = Conn.Cadastrarcliente();

                colletionCliente.InsertOne(pessoa);

                txtnome.Clear();
                txtcpf.Clear();
                txtend.Clear();
                txtemail.Clear();
                txtend.Clear();
                txtfone.Clear();

                MessageBox.Show($"O cadastro do cliente  {pessoa.Nome}  foi efetuado");


            }
            else
            {
                MessageBox.Show($"deu ruim");


            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

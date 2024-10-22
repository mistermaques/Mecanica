using MongoDB.Driver;
using MySqlX.XDevAPI;
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
    public partial class cadcarro : Form
    {
        public cadcarro()
        {
            InitializeComponent();
        }

        private void cadcarro_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cpfCliente = txtcpf.Text;

            // Busca o cliente pelo CPF
            var cliente = BuscarClientePorCPF(cpfCliente);

            if (!txtmarca.Text.Equals("") && !txtmodelo.Text.Equals("") && !txtano.Text.Equals("") && !txtkm.Text.Equals("") && !txtplaca.Text.Equals("") && !txtcpf.Text.Equals(""))
            {
                var carros = new carro
                {
                    marca = txtmarca.Text,
                    modelo = txtmodelo.Text,
                    ano = txtano.Text,
                    quilometragem = txtkm.Text,
                    placa = txtplaca.Text,
                    ClienteId = cliente.Id
                };

                // Cadastrar o veículo na coleção 'carros'
                var colletionVeiculos = Conn.Cadastrarcarro();
                colletionVeiculos.InsertOne(carros);

                // Atualizar o cliente com o ID do novo veículo
                var cli = new MongoClient(Conn.Server);
                var db = cli.GetDatabase(Conn.Db);
                var colecaoClientes = db.GetCollection<pessoas>(Conn.ColletionCliente);

                var filtro = Builders<pessoas>.Filter.Eq(c => c.Id, cliente.Id);
                var update = Builders<pessoas>.Update.Push(c => c.Veiculos, carros.Id);

                colecaoClientes.UpdateOne(filtro, update);

                // Limpar os campos e mostrar mensagem de sucesso
                txtmarca.Clear();
                txtmodelo.Clear();
                txtano.Clear();
                txtplaca.Clear();
                txtkm.Clear();

                MessageBox.Show($"O cadastro do {carros.modelo} foi efetuado para o cliente {cliente.Nome}.");
            }
            else
            {
                MessageBox.Show("Cliente não encontrado. Verifique o CPF.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private pessoas BuscarClientePorCPF(string cpf)
        {
            var cli = new MongoClient(Conn.Server);
            var db = cli.GetDatabase(Conn.Db);
            var colecaoClientes = db.GetCollection<pessoas>(Conn.ColletionCliente);

            // Busca o cliente pelo CPF
            return colecaoClientes.Find(c => c.CPF == cpf).FirstOrDefault();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

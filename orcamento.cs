using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;


namespace Mecanica
{
    public partial class orcamento : Form
    {
        public orcamento()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private List<carro> BuscarVeiculosPorClienteId(string clienteId)
        {
            var cli = new MongoClient(Conn.Server);
            var db = cli.GetDatabase(Conn.Db);
            var colecaoVeiculos = db.GetCollection<carro>(Conn.Colletionveliculos);

            // Buscar todos os veículos com o ID do cliente
            return colecaoVeiculos.Find(v => v.ClienteId == clienteId).ToList();
        }



        private void BuscarInformacoesCliente(string cpfCliente)
        {
            var cliente = BuscarClientePorCPF(cpfCliente);

            if (cliente != null)
            {
                // Atualizar o label com o nome do cliente
                lblNomeCliente.Text = cliente.Nome;

                // Limpar a combobox antes de adicionar os veículos
                comboBoxVeiculos.Items.Clear();

                // Buscar os veículos associados ao cliente
                var veiculos = BuscarVeiculosPorClienteId(cliente.Id);

                if (veiculos != null && veiculos.Count > 0)
                {
                    foreach (var veiculo in veiculos)
                    {
                        comboBoxVeiculos.Items.Add(veiculo.modelo);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum veículo encontrado para este cliente.");
                }

                // Selecionar o primeiro item da combobox (opcional)
                if (comboBoxVeiculos.Items.Count > 0)
                {
                    comboBoxVeiculos.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Cliente não encontrado. Verifique o CPF.");
                lblNomeCliente.Text = "";  // Limpar o nome se o cliente não for encontrado
                comboBoxVeiculos.Items.Clear();  // Limpar a combobox
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpfCliente = txtCPF.Text;
            BuscarInformacoesCliente(cpfCliente);
        }

        private void PreencherComboBoxServicos()
        {
            var cli = new MongoClient(Conn.Server);
            var db = cli.GetDatabase(Conn.Db);
            var colecaoServicos = db.GetCollection<Servico>(Conn.ColletionServicos);

            // Buscar todos os serviços
            var servicos = colecaoServicos.Find(_ => true).ToList();

            // Limpar a combobox antes de adicionar os serviços
            comboBoxServicos.Items.Clear();

            // Adicionar os nomes dos serviços na combobox
            foreach (var servico in servicos)
            {
                comboBoxServicos.Items.Add(servico.nome);
            }

            // Selecionar o primeiro item por padrão (opcional)
            if (comboBoxServicos.Items.Count > 0)
            {
                comboBoxServicos.SelectedIndex = 0;
            }
        }



        private Servico BuscarServicoPorNome(string nomeServico)
        {
            var cli = new MongoClient(Conn.Server);
            var db = cli.GetDatabase(Conn.Db);
            var colecaoServicos = db.GetCollection<Servico>(Conn.ColletionServicos);

            // Buscar o serviço pelo nome
            return colecaoServicos.Find(s => s.nome == nomeServico).FirstOrDefault();
        }

        private void comboBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string servicoSelecionado = comboBoxServicos.SelectedItem.ToString();

            // Buscar os detalhes do serviço pelo nome
            var servico = BuscarServicoPorNome(servicoSelecionado);

            if (servico != null)
            {
                // Limpar a lista de detalhes
                listBoxDetalhesServicos.Items.Clear();

                // Adicionar os detalhes (tarefas) do serviço no ListBox
                foreach (var detalhe in servico.descricao)
                {
                    listBoxDetalhesServicos.Items.Add(detalhe);
                }
            }

        }

        private void orcamento_Load(object sender, EventArgs e)
        {
            PreencherComboBoxServicos();
        }

        private string GerarNumeroIdentificacao()
        {
            
            
            var cli = new MongoClient(Conn.Server);
            var db = cli.GetDatabase(Conn.Db);
            var colecaoOrcamentos = db.GetCollection<Orcamento>(Conn.ColletionOrcamento);

            Random random = new Random();
            string numero;

            bool numeroExiste;
                do
                {
                    numero = random.Next(00001, 99999).ToString(); // Gera um número de 5 dígitos
                                                                   // Verifica se o número já existe no banco de dados
                    numeroExiste = colecaoOrcamentos.Find(o => o.Numero == numero).Any();
                } while (numeroExiste); // Continua gerando até encontrar um número único

            return numero;
            

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string cpfCliente = txtCPF.Text;
            var cliente = BuscarClientePorCPF(cpfCliente);
            var veiculoSelecionado = comboBoxVeiculos.SelectedItem.ToString();
            var servicoSelecionado = comboBoxServicos.SelectedItem.ToString();

            if (cliente != null && veiculoSelecionado != null && servicoSelecionado != null)
            {
                // Gerar número de identificação único
                string numeroOrcamento = GerarNumeroIdentificacao();

                // Criar o objeto orçamento
                var orcamento = new Orcamento
                {
                    Numero = numeroOrcamento,
                    ClienteId = cliente.Id,
                    Veiculo = veiculoSelecionado,
                    Servico = servicoSelecionado,
                    Detalhes = richTextBox1.Text, // Texto inserido no RichTextBox
                    Status = "Orçamento" // Definido como orçamento
                };

                // Inserir no banco de orçamentos
                var cli = new MongoClient(Conn.Server);
                var db = cli.GetDatabase(Conn.Db);
                var colecaoOrcamentos = db.GetCollection<Orcamento>(Conn.ColletionOrcamento);
                
                colecaoOrcamentos.InsertOne(orcamento);

                MessageBox.Show($"Orçamento salvo com sucesso! Número: {numeroOrcamento}");
            }
            else
            {
                MessageBox.Show("Preencha todas as informações corretamente.");
            }

        }

        private void btnaprovar_Click(object sender, EventArgs e)
        {
            string cpfCliente = txtCPF.Text;
            var cliente = BuscarClientePorCPF(cpfCliente);
            var veiculoSelecionado = comboBoxVeiculos.SelectedItem.ToString();
            var servicoSelecionado = comboBoxServicos.SelectedItem.ToString();

            if (cliente != null && veiculoSelecionado != null && servicoSelecionado != null)
            {
                // Gerar número de identificação único
                string numeroOrdemServico = GerarNumeroIdentificacao();

                // Criar o objeto Ordem de Serviço
                var ordemServico = new OS // Pode ser uma classe diferente, ex: OrdemServico
                {
                    Numero = numeroOrdemServico,
                    ClienteId = cliente.Id,
                    Veiculo = veiculoSelecionado,
                    Servico = servicoSelecionado,
                    Detalhes = richTextBox1.Text, // Texto inserido no RichTextBox
                    Status = "Ordem de Serviço" // Definido como ordem de serviço
                };

                // Inserir no banco de ordens de serviço
                var cli = new MongoClient(Conn.Server);
                var db = cli.GetDatabase(Conn.Db);
                var colecaoOrdemServicos = db.GetCollection<OS>(Conn.ColletionOS);
                colecaoOrdemServicos.InsertOne(ordemServico);

                MessageBox.Show($"Ordem de Serviço aprovada! Número: {numeroOrdemServico}");
            }
            else
            {
                MessageBox.Show("Preencha todas as informações corretamente.");
            }

        }

        private void gerarpdf_Click(object sender, EventArgs e)
        {
            // Exemplo de dados do orçamento
            string numeroOrcamento = "12345";
            string nomeCliente = lblNomeCliente.Text;
            string veiculoSelecionado = comboBoxVeiculos.SelectedItem.ToString();
            string servicoSelecionado = comboBoxServicos.SelectedItem.ToString();
            string detalhes = richTextBox1.Text;

            // Caminho para salvar o PDF
            string caminhoPDF = $"orcamento_{numeroOrcamento}.pdf";

            // Criar o documento PDF
            using (var stream = new FileStream(caminhoPDF, FileMode.Create))
            {
                // Inicializa o escritor de PDF
                var writer = new PdfWriter(stream);
                var pdf = new PdfDocument(writer);
                var document = new Document(pdf);

                // Adicionar conteúdo ao PDF
                document.Add(new Paragraph($"Orçamento Número: {numeroOrcamento}"));
                document.Add(new Paragraph($"Cliente: {nomeCliente}"));
                document.Add(new Paragraph($"Veículo: {veiculoSelecionado}"));
                document.Add(new Paragraph($"Serviço: {servicoSelecionado}"));
                document.Add(new Paragraph($"Detalhes: {detalhes}"));

                // Fecha o documento
                document.Close();
            }

            MessageBox.Show($"PDF gerado com sucesso: {caminhoPDF}");
            // Tentar abrir o PDF no visualizador padrão do sistema
            try
            {
                System.Diagnostics.Process.Start(caminhoPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o PDF: {ex.Message}");
            }
        }

    }
    
}

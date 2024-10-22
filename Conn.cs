using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Mecanica
{
    public static class Conn
    {
        public static readonly string Server = "mongodb+srv://GABRIEL:GABRIEL@clusteroficina.oek4x.mongodb.net/?retryWrites=true&w=majority&appName=Clusteroficina";
        public static readonly string Db = "oficina";
        public static readonly string ColletionCliente = "cliente";
        public static readonly string ColletionLogin = "Login";
        public static readonly string Colletionveliculos = "Veiculos";
        public static readonly string ColletionServicos = "servicos";
        public static readonly string ColletionOrcamento = "orcamento";
        public static readonly string ColletionOS= "OrdemServico";


        public static IMongoCollection<pessoas> Cadastrarcliente()
        {
            var cli = new MongoClient(Conn.Server);
            var db = cli.GetDatabase(Conn.Db);
            return db.GetCollection<pessoas>(ColletionCliente);
        }


        public static IMongoCollection<carro> Cadastrarcarro()
        {
            var cli = new MongoClient(Conn.Server);
            var db = cli.GetDatabase(Conn.Db);
            return db.GetCollection<carro>(Colletionveliculos);
        }


    }
}

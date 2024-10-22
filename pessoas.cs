using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica
{
    public class pessoas
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string Id 
        { get; set; }

        public string Nome
        { get; set; }

        public string CPF
        { get; set; }

        public string Endereco
        { get; set; }

        public string email
        { get; set; }
        public string telefone
        { get; set; }

        public List<string> Veiculos { get; set; } = new List<string>();

    }

    public class login 
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string Id
        { get; set; }

        public string user
        { get; set; }

        public string senha
        { get; set; }
    }


    public class carro
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string Id
        { get; set; }

        public string marca
        { get; set; }

        public string modelo
        { get; set; }

        public string ano
        { get; set; }

        public string quilometragem
        { get; set; }
        public string placa
        { get; set; }
        public string ClienteId 
        { get; set; }

    }

    public class Servico
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string nome { get; set; }

        // Array de descrições/tarefas do serviço
        public List<string> descricao { get; set; }
    }

    public class Orcamento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Numero { get; set; } // Número de identificação único (5 dígitos)
        public string ClienteId { get; set; } // ID do cliente relacionado
        public string Veiculo { get; set; } // Modelo do veículo
        public string Servico { get; set; } // Serviço selecionado
        public string Detalhes { get; set; } // Detalhes adicionais inseridos no RichTextBox
        public string Status { get; set; } // Status: "Orçamento" ou "Ordem de Serviço"
    }
    public class OS
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Numero { get; set; } // Número de identificação único (5 dígitos)
        public string ClienteId { get; set; } // ID do cliente relacionado
        public string Veiculo { get; set; } // Modelo do veículo
        public string Servico { get; set; } // Serviço selecionado
        public string Detalhes { get; set; } // Detalhes adicionais inseridos no RichTextBox
        public string Status { get; set; } // Status: "Orçamento" ou "Ordem de Serviço"
    }






}

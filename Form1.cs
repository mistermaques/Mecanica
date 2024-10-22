using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mecanica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

    }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = txtuser.Text;
            string senha = txtsenha.Text;

            bool isAuthenticated = AuthenticateUser(user, senha);

            if (isAuthenticated)
            {
                MessageBox.Show("Login realizado com sucesso!");
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        
        private bool AuthenticateUser(string user, string senha)
        {
            var cli = new MongoClient(Conn.Server);  
            var db = cli.GetDatabase(Conn.Db);       
            var colecaoLogin = db.GetCollection<login>(Conn.ColletionLogin);
            
            var usuario = colecaoLogin.Find(l => l.user == user && l.senha == senha).FirstOrDefault();

            return usuario != null;
        }
    }
    }
    


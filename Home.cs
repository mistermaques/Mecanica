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
    public partial class fundomenu : Form
    {
        
        


        public fundomenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
       
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 46)
                {
                    menuExpand = false;
                    menuTransition.Stop();

                }
            }
            else
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 138)
                {
                    menuExpand = true;
                    menuTransition.Stop();

                }

            }

        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 52)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    menuContainer.Width = sidebar.Width;
                    pnbtn2.Width = sidebar.Width;
                    pnbtn3.Width = sidebar.Width;
                    pnbtn4.Width = sidebar.Width;
                    pnbtn5.Width = sidebar.Width;
                    pnbtn6.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 265)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    menuContainer.Width = sidebar.Width;
                    pnbtn2.Width = sidebar.Width;
                    pnbtn3.Width = sidebar.Width;
                    pnbtn4.Width = sidebar.Width;
                    pnbtn5.Width = sidebar.Width;
                    pnbtn6.Width = sidebar.Width;

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            // Cria e configura o formulário que você deseja abrir
            cadastrocliente form = new cadastrocliente();
            form.TopLevel = false; // Indica que o formulário será embutido
            form.FormBorderStyle = FormBorderStyle.None; // Remove as bordas do formulário
            form.Dock = DockStyle.Fill;

            // Adiciona o formulário no Panel
            panel2.Controls.Add(form);
            form.Show(); // Exibe o formulário

        }
    }

}

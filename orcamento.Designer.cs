namespace Mecanica
{
    partial class orcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gerarpdf = new System.Windows.Forms.Button();
            this.btnaprovar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBoxDetalhesServicos = new System.Windows.Forms.ListBox();
            this.comboBoxServicos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.comboBoxVeiculos = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gerarpdf);
            this.panel1.Controls.Add(this.btnaprovar);
            this.panel1.Controls.Add(this.btnsalvar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.listBoxDetalhesServicos);
            this.panel1.Controls.Add(this.comboBoxServicos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNomeCliente);
            this.panel1.Controls.Add(this.comboBoxVeiculos);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 486);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gerarpdf
            // 
            this.gerarpdf.Location = new System.Drawing.Point(348, 419);
            this.gerarpdf.Name = "gerarpdf";
            this.gerarpdf.Size = new System.Drawing.Size(75, 23);
            this.gerarpdf.TabIndex = 13;
            this.gerarpdf.Text = "gerar pdf";
            this.gerarpdf.UseVisualStyleBackColor = true;
            this.gerarpdf.Click += new System.EventHandler(this.gerarpdf_Click);
            // 
            // btnaprovar
            // 
            this.btnaprovar.Location = new System.Drawing.Point(218, 429);
            this.btnaprovar.Name = "btnaprovar";
            this.btnaprovar.Size = new System.Drawing.Size(75, 23);
            this.btnaprovar.TabIndex = 12;
            this.btnaprovar.Text = "aprovado";
            this.btnaprovar.UseVisualStyleBackColor = true;
            this.btnaprovar.Click += new System.EventHandler(this.btnaprovar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(97, 429);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Observações";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(523, 285);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 157);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // listBoxDetalhesServicos
            // 
            this.listBoxDetalhesServicos.FormattingEnabled = true;
            this.listBoxDetalhesServicos.Location = new System.Drawing.Point(523, 106);
            this.listBoxDetalhesServicos.Name = "listBoxDetalhesServicos";
            this.listBoxDetalhesServicos.Size = new System.Drawing.Size(276, 160);
            this.listBoxDetalhesServicos.TabIndex = 8;
            // 
            // comboBoxServicos
            // 
            this.comboBoxServicos.FormattingEnabled = true;
            this.comboBoxServicos.Location = new System.Drawing.Point(523, 52);
            this.comboBoxServicos.Name = "comboBoxServicos";
            this.comboBoxServicos.Size = new System.Drawing.Size(222, 21);
            this.comboBoxServicos.TabIndex = 7;
            this.comboBoxServicos.SelectedIndexChanged += new System.EventHandler(this.comboBoxServicos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Veiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(131, 104);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(37, 13);
            this.lblNomeCliente.TabIndex = 4;
            this.lblNomeCliente.Text = "----------";
            // 
            // comboBoxVeiculos
            // 
            this.comboBoxVeiculos.FormattingEnabled = true;
            this.comboBoxVeiculos.Location = new System.Drawing.Point(97, 129);
            this.comboBoxVeiculos.Name = "comboBoxVeiculos";
            this.comboBoxVeiculos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVeiculos.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(97, 49);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "cpf";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "numero do orçamento   que estão ammarados no banco de dados ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 486);
            this.Controls.Add(this.panel1);
            this.Name = "orcamento";
            this.Text = "orcamento";
            this.Load += new System.EventHandler(this.orcamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxVeiculos;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxServicos;
        private System.Windows.Forms.ListBox listBoxDetalhesServicos;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnaprovar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button gerarpdf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
namespace Mecanica
{
    partial class cadfuncionario
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
            this.cadnome = new System.Windows.Forms.TextBox();
            this.cadsenha = new System.Windows.Forms.TextBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadnome
            // 
            this.cadnome.Location = new System.Drawing.Point(307, 131);
            this.cadnome.Name = "cadnome";
            this.cadnome.Size = new System.Drawing.Size(100, 20);
            this.cadnome.TabIndex = 0;
            // 
            // cadsenha
            // 
            this.cadsenha.Location = new System.Drawing.Point(307, 170);
            this.cadsenha.Name = "cadsenha";
            this.cadsenha.Size = new System.Drawing.Size(100, 20);
            this.cadsenha.TabIndex = 1;
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(423, 287);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 2;
            this.cadastrar.Text = "cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // cadfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.cadsenha);
            this.Controls.Add(this.cadnome);
            this.Name = "cadfuncionario";
            this.Text = "cadastrodefuncionarios";
            this.Load += new System.EventHandler(this.cadfuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cadnome;
        private System.Windows.Forms.TextBox cadsenha;
        private System.Windows.Forms.Button cadastrar;
    }
}
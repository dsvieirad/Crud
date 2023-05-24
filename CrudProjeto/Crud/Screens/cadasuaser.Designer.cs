namespace Crud
{
    partial class cadasuaser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadasuaser));
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelFazerCadas = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCadastrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(354, 584);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(221, 44);
            this.buttonCadastrar.TabIndex = 27;
            this.buttonCadastrar.Text = "Fazer Cadastro";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(325, 359);
            this.textBoxEmail.MaxLength = 40;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(326, 26);
            this.textBoxEmail.TabIndex = 25;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(325, 233);
            this.textBoxNome.MaxLength = 327;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(326, 26);
            this.textBoxNome.TabIndex = 24;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(158, 472);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(60, 22);
            this.labelSenha.TabIndex = 22;
            this.labelSenha.Text = "Senha";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(158, 359);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 22);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "Email";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(158, 233);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(58, 22);
            this.labelNome.TabIndex = 20;
            this.labelNome.Text = "Nome";
            // 
            // labelFazerCadas
            // 
            this.labelFazerCadas.AutoSize = true;
            this.labelFazerCadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelFazerCadas.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFazerCadas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFazerCadas.Location = new System.Drawing.Point(168, 86);
            this.labelFazerCadas.Name = "labelFazerCadas";
            this.labelFazerCadas.Size = new System.Drawing.Size(527, 55);
            this.labelFazerCadas.TabIndex = 19;
            this.labelFazerCadas.Text = "Faça seu Cadastro Aqui!";
            this.labelFazerCadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(325, 472);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(326, 26);
            this.maskedTextBox1.TabIndex = 29;
            // 
            // cadasuaser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(904, 688);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelFazerCadas);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cadasuaser";
            this.Text = "cadasuaser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelFazerCadas;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}
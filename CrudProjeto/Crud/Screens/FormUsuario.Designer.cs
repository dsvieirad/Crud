namespace Crud
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelFazerCadas = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1717, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 1099);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.buttonMenu);
            this.panel2.Location = new System.Drawing.Point(0, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 1087);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(17, 442);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(210, 44);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 565);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(210, 43);
            this.buttonMenu.TabIndex = 16;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelUser.Location = new System.Drawing.Point(79, -1);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(234, 73);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Usuário";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFazerCadas
            // 
            this.labelFazerCadas.AutoSize = true;
            this.labelFazerCadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelFazerCadas.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFazerCadas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFazerCadas.Location = new System.Drawing.Point(1090, 154);
            this.labelFazerCadas.Name = "labelFazerCadas";
            this.labelFazerCadas.Size = new System.Drawing.Size(527, 55);
            this.labelFazerCadas.TabIndex = 3;
            this.labelFazerCadas.Text = "Faça seu Cadastro Aqui!";
            this.labelFazerCadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(1099, 279);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(58, 22);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(1099, 372);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 22);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(1099, 462);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(60, 22);
            this.labelSenha.TabIndex = 7;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(1266, 279);
            this.textBoxNome.MaxLength = 327;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(326, 26);
            this.textBoxNome.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(1266, 372);
            this.textBoxEmail.MaxLength = 40;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(326, 26);
            this.textBoxEmail.TabIndex = 11;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCadastrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(304, 696);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(221, 44);
            this.buttonCadastrar.TabIndex = 14;
            this.buttonCadastrar.Text = "Fazer Cadastro";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtualizar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(870, 696);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(221, 44);
            this.buttonAtualizar.TabIndex = 15;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletar.Location = new System.Drawing.Point(1388, 696);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(221, 44);
            this.buttonDeletar.TabIndex = 16;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = false;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonCancelar_Click_1);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.GridColor = System.Drawing.Color.Salmon;
            this.dataGridViewUser.Location = new System.Drawing.Point(347, 336);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(506, 291);
            this.dataGridViewUser.TabIndex = 19;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(342, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuários:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1099, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo de Usuário";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(1266, 461);
            this.textBoxSenha.MaxLength = 40;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(326, 26);
            this.textBoxSenha.TabIndex = 22;
            this.textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1266, 537);
            this.textBox1.MaxLength = 40;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 26);
            this.textBox1.TabIndex = 23;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelFazerCadas);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelFazerCadas;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBox1;
    }
}
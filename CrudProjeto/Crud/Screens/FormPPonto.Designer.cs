namespace Crud
{
    partial class FormPPonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPPonto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPorta = new System.Windows.Forms.Label();
            this.labelNopo = new System.Windows.Forms.Label();
            this.labelTiPo = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPorta = new System.Windows.Forms.TextBox();
            this.textBoxNoDPon = new System.Windows.Forms.TextBox();
            this.buttonFazerCadas = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.labelVerPontos = new System.Windows.Forms.Label();
            this.labelPonto = new System.Windows.Forms.Label();
            this.PontodataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PontodataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1721, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 1079);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.buttonMenu);
            this.panel2.Location = new System.Drawing.Point(-4, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 1079);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(25, 517);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(184, 45);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(1143, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro De Ponto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(1111, 337);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(29, 22);
            this.labelIP.TabIndex = 4;
            this.labelIP.Text = "IP";
            this.labelIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPorta
            // 
            this.labelPorta.AutoSize = true;
            this.labelPorta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorta.Location = new System.Drawing.Point(1111, 415);
            this.labelPorta.Name = "labelPorta";
            this.labelPorta.Size = new System.Drawing.Size(56, 22);
            this.labelPorta.TabIndex = 5;
            this.labelPorta.Text = "Porta";
            this.labelPorta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNopo
            // 
            this.labelNopo.AutoSize = true;
            this.labelNopo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNopo.Location = new System.Drawing.Point(1111, 501);
            this.labelNopo.Name = "labelNopo";
            this.labelNopo.Size = new System.Drawing.Size(136, 22);
            this.labelNopo.TabIndex = 6;
            this.labelNopo.Text = "Nome do Ponto";
            this.labelNopo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTiPo
            // 
            this.labelTiPo.AutoSize = true;
            this.labelTiPo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiPo.Location = new System.Drawing.Point(1111, 592);
            this.labelTiPo.Name = "labelTiPo";
            this.labelTiPo.Size = new System.Drawing.Size(126, 22);
            this.labelTiPo.TabIndex = 7;
            this.labelTiPo.Text = "Tipo do Ponto";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIP.Location = new System.Drawing.Point(1284, 333);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(353, 26);
            this.textBoxIP.TabIndex = 9;
            // 
            // textBoxPorta
            // 
            this.textBoxPorta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPorta.Location = new System.Drawing.Point(1273, 418);
            this.textBoxPorta.Name = "textBoxPorta";
            this.textBoxPorta.Size = new System.Drawing.Size(353, 26);
            this.textBoxPorta.TabIndex = 10;
            // 
            // textBoxNoDPon
            // 
            this.textBoxNoDPon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoDPon.Location = new System.Drawing.Point(1273, 501);
            this.textBoxNoDPon.Name = "textBoxNoDPon";
            this.textBoxNoDPon.Size = new System.Drawing.Size(353, 26);
            this.textBoxNoDPon.TabIndex = 11;
            // 
            // buttonFazerCadas
            // 
            this.buttonFazerCadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFazerCadas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonFazerCadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFazerCadas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFazerCadas.Location = new System.Drawing.Point(664, 726);
            this.buttonFazerCadas.Name = "buttonFazerCadas";
            this.buttonFazerCadas.Size = new System.Drawing.Size(184, 51);
            this.buttonFazerCadas.TabIndex = 13;
            this.buttonFazerCadas.Text = "Fazer Cadastro";
            this.buttonFazerCadas.UseVisualStyleBackColor = false;
            this.buttonFazerCadas.Click += new System.EventHandler(this.buttonFazerCadas_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLimpar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLimpar.Location = new System.Drawing.Point(335, 726);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(184, 55);
            this.buttonLimpar.TabIndex = 14;
            this.buttonLimpar.Text = "Limpar Campos";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(1284, 592);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(353, 26);
            this.txtTipo.TabIndex = 16;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(983, 726);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(184, 55);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(1330, 726);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(184, 55);
            this.btnDeletar.TabIndex = 18;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(25, 397);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(184, 46);
            this.buttonMenu.TabIndex = 13;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelPesquisar.Location = new System.Drawing.Point(319, 265);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(103, 31);
            this.labelPesquisar.TabIndex = 20;
            this.labelPesquisar.Text = "Pontos:";
            // 
            // labelVerPontos
            // 
            this.labelVerPontos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVerPontos.AutoSize = true;
            this.labelVerPontos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVerPontos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelVerPontos.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerPontos.Location = new System.Drawing.Point(463, 102);
            this.labelVerPontos.Name = "labelVerPontos";
            this.labelVerPontos.Size = new System.Drawing.Size(302, 55);
            this.labelVerPontos.TabIndex = 19;
            this.labelVerPontos.Text = "Pontos Ativos";
            this.labelVerPontos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPonto
            // 
            this.labelPonto.AutoSize = true;
            this.labelPonto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPonto.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPonto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPonto.Location = new System.Drawing.Point(129, 1);
            this.labelPonto.Name = "labelPonto";
            this.labelPonto.Size = new System.Drawing.Size(182, 73);
            this.labelPonto.TabIndex = 3;
            this.labelPonto.Text = "Ponto";
            this.labelPonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PontodataGridView1
            // 
            this.PontodataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PontodataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PontodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PontodataGridView1.GridColor = System.Drawing.Color.Salmon;
            this.PontodataGridView1.Location = new System.Drawing.Point(313, 333);
            this.PontodataGridView1.Name = "PontodataGridView1";
            this.PontodataGridView1.Size = new System.Drawing.Size(545, 285);
            this.PontodataGridView1.TabIndex = 24;
            this.PontodataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PontodataGridView1_CellContentClick);
            // 
            // FormPPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.PontodataGridView1);
            this.Controls.Add(this.labelPonto);
            this.Controls.Add(this.labelPesquisar);
            this.Controls.Add(this.labelVerPontos);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonFazerCadas);
            this.Controls.Add(this.textBoxNoDPon);
            this.Controls.Add(this.textBoxPorta);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelTiPo);
            this.Controls.Add(this.labelNopo);
            this.Controls.Add(this.labelPorta);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPPonto";
            this.Text = "Ponto";
            this.Load += new System.EventHandler(this.FormCadasPonto_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PontodataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPorta;
        private System.Windows.Forms.Label labelNopo;
        private System.Windows.Forms.Label labelTiPo;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPorta;
        private System.Windows.Forms.TextBox textBoxNoDPon;
        private System.Windows.Forms.Button buttonFazerCadas;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelPesquisar;
        private System.Windows.Forms.Label labelVerPontos;
        private System.Windows.Forms.Label labelPonto;
        private System.Windows.Forms.DataGridView PontodataGridView1;
        private System.Windows.Forms.Button btnSair;
    }
}
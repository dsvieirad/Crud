namespace Crud
{
    partial class FormLeitura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLeitura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnVazao = new System.Windows.Forms.Button();
            this.btnBomba = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1717, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 1078);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonSair);
            this.panel2.Location = new System.Drawing.Point(-8, -27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 1143);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(131, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leitura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(716, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 73);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tela de Leitura";
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(38, 516);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(184, 44);
            this.buttonSair.TabIndex = 8;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(1505, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnPonto
            // 
            this.btnPonto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPonto.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonto.Location = new System.Drawing.Point(1405, 415);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(232, 54);
            this.btnPonto.TabIndex = 17;
            this.btnPonto.Text = "Ponto";
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnVazao
            // 
            this.btnVazao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVazao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVazao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVazao.Location = new System.Drawing.Point(891, 415);
            this.btnVazao.Name = "btnVazao";
            this.btnVazao.Size = new System.Drawing.Size(232, 54);
            this.btnVazao.TabIndex = 18;
            this.btnVazao.Text = "Vazão";
            this.btnVazao.UseVisualStyleBackColor = false;
            this.btnVazao.Click += new System.EventHandler(this.btnVazao_Click);
            // 
            // btnBomba
            // 
            this.btnBomba.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBomba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBomba.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBomba.Location = new System.Drawing.Point(383, 415);
            this.btnBomba.Name = "btnBomba";
            this.btnBomba.Size = new System.Drawing.Size(232, 54);
            this.btnBomba.TabIndex = 19;
            this.btnBomba.Text = "Bomba";
            this.btnBomba.UseVisualStyleBackColor = false;
            this.btnBomba.Click += new System.EventHandler(this.btnBomba_Click);
            // 
            // FormLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.btnBomba);
            this.Controls.Add(this.btnVazao);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLeitura";
            this.Text = "Leitura";
            this.Load += new System.EventHandler(this.FormLeitura_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnVazao;
        private System.Windows.Forms.Button btnBomba;
    }
}
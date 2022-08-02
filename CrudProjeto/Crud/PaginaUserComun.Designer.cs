namespace Crud
{
    partial class PaginaUserComun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaUserComun));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPonto = new System.Windows.Forms.Button();
            this.buttonLeitura = new System.Windows.Forms.Button();
            this.buttonAlarme = new System.Windows.Forms.Button();
            this.labelPP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1708, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 1064);
            this.panel1.TabIndex = 8;
            // 
            // buttonPonto
            // 
            this.buttonPonto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonPonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPonto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPonto.Location = new System.Drawing.Point(337, 207);
            this.buttonPonto.Name = "buttonPonto";
            this.buttonPonto.Size = new System.Drawing.Size(175, 56);
            this.buttonPonto.TabIndex = 10;
            this.buttonPonto.Text = "Ponto";
            this.buttonPonto.UseVisualStyleBackColor = false;
            this.buttonPonto.Click += new System.EventHandler(this.buttonPonto_Click);
            // 
            // buttonLeitura
            // 
            this.buttonLeitura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLeitura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeitura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeitura.Location = new System.Drawing.Point(1398, 207);
            this.buttonLeitura.Name = "buttonLeitura";
            this.buttonLeitura.Size = new System.Drawing.Size(175, 56);
            this.buttonLeitura.TabIndex = 11;
            this.buttonLeitura.Text = "Leitura";
            this.buttonLeitura.UseVisualStyleBackColor = false;
            this.buttonLeitura.Click += new System.EventHandler(this.buttonLeitura_Click);
            // 
            // buttonAlarme
            // 
            this.buttonAlarme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAlarme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlarme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlarme.Location = new System.Drawing.Point(795, 194);
            this.buttonAlarme.Name = "buttonAlarme";
            this.buttonAlarme.Size = new System.Drawing.Size(175, 56);
            this.buttonAlarme.TabIndex = 12;
            this.buttonAlarme.Text = "Alarme";
            this.buttonAlarme.UseVisualStyleBackColor = false;
            this.buttonAlarme.Click += new System.EventHandler(this.buttonAlarme_Click);
            // 
            // labelPP
            // 
            this.labelPP.AutoSize = true;
            this.labelPP.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPP.Location = new System.Drawing.Point(104, -2);
            this.labelPP.Name = "labelPP";
            this.labelPP.Size = new System.Drawing.Size(452, 73);
            this.labelPP.TabIndex = 9;
            this.labelPP.Text = "Página Principal";
            this.labelPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Location = new System.Drawing.Point(-15, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1108);
            this.panel2.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(70, 502);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(175, 56);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // PaginaUserComun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1915, 1061);
            this.Controls.Add(this.labelPP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonAlarme);
            this.Controls.Add(this.buttonLeitura);
            this.Controls.Add(this.buttonPonto);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaUserComun";
            this.Text = "Pagina Principal";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPonto;
        private System.Windows.Forms.Button buttonLeitura;
        private System.Windows.Forms.Button buttonAlarme;
        private System.Windows.Forms.Label labelPP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
    }
}
namespace Crud
{
    partial class FormPaginaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaginaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPP = new System.Windows.Forms.Label();
            this.buttonPonto = new System.Windows.Forms.Button();
            this.buttonLeitura = new System.Windows.Forms.Button();
            this.buttonAlarme = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.buttonSair = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1719, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 1064);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-1, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 1064);
            this.panel2.TabIndex = 1;
            // 
            // labelPP
            // 
            this.labelPP.AutoSize = true;
            this.labelPP.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPP.Location = new System.Drawing.Point(128, 25);
            this.labelPP.Name = "labelPP";
            this.labelPP.Size = new System.Drawing.Size(452, 73);
            this.labelPP.TabIndex = 2;
            this.labelPP.Text = "Página Principal";
            this.labelPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPonto
            // 
            this.buttonPonto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonPonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPonto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPonto.Location = new System.Drawing.Point(348, 205);
            this.buttonPonto.Name = "buttonPonto";
            this.buttonPonto.Size = new System.Drawing.Size(175, 56);
            this.buttonPonto.TabIndex = 3;
            this.buttonPonto.Text = "Ponto";
            this.buttonPonto.UseVisualStyleBackColor = false;
            this.buttonPonto.Click += new System.EventHandler(this.buttonPonto_Click);
            // 
            // buttonLeitura
            // 
            this.buttonLeitura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLeitura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeitura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeitura.Location = new System.Drawing.Point(1409, 205);
            this.buttonLeitura.Name = "buttonLeitura";
            this.buttonLeitura.Size = new System.Drawing.Size(175, 56);
            this.buttonLeitura.TabIndex = 4;
            this.buttonLeitura.Text = "Leitura";
            this.buttonLeitura.UseVisualStyleBackColor = false;
            this.buttonLeitura.Click += new System.EventHandler(this.buttonLeitura_Click);
            // 
            // buttonAlarme
            // 
            this.buttonAlarme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAlarme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlarme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlarme.Location = new System.Drawing.Point(1040, 205);
            this.buttonAlarme.Name = "buttonAlarme";
            this.buttonAlarme.Size = new System.Drawing.Size(175, 56);
            this.buttonAlarme.TabIndex = 5;
            this.buttonAlarme.Text = "Alarme";
            this.buttonAlarme.UseVisualStyleBackColor = false;
            this.buttonAlarme.Click += new System.EventHandler(this.buttonAlarme_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.Location = new System.Drawing.Point(678, 205);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(175, 56);
            this.buttonUser.TabIndex = 6;
            this.buttonUser.Text = "Usuário";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1924, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(1486, 878);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(227, 62);
            this.buttonSair.TabIndex = 8;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.labelPP);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonAlarme);
            this.Controls.Add(this.buttonLeitura);
            this.Controls.Add(this.buttonPonto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPaginaPrincipal";
            this.Text = "Pagina Principal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPP;
        private System.Windows.Forms.Button buttonPonto;
        private System.Windows.Forms.Button buttonLeitura;
        private System.Windows.Forms.Button buttonAlarme;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button buttonSair;
    }
}
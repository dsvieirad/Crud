namespace Crud
{
    partial class FormAlarme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlarme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAlarme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnNivel = new System.Windows.Forms.Button();
            this.btnBomba = new System.Windows.Forms.Button();
            this.btnPon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Location = new System.Drawing.Point(-2, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 1072);
            this.panel1.TabIndex = 0;
            // 
            // buttonMenu
            // 
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(15, 396);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(204, 48);
            this.buttonMenu.TabIndex = 6;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(1717, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 1072);
            this.panel2.TabIndex = 1;
            // 
            // labelAlarme
            // 
            this.labelAlarme.AutoSize = true;
            this.labelAlarme.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarme.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAlarme.Location = new System.Drawing.Point(90, -8);
            this.labelAlarme.Name = "labelAlarme";
            this.labelAlarme.Size = new System.Drawing.Size(220, 73);
            this.labelAlarme.TabIndex = 2;
            this.labelAlarme.Text = "Alarme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(751, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controle de Alarmes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(15, 488);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(204, 47);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1039);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1924, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnNivel
            // 
            this.btnNivel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNivel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivel.Location = new System.Drawing.Point(424, 364);
            this.btnNivel.Name = "btnNivel";
            this.btnNivel.Size = new System.Drawing.Size(267, 62);
            this.btnNivel.TabIndex = 15;
            this.btnNivel.Text = "Nível";
            this.btnNivel.UseVisualStyleBackColor = false;
            this.btnNivel.Click += new System.EventHandler(this.btnNivel_Click);
            // 
            // btnBomba
            // 
            this.btnBomba.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBomba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBomba.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBomba.Location = new System.Drawing.Point(851, 364);
            this.btnBomba.Name = "btnBomba";
            this.btnBomba.Size = new System.Drawing.Size(267, 62);
            this.btnBomba.TabIndex = 16;
            this.btnBomba.Text = "Bomba";
            this.btnBomba.UseVisualStyleBackColor = false;
            this.btnBomba.Click += new System.EventHandler(this.btnBomba_Click);
            // 
            // btnPon
            // 
            this.btnPon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPon.Location = new System.Drawing.Point(1281, 364);
            this.btnPon.Name = "btnPon";
            this.btnPon.Size = new System.Drawing.Size(267, 62);
            this.btnPon.TabIndex = 17;
            this.btnPon.Text = "Ponto";
            this.btnPon.UseVisualStyleBackColor = false;
            this.btnPon.Click += new System.EventHandler(this.btnPon_Click);
            // 
            // FormAlarme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.btnPon);
            this.Controls.Add(this.btnBomba);
            this.Controls.Add(this.btnNivel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAlarme);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlarme";
            this.Text = "Página Alarme";
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAlarme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnNivel;
        private System.Windows.Forms.Button btnBomba;
        private System.Windows.Forms.Button btnPon;
    }
}
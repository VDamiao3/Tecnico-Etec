namespace empres_de_pintura
{
    partial class Gerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerente));
            this.cadFunc = new System.Windows.Forms.Button();
            this.AltCad = new System.Windows.Forms.Button();
            this.CalcCom = new System.Windows.Forms.Button();
            this.serv = new System.Windows.Forms.Button();
            this.cadCli = new System.Windows.Forms.Button();
            this.altCli = new System.Windows.Forms.Button();
            this.Deslogar = new System.Windows.Forms.Button();
            this.RemCad = new System.Windows.Forms.Button();
            this.RemCli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadFunc
            // 
            this.cadFunc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadFunc.Location = new System.Drawing.Point(12, 53);
            this.cadFunc.Name = "cadFunc";
            this.cadFunc.Size = new System.Drawing.Size(118, 56);
            this.cadFunc.TabIndex = 0;
            this.cadFunc.Text = "Cadastrar Funcionário";
            this.cadFunc.UseVisualStyleBackColor = false;
            this.cadFunc.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltCad
            // 
            this.AltCad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AltCad.Location = new System.Drawing.Point(267, 53);
            this.AltCad.Name = "AltCad";
            this.AltCad.Size = new System.Drawing.Size(127, 56);
            this.AltCad.TabIndex = 1;
            this.AltCad.Text = "Alterar Cadastro";
            this.AltCad.UseVisualStyleBackColor = false;
            // 
            // CalcCom
            // 
            this.CalcCom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalcCom.Location = new System.Drawing.Point(12, 132);
            this.CalcCom.Name = "CalcCom";
            this.CalcCom.Size = new System.Drawing.Size(118, 59);
            this.CalcCom.TabIndex = 2;
            this.CalcCom.Text = "Calcular Comissão ";
            this.CalcCom.UseVisualStyleBackColor = false;
            // 
            // serv
            // 
            this.serv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serv.Location = new System.Drawing.Point(136, 132);
            this.serv.Name = "serv";
            this.serv.Size = new System.Drawing.Size(125, 59);
            this.serv.TabIndex = 3;
            this.serv.Text = "Serviços";
            this.serv.UseVisualStyleBackColor = false;
            this.serv.Click += new System.EventHandler(this.button4_Click);
            // 
            // cadCli
            // 
            this.cadCli.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadCli.Location = new System.Drawing.Point(136, 53);
            this.cadCli.Name = "cadCli";
            this.cadCli.Size = new System.Drawing.Size(125, 56);
            this.cadCli.TabIndex = 4;
            this.cadCli.Text = "Cadastrar Cliente";
            this.cadCli.UseVisualStyleBackColor = false;
            this.cadCli.Click += new System.EventHandler(this.button5_Click);
            // 
            // altCli
            // 
            this.altCli.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.altCli.Location = new System.Drawing.Point(267, 132);
            this.altCli.Name = "altCli";
            this.altCli.Size = new System.Drawing.Size(125, 59);
            this.altCli.TabIndex = 5;
            this.altCli.Text = "Alterar Cliente";
            this.altCli.UseVisualStyleBackColor = false;
            // 
            // Deslogar
            // 
            this.Deslogar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Deslogar.Location = new System.Drawing.Point(452, -2);
            this.Deslogar.Name = "Deslogar";
            this.Deslogar.Size = new System.Drawing.Size(75, 23);
            this.Deslogar.TabIndex = 6;
            this.Deslogar.Text = "Deslogar";
            this.Deslogar.UseVisualStyleBackColor = false;
            this.Deslogar.Click += new System.EventHandler(this.Deslogar_Click);
            // 
            // RemCad
            // 
            this.RemCad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemCad.Location = new System.Drawing.Point(400, 53);
            this.RemCad.Name = "RemCad";
            this.RemCad.Size = new System.Drawing.Size(127, 56);
            this.RemCad.TabIndex = 7;
            this.RemCad.Text = "Remover Cadasro";
            this.RemCad.UseVisualStyleBackColor = false;
            // 
            // RemCli
            // 
            this.RemCli.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemCli.Location = new System.Drawing.Point(400, 132);
            this.RemCli.Name = "RemCli";
            this.RemCli.Size = new System.Drawing.Size(127, 59);
            this.RemCli.TabIndex = 8;
            this.RemCli.Text = "Remover Cliente";
            this.RemCli.UseVisualStyleBackColor = false;
            this.RemCli.Click += new System.EventHandler(this.RemCli_Click);
            // 
            // Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 243);
            this.Controls.Add(this.RemCli);
            this.Controls.Add(this.RemCad);
            this.Controls.Add(this.Deslogar);
            this.Controls.Add(this.altCli);
            this.Controls.Add(this.cadCli);
            this.Controls.Add(this.serv);
            this.Controls.Add(this.CalcCom);
            this.Controls.Add(this.AltCad);
            this.Controls.Add(this.cadFunc);
            this.Name = "Gerente";
            this.Text = "Gerente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gerentesair);
            this.Load += new System.EventHandler(this.Gerente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadFunc;
        private System.Windows.Forms.Button AltCad;
        private System.Windows.Forms.Button CalcCom;
        private System.Windows.Forms.Button serv;
        private System.Windows.Forms.Button cadCli;
        private System.Windows.Forms.Button altCli;
        private System.Windows.Forms.Button Deslogar;
        private System.Windows.Forms.Button RemCad;
        private System.Windows.Forms.Button RemCli;
    }
}
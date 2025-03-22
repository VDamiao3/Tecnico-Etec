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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Deslogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar Funcionário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Alterar/Remover Cadastro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "Calcular Comissão ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 77);
            this.button4.TabIndex = 3;
            this.button4.Text = "Serviços";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cadastrar Cliente";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(269, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 77);
            this.button6.TabIndex = 5;
            this.button6.Text = "Alterar/Remover Cliente";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Deslogar
            // 
            this.Deslogar.Location = new System.Drawing.Point(319, 13);
            this.Deslogar.Name = "Deslogar";
            this.Deslogar.Size = new System.Drawing.Size(75, 23);
            this.Deslogar.TabIndex = 6;
            this.Deslogar.Text = "Deslogar";
            this.Deslogar.UseVisualStyleBackColor = true;
            this.Deslogar.Click += new System.EventHandler(this.Deslogar_Click);
            // 
            // Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 233);
            this.Controls.Add(this.Deslogar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Gerente";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gerentesair);
            this.Load += new System.EventHandler(this.Gerente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Deslogar;
    }
}
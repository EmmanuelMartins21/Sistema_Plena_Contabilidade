
namespace Sistema_Plena_Contabilidade
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonPessoal = new System.Windows.Forms.Button();
            this.buttonPlena = new System.Windows.Forms.Button();
            this.buttonSSVP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(74, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(424, 32);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Sistema para otimização de processos";
            // 
            // buttonPessoal
            // 
            this.buttonPessoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPessoal.Location = new System.Drawing.Point(12, 142);
            this.buttonPessoal.Name = "buttonPessoal";
            this.buttonPessoal.Size = new System.Drawing.Size(170, 58);
            this.buttonPessoal.TabIndex = 1;
            this.buttonPessoal.Text = "Pessoal";
            this.buttonPessoal.UseVisualStyleBackColor = true;
            this.buttonPessoal.Click += new System.EventHandler(this.buttonPessoal_Click);
            // 
            // buttonPlena
            // 
            this.buttonPlena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlena.Location = new System.Drawing.Point(185, 142);
            this.buttonPlena.Name = "buttonPlena";
            this.buttonPlena.Size = new System.Drawing.Size(170, 58);
            this.buttonPlena.TabIndex = 2;
            this.buttonPlena.Text = "Plena Contabilidade";
            this.buttonPlena.UseVisualStyleBackColor = true;
            this.buttonPlena.Click += new System.EventHandler(this.buttonPlena_Click);
            // 
            // buttonSSVP
            // 
            this.buttonSSVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSSVP.Location = new System.Drawing.Point(361, 142);
            this.buttonSSVP.Name = "buttonSSVP";
            this.buttonSSVP.Size = new System.Drawing.Size(170, 58);
            this.buttonSSVP.TabIndex = 3;
            this.buttonSSVP.Text = "SSVP";
            this.buttonSSVP.UseVisualStyleBackColor = true;
            this.buttonSSVP.Click += new System.EventHandler(this.buttonSSVP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 337);
            this.Controls.Add(this.buttonSSVP);
            this.Controls.Add(this.buttonPessoal);
            this.Controls.Add(this.buttonPlena);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.Text = "Sistema de Simplificação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonPessoal;
        private System.Windows.Forms.Button buttonPlena;
        private System.Windows.Forms.Button buttonSSVP;
    }
}


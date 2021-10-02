
namespace Sistema_Plena_Contabilidade
{
    partial class FormPlena
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCCMEI = new System.Windows.Forms.Button();
            this.buttonOcupacaoMEI = new System.Windows.Forms.Button();
            this.buttonMEI = new System.Windows.Forms.Button();
            this.buttonRelacaoClientes = new System.Windows.Forms.Button();
            this.buttonDASN = new System.Windows.Forms.Button();
            this.buttonGuiaDas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(74, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(424, 32);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "Sistema para otimização de processos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCCMEI);
            this.panel1.Controls.Add(this.buttonOcupacaoMEI);
            this.panel1.Controls.Add(this.buttonMEI);
            this.panel1.Controls.Add(this.buttonRelacaoClientes);
            this.panel1.Controls.Add(this.buttonDASN);
            this.panel1.Controls.Add(this.buttonGuiaDas);
            this.panel1.Location = new System.Drawing.Point(23, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 187);
            this.panel1.TabIndex = 8;
            // 
            // buttonCCMEI
            // 
            this.buttonCCMEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCCMEI.Location = new System.Drawing.Point(352, 84);
            this.buttonCCMEI.Name = "buttonCCMEI";
            this.buttonCCMEI.Size = new System.Drawing.Size(170, 78);
            this.buttonCCMEI.TabIndex = 6;
            this.buttonCCMEI.Text = "Consulta CCMEI";
            this.buttonCCMEI.UseVisualStyleBackColor = true;
            this.buttonCCMEI.Click += new System.EventHandler(this.buttonCCMEI_Click);
            // 
            // buttonOcupacaoMEI
            // 
            this.buttonOcupacaoMEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOcupacaoMEI.Location = new System.Drawing.Point(176, 83);
            this.buttonOcupacaoMEI.Name = "buttonOcupacaoMEI";
            this.buttonOcupacaoMEI.Size = new System.Drawing.Size(170, 81);
            this.buttonOcupacaoMEI.TabIndex = 5;
            this.buttonOcupacaoMEI.Text = "Ocupações permitidas no MEI";
            this.buttonOcupacaoMEI.UseVisualStyleBackColor = true;
            this.buttonOcupacaoMEI.Click += new System.EventHandler(this.buttonOcupacaoMEI_Click);
            // 
            // buttonMEI
            // 
            this.buttonMEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMEI.Location = new System.Drawing.Point(3, 83);
            this.buttonMEI.Name = "buttonMEI";
            this.buttonMEI.Size = new System.Drawing.Size(170, 78);
            this.buttonMEI.TabIndex = 4;
            this.buttonMEI.Text = "Abertura de MEI";
            this.buttonMEI.UseVisualStyleBackColor = true;
            this.buttonMEI.Click += new System.EventHandler(this.buttonMEI_Click);
            // 
            // buttonRelacaoClientes
            // 
            this.buttonRelacaoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRelacaoClientes.Location = new System.Drawing.Point(3, 3);
            this.buttonRelacaoClientes.Name = "buttonRelacaoClientes";
            this.buttonRelacaoClientes.Size = new System.Drawing.Size(170, 74);
            this.buttonRelacaoClientes.TabIndex = 1;
            this.buttonRelacaoClientes.Text = "Relação de Clientes";
            this.buttonRelacaoClientes.UseVisualStyleBackColor = true;
            this.buttonRelacaoClientes.Click += new System.EventHandler(this.buttonRelacaoClientes_Click);
            // 
            // buttonDASN
            // 
            this.buttonDASN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDASN.Location = new System.Drawing.Point(352, 3);
            this.buttonDASN.Name = "buttonDASN";
            this.buttonDASN.Size = new System.Drawing.Size(170, 75);
            this.buttonDASN.TabIndex = 3;
            this.buttonDASN.Text = "Emitir DASN SIMEI";
            this.buttonDASN.UseVisualStyleBackColor = true;
            this.buttonDASN.Click += new System.EventHandler(this.buttonDASN_Click);
            // 
            // buttonGuiaDas
            // 
            this.buttonGuiaDas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuiaDas.Location = new System.Drawing.Point(176, 3);
            this.buttonGuiaDas.Name = "buttonGuiaDas";
            this.buttonGuiaDas.Size = new System.Drawing.Size(170, 74);
            this.buttonGuiaDas.TabIndex = 2;
            this.buttonGuiaDas.Text = "Emitir DAS";
            this.buttonGuiaDas.UseVisualStyleBackColor = true;
            this.buttonGuiaDas.Click += new System.EventHandler(this.buttonPlena_Click);
            // 
            // FormPlena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(574, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormPlena";
            this.Text = "Pagina Plena";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCCMEI;
        private System.Windows.Forms.Button buttonOcupacaoMEI;
        private System.Windows.Forms.Button buttonMEI;
        private System.Windows.Forms.Button buttonRelacaoClientes;
        private System.Windows.Forms.Button buttonDASN;
        private System.Windows.Forms.Button buttonGuiaDas;
    }
}
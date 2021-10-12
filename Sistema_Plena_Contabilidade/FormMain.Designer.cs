
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonSSVP = new System.Windows.Forms.Button();
            this.buttonPlena = new System.Windows.Forms.Button();
            this.buttonPessoal = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.link_Desc = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(74, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(424, 32);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Sistema para otimização de processos";
            this.labelTitulo.AutoSizeChanged += new System.EventHandler(this.FormMain_Load);
            this.labelTitulo.TextAlignChanged += new System.EventHandler(this.FormMain_Load);
            this.labelTitulo.LocationChanged += new System.EventHandler(this.FormMain_Load);
            this.labelTitulo.Resize += new System.EventHandler(this.FormMain_Load);
            // 
            // buttonSSVP
            // 
            this.buttonSSVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSSVP.Location = new System.Drawing.Point(291, 3);
            this.buttonSSVP.Name = "buttonSSVP";
            this.buttonSSVP.Size = new System.Drawing.Size(139, 39);
            this.buttonSSVP.TabIndex = 3;
            this.buttonSSVP.Text = "SSVP";
            this.buttonSSVP.UseVisualStyleBackColor = true;
            this.buttonSSVP.Click += new System.EventHandler(this.buttonSSVP_Click);
            // 
            // buttonPlena
            // 
            this.buttonPlena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlena.Location = new System.Drawing.Point(147, 3);
            this.buttonPlena.Name = "buttonPlena";
            this.buttonPlena.Size = new System.Drawing.Size(138, 39);
            this.buttonPlena.TabIndex = 2;
            this.buttonPlena.Text = "Plena Contabilidade";
            this.buttonPlena.UseVisualStyleBackColor = true;
            this.buttonPlena.Click += new System.EventHandler(this.buttonPlena_Click);
            // 
            // buttonPessoal
            // 
            this.buttonPessoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPessoal.Location = new System.Drawing.Point(3, 3);
            this.buttonPessoal.Name = "buttonPessoal";
            this.buttonPessoal.Size = new System.Drawing.Size(138, 39);
            this.buttonPessoal.TabIndex = 1;
            this.buttonPessoal.Text = "Pessoal";
            this.buttonPessoal.UseVisualStyleBackColor = true;
            this.buttonPessoal.Click += new System.EventHandler(this.buttonPessoal_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSSVP, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPessoal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlena, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(65, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 48);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // link_Desc
            // 
            this.link_Desc.AutoSize = true;
            this.link_Desc.BackColor = System.Drawing.Color.Transparent;
            this.link_Desc.LinkColor = System.Drawing.Color.Black;
            this.link_Desc.Location = new System.Drawing.Point(424, 247);
            this.link_Desc.Name = "link_Desc";
            this.link_Desc.Size = new System.Drawing.Size(99, 25);
            this.link_Desc.TabIndex = 5;
            this.link_Desc.TabStop = true;
            this.link_Desc.Text = "Descrição";
            this.link_Desc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Desc_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 281);
            this.Controls.Add(this.link_Desc);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.Text = "Sistema de Simplificação";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonSSVP;
        private System.Windows.Forms.Button buttonPlena;
        private System.Windows.Forms.Button buttonPessoal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel link_Desc;
    }
}


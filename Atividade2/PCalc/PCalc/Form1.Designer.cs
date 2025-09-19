namespace PCalc
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFatorialNum1 = new System.Windows.Forms.Button();
            this.btnFatorialNum2 = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumero1.Location = new System.Drawing.Point(242, 42);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(128, 30);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número 1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumero2.Location = new System.Drawing.Point(242, 128);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(128, 30);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Número 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(242, 214);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(123, 30);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumero1.Location = new System.Drawing.Point(405, 39);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(154, 37);
            this.txtNumero1.TabIndex = 3;
            this.txtNumero1.Validated += new System.EventHandler(this.txtNumero1_Validated);
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumero2.Location = new System.Drawing.Point(405, 125);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(154, 37);
            this.txtNumero2.TabIndex = 4;
            this.txtNumero2.Validated += new System.EventHandler(this.txtNumero2_Validated);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(405, 211);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(154, 37);
            this.txtResultado.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Navy;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(199, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 66);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Navy;
            this.btnSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSub.Location = new System.Drawing.Point(376, 306);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(121, 67);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.Navy;
            this.btnMult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMult.Location = new System.Drawing.Point(548, 305);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(121, 67);
            this.btnMult.TabIndex = 8;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Navy;
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiv.Location = new System.Drawing.Point(719, 306);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(121, 67);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Navy;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(683, 59);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 67);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Navy;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(683, 160);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 67);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnFatorialNum1
            // 
            this.btnFatorialNum1.BackColor = System.Drawing.Color.Navy;
            this.btnFatorialNum1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFatorialNum1.Location = new System.Drawing.Point(218, 423);
            this.btnFatorialNum1.Name = "btnFatorialNum1";
            this.btnFatorialNum1.Size = new System.Drawing.Size(199, 67);
            this.btnFatorialNum1.TabIndex = 12;
            this.btnFatorialNum1.Text = "Fatorial Num 1";
            this.btnFatorialNum1.UseVisualStyleBackColor = false;
            this.btnFatorialNum1.Click += new System.EventHandler(this.btnFatorialNum1_Click);
            // 
            // btnFatorialNum2
            // 
            this.btnFatorialNum2.BackColor = System.Drawing.Color.Navy;
            this.btnFatorialNum2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFatorialNum2.Location = new System.Drawing.Point(451, 423);
            this.btnFatorialNum2.Name = "btnFatorialNum2";
            this.btnFatorialNum2.Size = new System.Drawing.Size(207, 67);
            this.btnFatorialNum2.TabIndex = 13;
            this.btnFatorialNum2.Text = "Fatorial Num 2";
            this.btnFatorialNum2.UseVisualStyleBackColor = false;
            this.btnFatorialNum2.Click += new System.EventHandler(this.btnFatorialNum2_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.BackColor = System.Drawing.Color.Navy;
            this.btnPotencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPotencia.Location = new System.Drawing.Point(700, 423);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(121, 67);
            this.btnPotencia.TabIndex = 14;
            this.btnPotencia.Text = "Potência";
            this.btnPotencia.UseVisualStyleBackColor = false;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 571);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnFatorialNum2);
            this.Controls.Add(this.btnFatorialNum1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnFatorialNum1;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnFatorialNum2;
    }
}


namespace WindowsFormsApp1
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
            this.text_resultado = new System.Windows.Forms.TextBox();
            this.btn_sete = new System.Windows.Forms.Button();
            this.btn_oito = new System.Windows.Forms.Button();
            this.btn_nove = new System.Windows.Forms.Button();
            this.btn_quatro = new System.Windows.Forms.Button();
            this.btn_cinco = new System.Windows.Forms.Button();
            this.btn_seis = new System.Windows.Forms.Button();
            this.btn_um = new System.Windows.Forms.Button();
            this.btn_dois = new System.Windows.Forms.Button();
            this.btn_tres = new System.Windows.Forms.Button();
            this.btn_virgula = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_adicao = new System.Windows.Forms.Button();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.lbloperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_resultado
            // 
            this.text_resultado.Location = new System.Drawing.Point(32, 12);
            this.text_resultado.Name = "text_resultado";
            this.text_resultado.ReadOnly = true;
            this.text_resultado.Size = new System.Drawing.Size(156, 20);
            this.text_resultado.TabIndex = 0;
            this.text_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sete
            // 
            this.btn_sete.Location = new System.Drawing.Point(12, 54);
            this.btn_sete.Name = "btn_sete";
            this.btn_sete.Size = new System.Drawing.Size(34, 23);
            this.btn_sete.TabIndex = 1;
            this.btn_sete.Text = "7";
            this.btn_sete.UseVisualStyleBackColor = true;
            this.btn_sete.Click += new System.EventHandler(this.btn_sete_Click);
            // 
            // btn_oito
            // 
            this.btn_oito.Location = new System.Drawing.Point(52, 54);
            this.btn_oito.Name = "btn_oito";
            this.btn_oito.Size = new System.Drawing.Size(28, 23);
            this.btn_oito.TabIndex = 2;
            this.btn_oito.Text = "8";
            this.btn_oito.UseVisualStyleBackColor = true;
            this.btn_oito.Click += new System.EventHandler(this.btn_oito_Click);
            // 
            // btn_nove
            // 
            this.btn_nove.Location = new System.Drawing.Point(86, 54);
            this.btn_nove.Name = "btn_nove";
            this.btn_nove.Size = new System.Drawing.Size(32, 23);
            this.btn_nove.TabIndex = 3;
            this.btn_nove.Text = "9";
            this.btn_nove.UseVisualStyleBackColor = true;
            this.btn_nove.Click += new System.EventHandler(this.btn_nove_Click);
            // 
            // btn_quatro
            // 
            this.btn_quatro.Location = new System.Drawing.Point(12, 94);
            this.btn_quatro.Name = "btn_quatro";
            this.btn_quatro.Size = new System.Drawing.Size(34, 23);
            this.btn_quatro.TabIndex = 4;
            this.btn_quatro.Text = "4";
            this.btn_quatro.UseVisualStyleBackColor = true;
            this.btn_quatro.Click += new System.EventHandler(this.btn_quatro_Click);
            // 
            // btn_cinco
            // 
            this.btn_cinco.Location = new System.Drawing.Point(52, 94);
            this.btn_cinco.Name = "btn_cinco";
            this.btn_cinco.Size = new System.Drawing.Size(28, 23);
            this.btn_cinco.TabIndex = 5;
            this.btn_cinco.Text = "5";
            this.btn_cinco.UseVisualStyleBackColor = true;
            this.btn_cinco.Click += new System.EventHandler(this.btn_cinco_Click);
            // 
            // btn_seis
            // 
            this.btn_seis.Location = new System.Drawing.Point(86, 94);
            this.btn_seis.Name = "btn_seis";
            this.btn_seis.Size = new System.Drawing.Size(32, 23);
            this.btn_seis.TabIndex = 6;
            this.btn_seis.Text = "6";
            this.btn_seis.UseVisualStyleBackColor = true;
            this.btn_seis.Click += new System.EventHandler(this.btn_seis_Click);
            // 
            // btn_um
            // 
            this.btn_um.Location = new System.Drawing.Point(12, 133);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(34, 23);
            this.btn_um.TabIndex = 7;
            this.btn_um.Text = "1";
            this.btn_um.UseVisualStyleBackColor = true;
            this.btn_um.Click += new System.EventHandler(this.btn_um_Click);
            // 
            // btn_dois
            // 
            this.btn_dois.Location = new System.Drawing.Point(52, 133);
            this.btn_dois.Name = "btn_dois";
            this.btn_dois.Size = new System.Drawing.Size(28, 23);
            this.btn_dois.TabIndex = 8;
            this.btn_dois.Text = "2";
            this.btn_dois.UseVisualStyleBackColor = true;
            this.btn_dois.Click += new System.EventHandler(this.btn_dois_Click);
            // 
            // btn_tres
            // 
            this.btn_tres.Location = new System.Drawing.Point(86, 133);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(32, 23);
            this.btn_tres.TabIndex = 9;
            this.btn_tres.Text = "3";
            this.btn_tres.UseVisualStyleBackColor = true;
            this.btn_tres.Click += new System.EventHandler(this.btn_tres_Click);
            // 
            // btn_virgula
            // 
            this.btn_virgula.Location = new System.Drawing.Point(12, 173);
            this.btn_virgula.Name = "btn_virgula";
            this.btn_virgula.Size = new System.Drawing.Size(34, 23);
            this.btn_virgula.TabIndex = 10;
            this.btn_virgula.Text = ",";
            this.btn_virgula.UseVisualStyleBackColor = true;
            this.btn_virgula.Click += new System.EventHandler(this.btn_virgula_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(52, 173);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(28, 23);
            this.btn_zero.TabIndex = 11;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Location = new System.Drawing.Point(86, 173);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(32, 64);
            this.btn_igual.TabIndex = 12;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Location = new System.Drawing.Point(135, 94);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(53, 23);
            this.btn_divisao.TabIndex = 13;
            this.btn_divisao.Text = "/";
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Location = new System.Drawing.Point(135, 133);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(53, 23);
            this.btn_multiplicacao.TabIndex = 14;
            this.btn_multiplicacao.Text = "*";
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_adicao
            // 
            this.btn_adicao.Location = new System.Drawing.Point(135, 173);
            this.btn_adicao.Name = "btn_adicao";
            this.btn_adicao.Size = new System.Drawing.Size(53, 23);
            this.btn_adicao.TabIndex = 15;
            this.btn_adicao.Text = "+";
            this.btn_adicao.UseVisualStyleBackColor = true;
            this.btn_adicao.Click += new System.EventHandler(this.btn_adicao_Click);
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.Location = new System.Drawing.Point(135, 214);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(53, 23);
            this.btn_subtracao.TabIndex = 16;
            this.btn_subtracao.Text = "-";
            this.btn_subtracao.UseVisualStyleBackColor = true;
            this.btn_subtracao.Click += new System.EventHandler(this.btn_subtracao_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.Location = new System.Drawing.Point(135, 54);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(53, 23);
            this.btn_inicio.TabIndex = 17;
            this.btn_inicio.Text = "C";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // lbloperacao
            // 
            this.lbloperacao.AutoSize = true;
            this.lbloperacao.Location = new System.Drawing.Point(32, 18);
            this.lbloperacao.Name = "lbloperacao";
            this.lbloperacao.Size = new System.Drawing.Size(0, 13);
            this.lbloperacao.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 249);
            this.Controls.Add(this.lbloperacao);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_subtracao);
            this.Controls.Add(this.btn_adicao);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_virgula);
            this.Controls.Add(this.btn_tres);
            this.Controls.Add(this.btn_dois);
            this.Controls.Add(this.btn_um);
            this.Controls.Add(this.btn_seis);
            this.Controls.Add(this.btn_cinco);
            this.Controls.Add(this.btn_quatro);
            this.Controls.Add(this.btn_nove);
            this.Controls.Add(this.btn_oito);
            this.Controls.Add(this.btn_sete);
            this.Controls.Add(this.text_resultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_resultado;
        private System.Windows.Forms.Button btn_sete;
        private System.Windows.Forms.Button btn_oito;
        private System.Windows.Forms.Button btn_nove;
        private System.Windows.Forms.Button btn_quatro;
        private System.Windows.Forms.Button btn_cinco;
        private System.Windows.Forms.Button btn_seis;
        private System.Windows.Forms.Button btn_um;
        private System.Windows.Forms.Button btn_dois;
        private System.Windows.Forms.Button btn_tres;
        private System.Windows.Forms.Button btn_virgula;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_adicao;
        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Label lbloperacao;
    }
}


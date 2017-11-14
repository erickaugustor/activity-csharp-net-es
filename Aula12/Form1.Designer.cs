namespace Aula12
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
            this.TXTFINAL = new System.Windows.Forms.TextBox();
            this.BTNFOR = new System.Windows.Forms.Button();
            this.BTNWHILE = new System.Windows.Forms.Button();
            this.TXTNUMBER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTFINAL
            // 
            this.TXTFINAL.Enabled = false;
            this.TXTFINAL.Location = new System.Drawing.Point(12, 61);
            this.TXTFINAL.Multiline = true;
            this.TXTFINAL.Name = "TXTFINAL";
            this.TXTFINAL.Size = new System.Drawing.Size(260, 153);
            this.TXTFINAL.TabIndex = 0;
            // 
            // BTNFOR
            // 
            this.BTNFOR.Location = new System.Drawing.Point(12, 220);
            this.BTNFOR.Name = "BTNFOR";
            this.BTNFOR.Size = new System.Drawing.Size(120, 23);
            this.BTNFOR.TabIndex = 1;
            this.BTNFOR.Text = "FOR";
            this.BTNFOR.UseVisualStyleBackColor = true;
            this.BTNFOR.Click += new System.EventHandler(this.BTNFOR_Click);
            // 
            // BTNWHILE
            // 
            this.BTNWHILE.Location = new System.Drawing.Point(138, 220);
            this.BTNWHILE.Name = "BTNWHILE";
            this.BTNWHILE.Size = new System.Drawing.Size(134, 23);
            this.BTNWHILE.TabIndex = 2;
            this.BTNWHILE.Text = "WHILE";
            this.BTNWHILE.UseVisualStyleBackColor = true;
            this.BTNWHILE.Click += new System.EventHandler(this.BTNWHILE_Click);
            // 
            // TXTNUMBER
            // 
            this.TXTNUMBER.Location = new System.Drawing.Point(114, 23);
            this.TXTNUMBER.Name = "TXTNUMBER";
            this.TXTNUMBER.Size = new System.Drawing.Size(158, 20);
            this.TXTNUMBER.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe os valores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Atividade - 12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTNUMBER);
            this.Controls.Add(this.BTNWHILE);
            this.Controls.Add(this.BTNFOR);
            this.Controls.Add(this.TXTFINAL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTFINAL;
        private System.Windows.Forms.Button BTNFOR;
        private System.Windows.Forms.Button BTNWHILE;
        private System.Windows.Forms.TextBox TXTNUMBER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


namespace ProjetoSenha
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
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnpPeferencial = new System.Windows.Forms.Button();
            this.lbSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNormal
            // 
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(44, 41);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(320, 99);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnpPeferencial
            // 
            this.btnpPeferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpPeferencial.Location = new System.Drawing.Point(44, 199);
            this.btnpPeferencial.Name = "btnpPeferencial";
            this.btnpPeferencial.Size = new System.Drawing.Size(320, 99);
            this.btnpPeferencial.TabIndex = 1;
            this.btnpPeferencial.Text = "Preferencial";
            this.btnpPeferencial.UseVisualStyleBackColor = true;
            this.btnpPeferencial.Click += new System.EventHandler(this.btnpPeferencial_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.BackColor = System.Drawing.Color.BurlyWood;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbSenha.Location = new System.Drawing.Point(504, 41);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(240, 257);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha";
            this.lbSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.btnpPeferencial);
            this.Controls.Add(this.btnNormal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnpPeferencial;
        private System.Windows.Forms.Label lbSenha;
    }
}


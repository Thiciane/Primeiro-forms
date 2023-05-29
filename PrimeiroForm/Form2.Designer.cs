namespace PrimeiroForm
{
    partial class telinha
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_confirmarSenha = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lb_diferentes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(152, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conf. Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "C.P.F.:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(106, 75);
            this.tx_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(398, 33);
            this.tx_nome.TabIndex = 6;
            // 
            // tx_confirmarSenha
            // 
            this.tx_confirmarSenha.Location = new System.Drawing.Point(151, 268);
            this.tx_confirmarSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_confirmarSenha.Name = "tx_confirmarSenha";
            this.tx_confirmarSenha.PasswordChar = '*';
            this.tx_confirmarSenha.Size = new System.Drawing.Size(207, 33);
            this.tx_confirmarSenha.TabIndex = 7;
            // 
            // tx_senha
            // 
            this.tx_senha.Location = new System.Drawing.Point(107, 223);
            this.tx_senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.PasswordChar = '*';
            this.tx_senha.Size = new System.Drawing.Size(205, 33);
            this.tx_senha.TabIndex = 8;
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(107, 126);
            this.tx_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(397, 33);
            this.tx_email.TabIndex = 10;
            this.tx_email.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.Location = new System.Drawing.Point(37, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.Location = new System.Drawing.Point(151, 372);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mask_cpf
            // 
            this.mask_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mask_cpf.Location = new System.Drawing.Point(98, 176);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(133, 33);
            this.mask_cpf.TabIndex = 14;
            this.mask_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefone:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightPink;
            this.button3.Location = new System.Drawing.Point(410, 372);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 39);
            this.button3.TabIndex = 17;
            this.button3.Text = "Color";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Location = new System.Drawing.Point(330, 176);
            this.maskedTextBox1.Mask = "(00) 0 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(146, 33);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_diferentes
            // 
            this.lb_diferentes.AutoSize = true;
            this.lb_diferentes.Location = new System.Drawing.Point(34, 318);
            this.lb_diferentes.Name = "lb_diferentes";
            this.lb_diferentes.Size = new System.Drawing.Size(61, 26);
            this.lb_diferentes.TabIndex = 19;
            this.lb_diferentes.Text = "label8";
            // 
            // telinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(539, 428);
            this.Controls.Add(this.lb_diferentes);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_confirmarSenha);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Noto Sans Cond", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "telinha";
            this.Text = "Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_confirmarSenha;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lb_diferentes;
    }
}
namespace UserLogin.Apresentação
{
    partial class Cadastro
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
            lblInfo = new Label();
            lblLogin2 = new Label();
            lblSenha2 = new Label();
            lblSenha3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Tahoma", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblInfo.Location = new Point(12, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(161, 16);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Cadastre um novo usuário.";
            // 
            // lblLogin2
            // 
            lblLogin2.AutoSize = true;
            lblLogin2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin2.Location = new Point(51, 41);
            lblLogin2.Name = "lblLogin2";
            lblLogin2.Size = new Size(48, 19);
            lblLogin2.TabIndex = 1;
            lblLogin2.Text = "Login";
            lblLogin2.Click += lblLogin2_Click;
            // 
            // lblSenha2
            // 
            lblSenha2.AutoSize = true;
            lblSenha2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha2.Location = new Point(51, 152);
            lblSenha2.Name = "lblSenha2";
            lblSenha2.Size = new Size(48, 18);
            lblSenha2.TabIndex = 2;
            lblSenha2.Text = "Senha";
            // 
            // lblSenha3
            // 
            lblSenha3.AutoSize = true;
            lblSenha3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha3.Location = new Point(51, 205);
            lblSenha3.Name = "lblSenha3";
            lblSenha3.Size = new Size(111, 18);
            lblSenha3.TabIndex = 3;
            lblSenha3.Text = "Confirma Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(51, 173);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(51, 226);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(168, 23);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(175, 280);
            button1.Name = "button1";
            button1.Size = new Size(102, 36);
            button1.TabIndex = 7;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 95);
            label1.Name = "label1";
            label1.Size = new Size(33, 18);
            label1.TabIndex = 8;
            label1.Text = "CPF";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(51, 116);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 9;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(38, 287);
            button2.Name = "button2";
            button2.Size = new Size(61, 25);
            button2.TabIndex = 10;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 328);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblSenha3);
            Controls.Add(lblSenha2);
            Controls.Add(lblLogin2);
            Controls.Add(lblInfo);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Label lblLogin2;
        private Label lblSenha2;
        private Label lblSenha3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private TextBox textBox4;
        private Button button2;
    }
}
namespace UserLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCadastro = new Button();
            btnEntrar = new Button();
            lblLogin = new Label();
            lblSenha = new Label();
            pictureBox1 = new PictureBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnFehcar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFehcar).BeginInit();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastro.Location = new Point(296, 250);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(89, 34);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "CADASTRAR";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.Location = new Point(416, 250);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 35);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(296, 70);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(55, 18);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += label1_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.Location = new Point(296, 156);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(63, 18);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "SENHA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(296, 91);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(220, 29);
            txtLogin.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(296, 177);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(178, 29);
            txtSenha.TabIndex = 7;
            // 
            // btnFehcar
            // 
            btnFehcar.Image = (Image)resources.GetObject("btnFehcar.Image");
            btnFehcar.Location = new Point(505, 12);
            btnFehcar.Name = "btnFehcar";
            btnFehcar.Size = new Size(27, 26);
            btnFehcar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnFehcar.TabIndex = 8;
            btnFehcar.TabStop = false;
            btnFehcar.Click += btnFehcar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(544, 314);
            Controls.Add(btnFehcar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(pictureBox1);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(btnEntrar);
            Controls.Add(btnCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFehcar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private Button btnEntrar;
        private Label lblLogin;
        private Label lblSenha;
        private PictureBox pictureBox1;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private PictureBox btnFehcar;
    }
}
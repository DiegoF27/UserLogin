namespace UserLogin.Apresentação
{
    partial class Acesso
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
            lblBv = new Label();
            lblAguarde = new Label();
            SuspendLayout();
            // 
            // lblBv
            // 
            lblBv.AutoSize = true;
            lblBv.Font = new Font("Arial", 36F, FontStyle.Italic, GraphicsUnit.Point);
            lblBv.Location = new Point(12, 29);
            lblBv.Name = "lblBv";
            lblBv.Size = new Size(253, 55);
            lblBv.TabIndex = 0;
            lblBv.Text = "Bem-vindo";
            // 
            // lblAguarde
            // 
            lblAguarde.AutoSize = true;
            lblAguarde.Location = new Point(12, 84);
            lblAguarde.Name = "lblAguarde";
            lblAguarde.Size = new Size(61, 15);
            lblAguarde.TabIndex = 1;
            lblAguarde.Text = "Aguarde...";
            lblAguarde.Click += label2_Click;
            // 
            // Acesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(275, 128);
            Controls.Add(lblAguarde);
            Controls.Add(lblBv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Acesso";
            Text = "Acesso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBv;
        private Label lblAguarde;
    }
}
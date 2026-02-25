namespace Aula02
{
    partial class CadastroAluno
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
            txt_alunocod = new TextBox();
            btn_cadastrar = new Button();
            txt_nome = new TextBox();
            txt_rm = new TextBox();
            lbl_alunocod = new Label();
            lbl_nome = new Label();
            lbl_rm = new Label();
            SuspendLayout();
            // 
            // txt_alunocod
            // 
            txt_alunocod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_alunocod.BackColor = Color.FromArgb(255, 192, 255);
            txt_alunocod.BorderStyle = BorderStyle.None;
            txt_alunocod.Cursor = Cursors.IBeam;
            txt_alunocod.Location = new Point(303, 74);
            txt_alunocod.Multiline = true;
            txt_alunocod.Name = "txt_alunocod";
            txt_alunocod.Size = new Size(157, 38);
            txt_alunocod.TabIndex = 0;
            txt_alunocod.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(205, 143, 255);
            btn_cadastrar.Cursor = Cursors.Hand;
            btn_cadastrar.FlatAppearance.BorderColor = Color.FromArgb(107, 48, 191);
            btn_cadastrar.FlatAppearance.BorderSize = 2;
            btn_cadastrar.FlatAppearance.MouseDownBackColor = Color.Purple;
            btn_cadastrar.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Source Code Pro", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastrar.Location = new Point(329, 286);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(109, 44);
            btn_cadastrar.TabIndex = 3;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // txt_nome
            // 
            txt_nome.BackColor = Color.FromArgb(255, 192, 255);
            txt_nome.BorderStyle = BorderStyle.None;
            txt_nome.Cursor = Cursors.IBeam;
            txt_nome.Location = new Point(303, 136);
            txt_nome.Multiline = true;
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(157, 44);
            txt_nome.TabIndex = 1;
            txt_nome.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_rm
            // 
            txt_rm.BackColor = Color.FromArgb(255, 192, 255);
            txt_rm.BorderStyle = BorderStyle.None;
            txt_rm.Cursor = Cursors.IBeam;
            txt_rm.Location = new Point(303, 211);
            txt_rm.Multiline = true;
            txt_rm.Name = "txt_rm";
            txt_rm.Size = new Size(157, 40);
            txt_rm.TabIndex = 2;
            txt_rm.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_alunocod
            // 
            lbl_alunocod.AutoSize = true;
            lbl_alunocod.Location = new Point(329, 56);
            lbl_alunocod.Name = "lbl_alunocod";
            lbl_alunocod.Size = new Size(98, 15);
            lbl_alunocod.TabIndex = 4;
            lbl_alunocod.Text = "Código do Aluno";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(362, 118);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(40, 15);
            lbl_nome.TabIndex = 5;
            lbl_nome.Text = "Nome";
            // 
            // lbl_rm
            // 
            lbl_rm.AutoSize = true;
            lbl_rm.Location = new Point(362, 193);
            lbl_rm.Name = "lbl_rm";
            lbl_rm.Size = new Size(25, 15);
            lbl_rm.TabIndex = 6;
            lbl_rm.Text = "RM";
            // 
            // CadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 136, 222);
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_rm);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_alunocod);
            Controls.Add(txt_rm);
            Controls.Add(txt_nome);
            Controls.Add(btn_cadastrar);
            Controls.Add(txt_alunocod);
            Name = "CadastroAluno";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_alunocod;
        private Button btn_cadastrar;
        private TextBox txt_nome;
        private TextBox txt_rm;
        private Label lbl_alunocod;
        private Label lbl_nome;
        private Label lbl_rm;
    }
}

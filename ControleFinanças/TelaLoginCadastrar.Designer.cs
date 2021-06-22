
namespace ControleFinanças
{
    partial class TelaLoginCadastrar
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
            this.components = new System.ComponentModel.Container();
            this.btEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanTop = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.button1 = new System.Windows.Forms.Button();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.txtNome = new System.Windows.Forms.TextBox();
            this.PanTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.Teal;
            this.btEntrar.ForeColor = System.Drawing.Color.White;
            this.btEntrar.Location = new System.Drawing.Point(343, 325);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(161, 37);
            this.btEntrar.TabIndex = 8;
            this.btEntrar.Text = "Cadastrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(154, 143);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(232, 20);
            this.txtTelefone.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Login :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefone :";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(154, 205);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(232, 20);
            this.txtSenha.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Senha :";
            // 
            // PanTop
            // 
            this.PanTop.Controls.Add(this.siticoneControlBox2);
            this.PanTop.Controls.Add(this.button1);
            this.PanTop.Controls.Add(this.siticoneControlBox3);
            this.PanTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTop.Location = new System.Drawing.Point(0, 0);
            this.PanTop.Name = "PanTop";
            this.PanTop.ShadowDecoration.Parent = this.PanTop;
            this.PanTop.Size = new System.Drawing.Size(516, 36);
            this.PanTop.TabIndex = 21;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Teal;
            this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Honeydew;
            this.siticoneControlBox2.Location = new System.Drawing.Point(420, 3);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.FillColor = System.Drawing.Color.Teal;
            this.siticoneControlBox3.HoverState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.Honeydew;
            this.siticoneControlBox3.Location = new System.Drawing.Point(471, 3);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox3.TabIndex = 24;
            this.siticoneControlBox3.Click += new System.EventHandler(this.siticoneControlBox3_Click);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.PanTop;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(154, 112);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 20);
            this.txtNome.TabIndex = 23;
            // 
            // TelaLoginCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(516, 374);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.PanTop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLoginCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanTop;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTelefone;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtNome;
    }
}
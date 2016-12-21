namespace WMOFControl.GUI
{
    partial class FormAddCliente
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
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textCnpj = new System.Windows.Forms.MaskedTextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CNPJ: ";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(73, 6);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(299, 20);
            this.textNome.TabIndex = 6;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(73, 58);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(299, 20);
            this.textEmail.TabIndex = 8;
            // 
            // textCpf
            // 
            this.textCpf.Enabled = false;
            this.textCpf.Location = new System.Drawing.Point(88, 52);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(112, 20);
            this.textCpf.TabIndex = 9;
            // 
            // textCnpj
            // 
            this.textCnpj.Enabled = false;
            this.textCnpj.Location = new System.Drawing.Point(88, 78);
            this.textCnpj.Mask = "00.000.000/0000-00";
            this.textCnpj.Name = "textCnpj";
            this.textCnpj.Size = new System.Drawing.Size(112, 20);
            this.textCnpj.TabIndex = 10;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Juridica",
            "Fisica"});
            this.comboTipo.Location = new System.Drawing.Point(46, 25);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 11;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            this.comboTipo.CursorChanged += new System.EventHandler(this.comboTipo_CursorChanged);
            this.comboTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboTipo_KeyPress);
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(73, 32);
            this.textTelefone.Mask = "(00) 00000-0000";
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(100, 20);
            this.textTelefone.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboTipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textCnpj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textCpf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 108);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cliente";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(297, 198);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 15;
            this.btClose.Text = "Sair";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(216, 198);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 16;
            this.btClear.Text = "Limpar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 198);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 17;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // FormAddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 230);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddCliente";
            this.Text = "Adicionar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.MaskedTextBox textCnpj;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.MaskedTextBox textTelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btAdd;
    }
}
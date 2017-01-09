namespace WMOFControl.GUI
{
    partial class FormAddProduto
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.checkEntregue = new System.Windows.Forms.CheckBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.textEntrega = new System.Windows.Forms.MaskedTextBox();
            this.textSolicitado = new System.Windows.Forms.MaskedTextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(106, 97);
            this.maskedTextBox1.Mask = "$ 00000.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 30;
            // 
            // checkEntregue
            // 
            this.checkEntregue.AutoSize = true;
            this.checkEntregue.Location = new System.Drawing.Point(177, 151);
            this.checkEntregue.Name = "checkEntregue";
            this.checkEntregue.Size = new System.Drawing.Size(69, 17);
            this.checkEntregue.TabIndex = 29;
            this.checkEntregue.Text = "Entregue";
            this.checkEntregue.UseVisualStyleBackColor = true;
            this.checkEntregue.CheckedChanged += new System.EventHandler(this.checkPago_CheckedChanged);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(377, 205);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 28;
            this.btClear.Text = "Limpar";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 205);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 27;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // comboCliente
            // 
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(106, 175);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(346, 21);
            this.comboCliente.TabIndex = 26;
            // 
            // textEntrega
            // 
            this.textEntrega.Enabled = false;
            this.textEntrega.Location = new System.Drawing.Point(106, 149);
            this.textEntrega.Mask = "00/00/0000";
            this.textEntrega.Name = "textEntrega";
            this.textEntrega.Size = new System.Drawing.Size(65, 20);
            this.textEntrega.TabIndex = 25;
            this.textEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // textSolicitado
            // 
            this.textSolicitado.Location = new System.Drawing.Point(106, 123);
            this.textSolicitado.Mask = "00/00/0000";
            this.textSolicitado.Name = "textSolicitado";
            this.textSolicitado.Size = new System.Drawing.Size(65, 20);
            this.textSolicitado.TabIndex = 24;
            this.textSolicitado.ValidatingType = typeof(System.DateTime);
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(106, 12);
            this.textTitulo.Multiline = true;
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(346, 38);
            this.textTitulo.TabIndex = 23;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(106, 53);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(346, 38);
            this.textDescricao.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Solicitado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descrição";
            // 
            // FormAddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 237);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.checkEntregue);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.textEntrega);
            this.Controls.Add(this.textSolicitado);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddProduto";
            this.Text = "FormAddProduto";
            this.Load += new System.EventHandler(this.FormAddProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.CheckBox checkEntregue;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.MaskedTextBox textEntrega;
        private System.Windows.Forms.MaskedTextBox textSolicitado;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
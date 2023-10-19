﻿
namespace GerenciadorDeEstoque.Apresentação.Cliente
{
    partial class AddClienteCNPJ
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
            this.txb_celularCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txb_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_NomeCNPJ = new System.Windows.Forms.TextBox();
            this.txb_telefoneCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_observacoes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CNPJ = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_endereco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_celularCNPJ
            // 
            this.txb_celularCNPJ.Location = new System.Drawing.Point(108, 75);
            this.txb_celularCNPJ.Mask = "(000) 00000-0000";
            this.txb_celularCNPJ.Name = "txb_celularCNPJ";
            this.txb_celularCNPJ.Size = new System.Drawing.Size(190, 20);
            this.txb_celularCNPJ.TabIndex = 26;
            //this.txb_celularCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txb_celularCNPJ_MaskInputRejected);
            // 
            // txb_CNPJ
            // 
            this.txb_CNPJ.Location = new System.Drawing.Point(108, 104);
            this.txb_CNPJ.Mask = "00.000.000/0000-00";
            this.txb_CNPJ.Name = "txb_CNPJ";
            this.txb_CNPJ.Size = new System.Drawing.Size(190, 20);
            this.txb_CNPJ.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(555, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "CADASTRAR CLIENTE";
            this.button1.UseVisualStyleBackColor = false;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_NomeCNPJ
            // 
            this.txb_NomeCNPJ.Location = new System.Drawing.Point(107, 23);
            this.txb_NomeCNPJ.Name = "txb_NomeCNPJ";
            this.txb_NomeCNPJ.Size = new System.Drawing.Size(431, 20);
            this.txb_NomeCNPJ.TabIndex = 2;
            // 
            // txb_telefoneCNPJ
            // 
            this.txb_telefoneCNPJ.Location = new System.Drawing.Point(107, 49);
            this.txb_telefoneCNPJ.Mask = "(000) 0000-0000";
            this.txb_telefoneCNPJ.Name = "txb_telefoneCNPJ";
            this.txb_telefoneCNPJ.Size = new System.Drawing.Size(190, 20);
            this.txb_telefoneCNPJ.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "OBSERVAÇÕES";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "TELEFONE";
            // 
            // txb_observacoes
            // 
            this.txb_observacoes.Location = new System.Drawing.Point(107, 182);
            this.txb_observacoes.Name = "txb_observacoes";
            this.txb_observacoes.Size = new System.Drawing.Size(590, 20);
            this.txb_observacoes.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "E-MAIL";
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(107, 156);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(355, 20);
            this.txb_email.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "CELULAR";
            // 
            // CNPJ
            // 
            this.CNPJ.AutoSize = true;
            this.CNPJ.Location = new System.Drawing.Point(13, 107);
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Size = new System.Drawing.Size(34, 13);
            this.CNPJ.TabIndex = 11;
            this.CNPJ.Text = "CNPJ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "ENDEREÇO";
            // 
            // txb_endereco
            // 
            this.txb_endereco.Location = new System.Drawing.Point(107, 130);
            this.txb_endereco.Name = "txb_endereco";
            this.txb_endereco.Size = new System.Drawing.Size(590, 20);
            this.txb_endereco.TabIndex = 12;
            // 
            // AddClienteCNPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(710, 272);
            this.Controls.Add(this.txb_celularCNPJ);
            this.Controls.Add(this.txb_CNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_endereco);
            this.Controls.Add(this.txb_NomeCNPJ);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txb_telefoneCNPJ);
            this.Controls.Add(this.CNPJ);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_observacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddClienteCNPJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar cliente (jurídico)";
            //this.Load += new System.EventHandler(this.AddClienteCNPJ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txb_CNPJ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_NomeCNPJ;
        private System.Windows.Forms.MaskedTextBox txb_telefoneCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_observacoes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label CNPJ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb_endereco;
        private System.Windows.Forms.MaskedTextBox txb_celularCNPJ;
    }
}
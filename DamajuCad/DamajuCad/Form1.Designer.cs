﻿namespace DamajuCad
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
            this.CadLanche = new System.Windows.Forms.Button();
            this.CadCliente = new System.Windows.Forms.Button();
            this.Gerenciamento_produtos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Gerenciamento_Clientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CadLanche
            // 
            this.CadLanche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CadLanche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CadLanche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadLanche.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CadLanche.Location = new System.Drawing.Point(199, 175);
            this.CadLanche.Name = "CadLanche";
            this.CadLanche.Size = new System.Drawing.Size(180, 62);
            this.CadLanche.TabIndex = 1;
            this.CadLanche.Text = "Cadastrar Lanche";
            this.CadLanche.UseVisualStyleBackColor = false;
            this.CadLanche.Click += new System.EventHandler(this.CadLanche_Click);
            // 
            // CadCliente
            // 
            this.CadCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CadCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CadCliente.Location = new System.Drawing.Point(199, 277);
            this.CadCliente.Name = "CadCliente";
            this.CadCliente.Size = new System.Drawing.Size(180, 62);
            this.CadCliente.TabIndex = 2;
            this.CadCliente.Text = "Cadastrar Cliente";
            this.CadCliente.UseVisualStyleBackColor = false;
            this.CadCliente.Click += new System.EventHandler(this.CadCliente_Click);
            // 
            // Gerenciamento_produtos
            // 
            this.Gerenciamento_produtos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gerenciamento_produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Gerenciamento_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gerenciamento_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerenciamento_produtos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gerenciamento_produtos.Location = new System.Drawing.Point(445, 175);
            this.Gerenciamento_produtos.Name = "Gerenciamento_produtos";
            this.Gerenciamento_produtos.Size = new System.Drawing.Size(180, 62);
            this.Gerenciamento_produtos.TabIndex = 3;
            this.Gerenciamento_produtos.Text = "Gerenciamento Produtos";
            this.Gerenciamento_produtos.UseVisualStyleBackColor = false;
            this.Gerenciamento_produtos.Click += new System.EventHandler(this.Gerenciamento_produtos_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu Damaju";
            // 
            // Gerenciamento_Clientes
            // 
            this.Gerenciamento_Clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gerenciamento_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Gerenciamento_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gerenciamento_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerenciamento_Clientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gerenciamento_Clientes.Location = new System.Drawing.Point(445, 277);
            this.Gerenciamento_Clientes.Name = "Gerenciamento_Clientes";
            this.Gerenciamento_Clientes.Size = new System.Drawing.Size(180, 62);
            this.Gerenciamento_Clientes.TabIndex = 5;
            this.Gerenciamento_Clientes.Text = "Gerenciamento Clientes";
            this.Gerenciamento_Clientes.UseVisualStyleBackColor = false;
            this.Gerenciamento_Clientes.Click += new System.EventHandler(this.Gerenciamento_Clientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gerenciamento_Clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gerenciamento_produtos);
            this.Controls.Add(this.CadCliente);
            this.Controls.Add(this.CadLanche);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CadLanche;
        private System.Windows.Forms.Button CadCliente;
        private System.Windows.Forms.Button Gerenciamento_produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gerenciamento_Clientes;
    }
}


namespace FocusJob
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtAtividade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbQtd = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(30, 102);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(150, 42);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar atividade";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAtividade
            // 
            this.txtAtividade.Location = new System.Drawing.Point(126, 30);
            this.txtAtividade.Margin = new System.Windows.Forms.Padding(6);
            this.txtAtividade.Name = "txtAtividade";
            this.txtAtividade.Size = new System.Drawing.Size(196, 29);
            this.txtAtividade.TabIndex = 1;
            this.txtAtividade.TextChanged += new System.EventHandler(this.txtAtividade_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Atividade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qtd Pomodoris:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(258, 102);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 42);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cmbQtd
            // 
            this.cmbQtd.FormattingEnabled = true;
            this.cmbQtd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQtd.Location = new System.Drawing.Point(513, 27);
            this.cmbQtd.Margin = new System.Windows.Forms.Padding(6);
            this.cmbQtd.Name = "cmbQtd";
            this.cmbQtd.Size = new System.Drawing.Size(104, 32);
            this.cmbQtd.TabIndex = 6;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.DarkRed;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Location = new System.Drawing.Point(498, 102);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(150, 42);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(726, 201);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.cmbQtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAtividade);
            this.Controls.Add(this.btnAdicionar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Atividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtAtividade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cmbQtd;
        private System.Windows.Forms.Button btnFinalizar;
    }
}


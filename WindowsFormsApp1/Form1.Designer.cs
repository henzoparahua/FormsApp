
namespace WindowsFormsApp1
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
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.rdbOne = new System.Windows.Forms.RadioButton();
            this.rdbTwo = new System.Windows.Forms.RadioButton();
            this.rdbThree = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idade = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idade)).BeginInit();
            this.SuspendLayout();
            // 
            // cpf
            // 
            this.cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cpf.Location = new System.Drawing.Point(109, 140);
            this.cpf.Mask = "000.000.000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(100, 20);
            this.cpf.TabIndex = 0;
            this.cpf.ValidatingType = typeof(System.DateTime);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(109, 75);
            this.name.Name = "name";
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            // 
            // rdbOne
            // 
            this.rdbOne.AutoSize = true;
            this.rdbOne.Location = new System.Drawing.Point(304, 75);
            this.rdbOne.Name = "rdbOne";
            this.rdbOne.Size = new System.Drawing.Size(58, 17);
            this.rdbOne.TabIndex = 2;
            this.rdbOne.TabStop = true;
            this.rdbOne.Text = "solteiro";
            this.rdbOne.UseVisualStyleBackColor = true;
            // 
            // rdbTwo
            // 
            this.rdbTwo.AutoSize = true;
            this.rdbTwo.Location = new System.Drawing.Point(304, 105);
            this.rdbTwo.Name = "rdbTwo";
            this.rdbTwo.Size = new System.Drawing.Size(60, 17);
            this.rdbTwo.TabIndex = 3;
            this.rdbTwo.TabStop = true;
            this.rdbTwo.Text = "casado";
            this.rdbTwo.UseVisualStyleBackColor = true;
            // 
            // rdbThree
            // 
            this.rdbThree.AutoSize = true;
            this.rdbThree.Location = new System.Drawing.Point(304, 140);
            this.rdbThree.Name = "rdbThree";
            this.rdbThree.Size = new System.Drawing.Size(51, 17);
            this.rdbThree.TabIndex = 4;
            this.rdbThree.TabStop = true;
            this.rdbThree.Text = "viuvo";
            this.rdbThree.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado civil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado de nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Bahia",
            "Santa Catarina",
            "Parana",
            "Para",
            "Amapa",
            "Sergipe",
            "Goias",
            "Amazonas"});
            this.comboBox1.Location = new System.Drawing.Point(109, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // idade
            // 
            this.idade.Location = new System.Drawing.Point(429, 72);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(120, 20);
            this.idade.TabIndex = 11;
            this.idade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(222, 307);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmado ";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(425, 259);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(426, 307);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 14;
            this.lblCPF.Text = "CPF";
            this.lblCPF.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(426, 346);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblNascimento.TabIndex = 15;
            this.lblNascimento.Text = "Nascimento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbThree);
            this.Controls.Add(this.rdbTwo);
            this.Controls.Add(this.rdbOne);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton rdbOne;
        private System.Windows.Forms.RadioButton rdbTwo;
        private System.Windows.Forms.RadioButton rdbThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown idade;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNascimento;
    }
}


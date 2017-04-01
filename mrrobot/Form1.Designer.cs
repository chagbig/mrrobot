namespace mrrobot
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btProverka = new System.Windows.Forms.Button();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.tbRezult = new System.Windows.Forms.TextBox();
            this.chbTelefon = new System.Windows.Forms.CheckBox();
            this.btnProverkaRegexp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btProverka
            // 
            this.btProverka.Location = new System.Drawing.Point(96, 1);
            this.btProverka.Name = "btProverka";
            this.btProverka.Size = new System.Drawing.Size(75, 23);
            this.btProverka.TabIndex = 2;
            this.btProverka.Text = "Проверка";
            this.btProverka.UseVisualStyleBackColor = true;
            this.btProverka.Click += new System.EventHandler(this.btProverka_Click);
            // 
            // tbConsole
            // 
            this.tbConsole.Location = new System.Drawing.Point(0, 24);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(417, 180);
            this.tbConsole.TabIndex = 3;
            this.tbConsole.TextChanged += new System.EventHandler(this.tbConsole_TextChanged);
            // 
            // tbRezult
            // 
            this.tbRezult.Location = new System.Drawing.Point(0, 244);
            this.tbRezult.Multiline = true;
            this.tbRezult.Name = "tbRezult";
            this.tbRezult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRezult.Size = new System.Drawing.Size(417, 246);
            this.tbRezult.TabIndex = 4;
            // 
            // chbTelefon
            // 
            this.chbTelefon.AutoSize = true;
            this.chbTelefon.Location = new System.Drawing.Point(198, 5);
            this.chbTelefon.Name = "chbTelefon";
            this.chbTelefon.Size = new System.Drawing.Size(103, 17);
            this.chbTelefon.TabIndex = 5;
            this.chbTelefon.Text = "Толко телефон";
            this.chbTelefon.UseVisualStyleBackColor = true;
            // 
            // btnProverkaRegexp
            // 
            this.btnProverkaRegexp.Location = new System.Drawing.Point(0, 215);
            this.btnProverkaRegexp.Name = "btnProverkaRegexp";
            this.btnProverkaRegexp.Size = new System.Drawing.Size(171, 23);
            this.btnProverkaRegexp.TabIndex = 6;
            this.btnProverkaRegexp.Text = "Проверка Regexp";
            this.btnProverkaRegexp.UseVisualStyleBackColor = true;
            this.btnProverkaRegexp.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 488);
            this.Controls.Add(this.btnProverkaRegexp);
            this.Controls.Add(this.chbTelefon);
            this.Controls.Add(this.tbRezult);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.btProverka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MrRobot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btProverka;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.TextBox tbRezult;
        private System.Windows.Forms.CheckBox chbTelefon;
        private System.Windows.Forms.Button btnProverkaRegexp;
    }
}


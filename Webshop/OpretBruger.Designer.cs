namespace Webshop
{
    partial class OpretBruger
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            opretBruger_ = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 57);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Brugernavn";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 97);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Adgangskode";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // opretBruger_
            // 
            opretBruger_.Location = new Point(68, 136);
            opretBruger_.Name = "opretBruger_";
            opretBruger_.Size = new Size(100, 23);
            opretBruger_.TabIndex = 3;
            opretBruger_.Text = "Opret bruger";
            opretBruger_.UseVisualStyleBackColor = true;
            opretBruger_.Click += opretBruger__Click;
            // 
            // OpretBruger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 215);
            Controls.Add(opretBruger_);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "OpretBruger";
            Text = "OpretBruger";
            Load += OpretBruger_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Button opretBruger_;
    }
}
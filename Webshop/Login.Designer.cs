namespace Webshop
{
    partial class Login
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
            login_ = new Button();
            opretBruger_ = new Button();
            label1 = new Label();
            brugernavnBox = new TextBox();
            adgangskodeBox = new TextBox();
            SuspendLayout();
            // 
            // login_
            // 
            login_.Location = new Point(51, 120);
            login_.Name = "login_";
            login_.Size = new Size(83, 23);
            login_.TabIndex = 0;
            login_.Text = "Login";
            login_.UseVisualStyleBackColor = true;
            login_.Click += login__Click;
            // 
            // opretBruger_
            // 
            opretBruger_.Location = new Point(145, 120);
            opretBruger_.Name = "opretBruger_";
            opretBruger_.Size = new Size(83, 23);
            opretBruger_.TabIndex = 1;
            opretBruger_.Text = "Opret bruger";
            opretBruger_.UseVisualStyleBackColor = true;
            opretBruger_.Click += opretBruger__Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // brugernavnBox
            // 
            brugernavnBox.ForeColor = SystemColors.WindowFrame;
            brugernavnBox.Location = new Point(51, 31);
            brugernavnBox.Name = "brugernavnBox";
            brugernavnBox.PlaceholderText = "Brugernavn";
            brugernavnBox.Size = new Size(177, 23);
            brugernavnBox.TabIndex = 4;
            brugernavnBox.TextChanged += brugernavnBox_TextChanged;
            // 
            // adgangskodeBox
            // 
            adgangskodeBox.ForeColor = SystemColors.WindowFrame;
            adgangskodeBox.Location = new Point(51, 76);
            adgangskodeBox.Name = "adgangskodeBox";
            adgangskodeBox.PlaceholderText = "Adgangskode";
            adgangskodeBox.Size = new Size(177, 23);
            adgangskodeBox.TabIndex = 5;
            adgangskodeBox.TextChanged += adgangskodeBox_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 174);
            Controls.Add(adgangskodeBox);
            Controls.Add(brugernavnBox);
            Controls.Add(label1);
            Controls.Add(opretBruger_);
            Controls.Add(login_);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_;
        private Button opretBruger_;
        private Label label1;
        private Label label2;
        private TextBox brugernavnBox;
        private TextBox adgangskodeBox;
    }
}
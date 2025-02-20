namespace Webshop
{
    partial class WebshopForm
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
            vare1 = new Label();
            SuspendLayout();
            // 
            // vare1
            // 
            vare1.AutoSize = true;
            vare1.Location = new Point(202, 93);
            vare1.Name = "vare1";
            vare1.Size = new Size(65, 15);
            vare1.TabIndex = 0;
            vare1.Text = "Slave 20 kr.";
            // 
            // WebshopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 331);
            Controls.Add(vare1);
            Name = "WebshopForm";
            Text = "WebshopForm";
            Load += WebshopForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label vare1;
    }
}
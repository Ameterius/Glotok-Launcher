namespace Glotok
{
    partial class Fixes
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
            cache_clear = new Button();
            soonorondeveloperhead = new Label();
            SuspendLayout();
            // 
            // cache_clear
            // 
            cache_clear.Location = new Point(12, 12);
            cache_clear.Name = "cache_clear";
            cache_clear.Size = new Size(75, 23);
            cache_clear.TabIndex = 0;
            cache_clear.Text = "button1";
            cache_clear.UseVisualStyleBackColor = true;
            // 
            // soonorondeveloperhead
            // 
            soonorondeveloperhead.AutoSize = true;
            soonorondeveloperhead.Location = new Point(93, 16);
            soonorondeveloperhead.Name = "soonorondeveloperhead";
            soonorondeveloperhead.Size = new Size(216, 15);
            soonorondeveloperhead.TabIndex = 1;
            soonorondeveloperhead.Text = "Скоро, ну или на совести сборищка...";
            // 
            // Fixes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 44);
            Controls.Add(soonorondeveloperhead);
            Controls.Add(cache_clear);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Fixes";
            Text = "Glotok Launcher | Фиксы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cache_clear;
        private Label soonorondeveloperhead;
    }
}
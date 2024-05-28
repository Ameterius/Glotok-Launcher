namespace Glotok
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            play = new Button();
            play64 = new Button();
            jsgme = new Button();
            Fixes = new Button();
            placeholder = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)placeholder).BeginInit();
            SuspendLayout();
            // 
            // play
            // 
            play.Location = new Point(532, 374);
            play.Name = "play";
            play.Size = new Size(151, 23);
            play.TabIndex = 0;
            play.Text = "Запустить игру (x86)";
            play.UseVisualStyleBackColor = true;
            // 
            // play64
            // 
            play64.Location = new Point(375, 374);
            play64.Name = "play64";
            play64.Size = new Size(151, 23);
            play64.TabIndex = 1;
            play64.Text = "Запустить игру (x64)";
            play64.UseVisualStyleBackColor = true;
            // 
            // jsgme
            // 
            jsgme.Location = new Point(252, 374);
            jsgme.Name = "jsgme";
            jsgme.Size = new Size(117, 23);
            jsgme.TabIndex = 2;
            jsgme.Text = "Менеджер Модов";
            jsgme.UseVisualStyleBackColor = true;
            // 
            // Fixes
            // 
            Fixes.Location = new Point(12, 374);
            Fixes.Name = "Fixes";
            Fixes.Size = new Size(75, 23);
            Fixes.TabIndex = 3;
            Fixes.Text = "Фиксы";
            Fixes.UseVisualStyleBackColor = true;
            Fixes.Click += Fixes_Click;
            // 
            // placeholder
            // 
            placeholder.BackgroundImageLayout = ImageLayout.Stretch;
            placeholder.BorderStyle = BorderStyle.FixedSingle;
            placeholder.ImageLocation = "https://3dnews.ru/assets/external/illustrations/2024/03/06/1101329/0.jpg";
            placeholder.Location = new Point(12, 12);
            placeholder.Name = "placeholder";
            placeholder.Size = new Size(671, 356);
            placeholder.TabIndex = 4;
            placeholder.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 409);
            Controls.Add(placeholder);
            Controls.Add(Fixes);
            Controls.Add(jsgme);
            Controls.Add(play64);
            Controls.Add(play);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            Text = "Glotok Launcher";
            ((System.ComponentModel.ISupportInitialize)placeholder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button play;
        private Button play64;
        private Button jsgme;
        private Button Fixes;
        private PictureBox placeholder;
    }
}

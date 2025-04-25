namespace tetris
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            btplay = new Button();
            btSettings = new Button();
            btAbout = new Button();
            btExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(110, 55);
            label1.Name = "label1";
            label1.Size = new Size(188, 61);
            label1.TabIndex = 0;
            label1.Text = "ТЕТРИС";
            // 
            // btplay
            // 
            btplay.BackColor = Color.White;
            btplay.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btplay.Location = new Point(154, 136);
            btplay.Name = "btplay";
            btplay.Size = new Size(106, 46);
            btplay.TabIndex = 1;
            btplay.Text = "Начать Игру";
            btplay.UseVisualStyleBackColor = false;
            btplay.Click += btplay_Click;
            // 
            // btSettings
            // 
            btSettings.BackColor = Color.White;
            btSettings.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSettings.Location = new Point(154, 203);
            btSettings.Name = "btSettings";
            btSettings.Size = new Size(106, 49);
            btSettings.TabIndex = 2;
            btSettings.Text = "Найстройки";
            btSettings.UseVisualStyleBackColor = false;
            btSettings.Click += btSettings_Click;
            // 
            // btAbout
            // 
            btAbout.BackColor = Color.White;
            btAbout.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAbout.Location = new Point(154, 279);
            btAbout.Name = "btAbout";
            btAbout.Size = new Size(106, 45);
            btAbout.TabIndex = 3;
            btAbout.Text = "Об игре";
            btAbout.UseVisualStyleBackColor = false;
            btAbout.Click += btAbout_Click;
            // 
            // btExit
            // 
            btExit.BackColor = Color.White;
            btExit.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btExit.Location = new Point(154, 351);
            btExit.Name = "btExit";
            btExit.Size = new Size(106, 44);
            btExit.TabIndex = 4;
            btExit.Text = "Выход";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(418, 450);
            Controls.Add(btExit);
            Controls.Add(btAbout);
            Controls.Add(btSettings);
            Controls.Add(btplay);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Тетрис | Меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btplay;
        private Button btSettings;
        private Button btAbout;
        private Button btExit;
    }
}

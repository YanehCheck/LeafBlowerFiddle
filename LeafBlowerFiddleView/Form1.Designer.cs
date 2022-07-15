namespace LeafBlowerFiddleView {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonDigBot = new System.Windows.Forms.Button();
            this.labelDigAndCollect = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonTray = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelDigAndCollect = new System.Windows.Forms.Panel();
            this.labelDigBotDelay = new System.Windows.Forms.Label();
            this.numericUpDownDigAndCollectDelay = new System.Windows.Forms.NumericUpDown();
            this.panelGameWindowSearch = new System.Windows.Forms.Panel();
            this.labelTitleGameWindow = new System.Windows.Forms.Label();
            this.panelFoundText = new System.Windows.Forms.Panel();
            this.labelFoundGameWindow = new System.Windows.Forms.Label();
            this.buttonSearchGameWindow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClawMachineBotTitle = new System.Windows.Forms.Label();
            this.buttonClawBot = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelDigAndCollect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigAndCollectDelay)).BeginInit();
            this.panelGameWindowSearch.SuspendLayout();
            this.panelFoundText.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDigBot
            // 
            this.buttonDigBot.Location = new System.Drawing.Point(20, 81);
            this.buttonDigBot.Name = "buttonDigBot";
            this.buttonDigBot.Size = new System.Drawing.Size(94, 29);
            this.buttonDigBot.TabIndex = 0;
            this.buttonDigBot.Text = "Start";
            this.buttonDigBot.UseVisualStyleBackColor = true;
            this.buttonDigBot.Click += new System.EventHandler(this.buttonDigBot_Click);
            // 
            // labelDigAndCollect
            // 
            this.labelDigAndCollect.AutoSize = true;
            this.labelDigAndCollect.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDigAndCollect.ForeColor = System.Drawing.Color.Silver;
            this.labelDigAndCollect.Location = new System.Drawing.Point(3, 0);
            this.labelDigAndCollect.Name = "labelDigAndCollect";
            this.labelDigAndCollect.Size = new System.Drawing.Size(128, 18);
            this.labelDigAndCollect.TabIndex = 1;
            this.labelDigAndCollect.Text = "Dig and collect";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.buttonTray);
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 51);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeControlDraggableEvent);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(10, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(322, 20);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Leaf Blower Revolution Fiddle";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeControlDraggableEvent);
            // 
            // buttonTray
            // 
            this.buttonTray.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTray.Location = new System.Drawing.Point(701, 12);
            this.buttonTray.Name = "buttonTray";
            this.buttonTray.Size = new System.Drawing.Size(25, 25);
            this.buttonTray.TabIndex = 2;
            this.buttonTray.Text = "↓";
            this.buttonTray.UseVisualStyleBackColor = true;
            this.buttonTray.Click += new System.EventHandler(this.buttonTray_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMinimize.Location = new System.Drawing.Point(732, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(25, 25);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.Text = "🗕";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(763, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "x";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelDigAndCollect
            // 
            this.panelDigAndCollect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDigAndCollect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDigAndCollect.Controls.Add(this.labelDigBotDelay);
            this.panelDigAndCollect.Controls.Add(this.numericUpDownDigAndCollectDelay);
            this.panelDigAndCollect.Controls.Add(this.labelDigAndCollect);
            this.panelDigAndCollect.Controls.Add(this.buttonDigBot);
            this.panelDigAndCollect.Location = new System.Drawing.Point(10, 57);
            this.panelDigAndCollect.Name = "panelDigAndCollect";
            this.panelDigAndCollect.Size = new System.Drawing.Size(138, 121);
            this.panelDigAndCollect.TabIndex = 3;
            // 
            // labelDigBotDelay
            // 
            this.labelDigBotDelay.AutoSize = true;
            this.labelDigBotDelay.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDigBotDelay.ForeColor = System.Drawing.Color.Silver;
            this.labelDigBotDelay.Location = new System.Drawing.Point(38, 27);
            this.labelDigBotDelay.Name = "labelDigBotDelay";
            this.labelDigBotDelay.Size = new System.Drawing.Size(49, 18);
            this.labelDigBotDelay.TabIndex = 3;
            this.labelDigBotDelay.Text = "Delay";
            // 
            // numericUpDownDigAndCollectDelay
            // 
            this.numericUpDownDigAndCollectDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDigAndCollectDelay.Location = new System.Drawing.Point(14, 48);
            this.numericUpDownDigAndCollectDelay.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownDigAndCollectDelay.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownDigAndCollectDelay.Name = "numericUpDownDigAndCollectDelay";
            this.numericUpDownDigAndCollectDelay.Size = new System.Drawing.Size(105, 27);
            this.numericUpDownDigAndCollectDelay.TabIndex = 2;
            this.numericUpDownDigAndCollectDelay.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // panelGameWindowSearch
            // 
            this.panelGameWindowSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelGameWindowSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGameWindowSearch.Controls.Add(this.labelTitleGameWindow);
            this.panelGameWindowSearch.Controls.Add(this.panelFoundText);
            this.panelGameWindowSearch.Controls.Add(this.buttonSearchGameWindow);
            this.panelGameWindowSearch.Location = new System.Drawing.Point(10, 361);
            this.panelGameWindowSearch.Name = "panelGameWindowSearch";
            this.panelGameWindowSearch.Size = new System.Drawing.Size(138, 77);
            this.panelGameWindowSearch.TabIndex = 4;
            // 
            // labelTitleGameWindow
            // 
            this.labelTitleGameWindow.AutoSize = true;
            this.labelTitleGameWindow.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleGameWindow.ForeColor = System.Drawing.Color.Silver;
            this.labelTitleGameWindow.Location = new System.Drawing.Point(12, 0);
            this.labelTitleGameWindow.Name = "labelTitleGameWindow";
            this.labelTitleGameWindow.Size = new System.Drawing.Size(110, 18);
            this.labelTitleGameWindow.TabIndex = 1;
            this.labelTitleGameWindow.Text = "Find process";
            // 
            // panelFoundText
            // 
            this.panelFoundText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelFoundText.Controls.Add(this.labelFoundGameWindow);
            this.panelFoundText.Location = new System.Drawing.Point(20, 21);
            this.panelFoundText.Name = "panelFoundText";
            this.panelFoundText.Size = new System.Drawing.Size(94, 17);
            this.panelFoundText.TabIndex = 5;
            // 
            // labelFoundGameWindow
            // 
            this.labelFoundGameWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFoundGameWindow.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFoundGameWindow.ForeColor = System.Drawing.Color.Red;
            this.labelFoundGameWindow.Location = new System.Drawing.Point(0, 0);
            this.labelFoundGameWindow.Name = "labelFoundGameWindow";
            this.labelFoundGameWindow.Size = new System.Drawing.Size(94, 17);
            this.labelFoundGameWindow.TabIndex = 3;
            this.labelFoundGameWindow.Text = "Not Found!";
            this.labelFoundGameWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearchGameWindow
            // 
            this.buttonSearchGameWindow.Location = new System.Drawing.Point(20, 39);
            this.buttonSearchGameWindow.Name = "buttonSearchGameWindow";
            this.buttonSearchGameWindow.Size = new System.Drawing.Size(94, 29);
            this.buttonSearchGameWindow.TabIndex = 0;
            this.buttonSearchGameWindow.Text = "Search";
            this.buttonSearchGameWindow.UseVisualStyleBackColor = true;
            this.buttonSearchGameWindow.Click += new System.EventHandler(this.buttonSearchGameWindow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelClawMachineBotTitle);
            this.panel2.Controls.Add(this.buttonClawBot);
            this.panel2.Location = new System.Drawing.Point(154, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 77);
            this.panel2.TabIndex = 4;
            // 
            // labelClawMachineBotTitle
            // 
            this.labelClawMachineBotTitle.AutoSize = true;
            this.labelClawMachineBotTitle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClawMachineBotTitle.ForeColor = System.Drawing.Color.Silver;
            this.labelClawMachineBotTitle.Location = new System.Drawing.Point(20, 0);
            this.labelClawMachineBotTitle.Name = "labelClawMachineBotTitle";
            this.labelClawMachineBotTitle.Size = new System.Drawing.Size(81, 18);
            this.labelClawMachineBotTitle.TabIndex = 1;
            this.labelClawMachineBotTitle.Text = "Claw Bot";
            // 
            // buttonClawBot
            // 
            this.buttonClawBot.Location = new System.Drawing.Point(18, 27);
            this.buttonClawBot.Name = "buttonClawBot";
            this.buttonClawBot.Size = new System.Drawing.Size(94, 29);
            this.buttonClawBot.TabIndex = 0;
            this.buttonClawBot.Text = "Start";
            this.buttonClawBot.UseVisualStyleBackColor = true;
            this.buttonClawBot.Click += new System.EventHandler(this.buttonClawBot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelGameWindowSearch);
            this.Controls.Add(this.panelDigAndCollect);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDigAndCollect.ResumeLayout(false);
            this.panelDigAndCollect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigAndCollectDelay)).EndInit();
            this.panelGameWindowSearch.ResumeLayout(false);
            this.panelGameWindowSearch.PerformLayout();
            this.panelFoundText.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonDigBot;
        private Label labelDigAndCollect;
        private Panel panel1;
        private Button buttonClose;
        private Button buttonTray;
        private Button buttonMinimize;
        private Label labelTitle;
        private Panel panelDigAndCollect;
        private Label labelDigBotDelay;
        private NumericUpDown numericUpDownDigAndCollectDelay;
        private Panel panelGameWindowSearch;
        private Label labelFoundGameWindow;
        private Label labelTitleGameWindow;
        private Button buttonSearchGameWindow;
        private Panel panelFoundText;
        private Panel panel2;
        private Label labelClawMachineBotTitle;
        private Button buttonClawBot;
    }
}
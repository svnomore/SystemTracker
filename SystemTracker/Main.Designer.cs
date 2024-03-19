namespace SystemTracker
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
            components = new System.ComponentModel.Container();
            CPUUsageText = new Label();
            cycleTimer = new System.Windows.Forms.Timer(components);
            CPUNameText = new Label();
            MemoryTotalText = new Label();
            MemoryFreeText = new Label();
            MemoryVirtualText = new Label();
            SuspendLayout();
            // 
            // CPUUsageText
            // 
            CPUUsageText.AutoSize = true;
            CPUUsageText.Location = new Point(12, 29);
            CPUUsageText.Name = "CPUUsageText";
            CPUUsageText.Size = new Size(88, 17);
            CPUUsageText.TabIndex = 0;
            CPUUsageText.Text = "CPU Usage:";
            // 
            // cycleTimer
            // 
            cycleTimer.Interval = 2500;
            cycleTimer.Tick += CycleTimer_Tick;
            // 
            // CPUNameText
            // 
            CPUNameText.AutoSize = true;
            CPUNameText.Location = new Point(12, 9);
            CPUNameText.Name = "CPUNameText";
            CPUNameText.Size = new Size(80, 17);
            CPUNameText.TabIndex = 1;
            CPUNameText.Text = "CPU Name:";
            // 
            // MemoryTotalText
            // 
            MemoryTotalText.AutoSize = true;
            MemoryTotalText.Location = new Point(12, 64);
            MemoryTotalText.Name = "MemoryTotalText";
            MemoryTotalText.Size = new Size(112, 17);
            MemoryTotalText.TabIndex = 2;
            MemoryTotalText.Text = "Memory Total:";
            // 
            // MemoryFreeText
            // 
            MemoryFreeText.AutoSize = true;
            MemoryFreeText.Location = new Point(12, 81);
            MemoryFreeText.Name = "MemoryFreeText";
            MemoryFreeText.Size = new Size(104, 17);
            MemoryFreeText.TabIndex = 3;
            MemoryFreeText.Text = "Memory Free:";
            // 
            // MemoryVirtualText
            // 
            MemoryVirtualText.AutoSize = true;
            MemoryVirtualText.Location = new Point(12, 98);
            MemoryVirtualText.Name = "MemoryVirtualText";
            MemoryVirtualText.Size = new Size(128, 17);
            MemoryVirtualText.TabIndex = 4;
            MemoryVirtualText.Text = "Memory Virtual:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(464, 231);
            Controls.Add(MemoryVirtualText);
            Controls.Add(MemoryFreeText);
            Controls.Add(MemoryTotalText);
            Controls.Add(CPUNameText);
            Controls.Add(CPUUsageText);
            Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaximizeBox = false;
            MinimumSize = new Size(480, 270);
            Name = "Main";
            ShowIcon = false;
            Text = "SystemTracker v0.1";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CPUUsageText;
        private System.Windows.Forms.Timer cycleTimer;
        private Label CPUNameText;
        private Label MemoryTotalText;
        private Label MemoryFreeText;
        private Label MemoryVirtualText;
    }
}

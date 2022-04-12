
namespace serial_checker
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
            this.diskGroupBox = new System.Windows.Forms.GroupBox();
            this.diskLabel = new System.Windows.Forms.Label();
            this.motherboardGroupBox = new System.Windows.Forms.GroupBox();
            this.motherboardLabel = new System.Windows.Forms.Label();
            this.BiosGroupBox = new System.Windows.Forms.GroupBox();
            this.BiosLabel = new System.Windows.Forms.Label();
            this.GPUGroupBox = new System.Windows.Forms.GroupBox();
            this.GPULabel = new System.Windows.Forms.Label();
            this.RAMGroupBox = new System.Windows.Forms.GroupBox();
            this.RAMLabel = new System.Windows.Forms.Label();
            this.CPUGroupBox = new System.Windows.Forms.GroupBox();
            this.CPULabel = new System.Windows.Forms.Label();
            this.IPGroupBox = new System.Windows.Forms.GroupBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.MacAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.MacAddressLabel = new System.Windows.Forms.Label();
            this.copyGroupBox = new System.Windows.Forms.GroupBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.diskGroupBox.SuspendLayout();
            this.motherboardGroupBox.SuspendLayout();
            this.BiosGroupBox.SuspendLayout();
            this.GPUGroupBox.SuspendLayout();
            this.RAMGroupBox.SuspendLayout();
            this.CPUGroupBox.SuspendLayout();
            this.IPGroupBox.SuspendLayout();
            this.MacAddressGroupBox.SuspendLayout();
            this.copyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // diskGroupBox
            // 
            this.diskGroupBox.Controls.Add(this.diskLabel);
            this.diskGroupBox.Location = new System.Drawing.Point(12, 12);
            this.diskGroupBox.Name = "diskGroupBox";
            this.diskGroupBox.Size = new System.Drawing.Size(200, 100);
            this.diskGroupBox.TabIndex = 0;
            this.diskGroupBox.TabStop = false;
            this.diskGroupBox.Text = "Disk";
            // 
            // diskLabel
            // 
            this.diskLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskLabel.Location = new System.Drawing.Point(3, 19);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(194, 78);
            this.diskLabel.TabIndex = 0;
            this.diskLabel.Text = "Waiting";
            this.diskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motherboardGroupBox
            // 
            this.motherboardGroupBox.Controls.Add(this.motherboardLabel);
            this.motherboardGroupBox.Location = new System.Drawing.Point(218, 12);
            this.motherboardGroupBox.Name = "motherboardGroupBox";
            this.motherboardGroupBox.Size = new System.Drawing.Size(200, 100);
            this.motherboardGroupBox.TabIndex = 1;
            this.motherboardGroupBox.TabStop = false;
            this.motherboardGroupBox.Text = "Motherboard";
            // 
            // motherboardLabel
            // 
            this.motherboardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motherboardLabel.Location = new System.Drawing.Point(3, 19);
            this.motherboardLabel.Name = "motherboardLabel";
            this.motherboardLabel.Size = new System.Drawing.Size(194, 78);
            this.motherboardLabel.TabIndex = 0;
            this.motherboardLabel.Text = "Waiting";
            this.motherboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BiosGroupBox
            // 
            this.BiosGroupBox.Controls.Add(this.BiosLabel);
            this.BiosGroupBox.Location = new System.Drawing.Point(424, 12);
            this.BiosGroupBox.Name = "BiosGroupBox";
            this.BiosGroupBox.Size = new System.Drawing.Size(200, 100);
            this.BiosGroupBox.TabIndex = 2;
            this.BiosGroupBox.TabStop = false;
            this.BiosGroupBox.Text = "Bios";
            // 
            // BiosLabel
            // 
            this.BiosLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BiosLabel.Location = new System.Drawing.Point(3, 19);
            this.BiosLabel.Name = "BiosLabel";
            this.BiosLabel.Size = new System.Drawing.Size(194, 78);
            this.BiosLabel.TabIndex = 0;
            this.BiosLabel.Text = "Waiting";
            this.BiosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPUGroupBox
            // 
            this.GPUGroupBox.Controls.Add(this.GPULabel);
            this.GPUGroupBox.Location = new System.Drawing.Point(12, 118);
            this.GPUGroupBox.Name = "GPUGroupBox";
            this.GPUGroupBox.Size = new System.Drawing.Size(200, 100);
            this.GPUGroupBox.TabIndex = 3;
            this.GPUGroupBox.TabStop = false;
            this.GPUGroupBox.Text = "GPU";
            // 
            // GPULabel
            // 
            this.GPULabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPULabel.Location = new System.Drawing.Point(3, 19);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(194, 78);
            this.GPULabel.TabIndex = 0;
            this.GPULabel.Text = "Waiting";
            this.GPULabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RAMGroupBox
            // 
            this.RAMGroupBox.Controls.Add(this.RAMLabel);
            this.RAMGroupBox.Location = new System.Drawing.Point(218, 118);
            this.RAMGroupBox.Name = "RAMGroupBox";
            this.RAMGroupBox.Size = new System.Drawing.Size(200, 100);
            this.RAMGroupBox.TabIndex = 4;
            this.RAMGroupBox.TabStop = false;
            this.RAMGroupBox.Text = "RAM";
            // 
            // RAMLabel
            // 
            this.RAMLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RAMLabel.Location = new System.Drawing.Point(3, 19);
            this.RAMLabel.Name = "RAMLabel";
            this.RAMLabel.Size = new System.Drawing.Size(194, 78);
            this.RAMLabel.TabIndex = 0;
            this.RAMLabel.Text = "Waiting";
            this.RAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUGroupBox
            // 
            this.CPUGroupBox.Controls.Add(this.CPULabel);
            this.CPUGroupBox.Location = new System.Drawing.Point(424, 118);
            this.CPUGroupBox.Name = "CPUGroupBox";
            this.CPUGroupBox.Size = new System.Drawing.Size(200, 100);
            this.CPUGroupBox.TabIndex = 5;
            this.CPUGroupBox.TabStop = false;
            this.CPUGroupBox.Text = "CPU";
            // 
            // CPULabel
            // 
            this.CPULabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CPULabel.Location = new System.Drawing.Point(3, 19);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(194, 78);
            this.CPULabel.TabIndex = 0;
            this.CPULabel.Text = "Waiting";
            this.CPULabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPGroupBox
            // 
            this.IPGroupBox.Controls.Add(this.IPLabel);
            this.IPGroupBox.Location = new System.Drawing.Point(12, 224);
            this.IPGroupBox.Name = "IPGroupBox";
            this.IPGroupBox.Size = new System.Drawing.Size(200, 100);
            this.IPGroupBox.TabIndex = 4;
            this.IPGroupBox.TabStop = false;
            this.IPGroupBox.Text = "IP";
            // 
            // IPLabel
            // 
            this.IPLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IPLabel.Location = new System.Drawing.Point(3, 19);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(194, 78);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "Waiting";
            this.IPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MacAddressGroupBox
            // 
            this.MacAddressGroupBox.Controls.Add(this.MacAddressLabel);
            this.MacAddressGroupBox.Location = new System.Drawing.Point(218, 224);
            this.MacAddressGroupBox.Name = "MacAddressGroupBox";
            this.MacAddressGroupBox.Size = new System.Drawing.Size(200, 100);
            this.MacAddressGroupBox.TabIndex = 6;
            this.MacAddressGroupBox.TabStop = false;
            this.MacAddressGroupBox.Text = "Mac Address";
            // 
            // MacAddressLabel
            // 
            this.MacAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MacAddressLabel.Location = new System.Drawing.Point(3, 19);
            this.MacAddressLabel.Name = "MacAddressLabel";
            this.MacAddressLabel.Size = new System.Drawing.Size(194, 78);
            this.MacAddressLabel.TabIndex = 0;
            this.MacAddressLabel.Text = "Waiting";
            this.MacAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copyGroupBox
            // 
            this.copyGroupBox.Controls.Add(this.copyButton);
            this.copyGroupBox.Location = new System.Drawing.Point(424, 224);
            this.copyGroupBox.Name = "copyGroupBox";
            this.copyGroupBox.Size = new System.Drawing.Size(200, 100);
            this.copyGroupBox.TabIndex = 7;
            this.copyGroupBox.TabStop = false;
            this.copyGroupBox.Text = "COPY";
            // 
            // copyButton
            // 
            this.copyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyButton.Location = new System.Drawing.Point(3, 19);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(194, 78);
            this.copyButton.TabIndex = 8;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 336);
            this.Controls.Add(this.copyGroupBox);
            this.Controls.Add(this.MacAddressGroupBox);
            this.Controls.Add(this.IPGroupBox);
            this.Controls.Add(this.CPUGroupBox);
            this.Controls.Add(this.RAMGroupBox);
            this.Controls.Add(this.GPUGroupBox);
            this.Controls.Add(this.BiosGroupBox);
            this.Controls.Add(this.motherboardGroupBox);
            this.Controls.Add(this.diskGroupBox);
            this.Name = "MainForm";
            this.Text = "Serials Checker";
            this.diskGroupBox.ResumeLayout(false);
            this.motherboardGroupBox.ResumeLayout(false);
            this.BiosGroupBox.ResumeLayout(false);
            this.GPUGroupBox.ResumeLayout(false);
            this.RAMGroupBox.ResumeLayout(false);
            this.CPUGroupBox.ResumeLayout(false);
            this.IPGroupBox.ResumeLayout(false);
            this.MacAddressGroupBox.ResumeLayout(false);
            this.copyGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox diskGroupBox;
        private System.Windows.Forms.Label diskLabel;
        private System.Windows.Forms.GroupBox motherboardGroupBox;
        private System.Windows.Forms.Label motherboardLabel;
        private System.Windows.Forms.GroupBox BiosGroupBox;
        private System.Windows.Forms.Label BiosLabel;
        private System.Windows.Forms.GroupBox GPUGroupBox;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.GroupBox RAMGroupBox;
        private System.Windows.Forms.Label RAMLabel;
        private System.Windows.Forms.GroupBox CPUGroupBox;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.GroupBox IPGroupBox;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.GroupBox MacAddressGroupBox;
        private System.Windows.Forms.Label MacAddressLabel;
        private System.Windows.Forms.GroupBox copyGroupBox;
        private System.Windows.Forms.Button copyButton;
    }
}


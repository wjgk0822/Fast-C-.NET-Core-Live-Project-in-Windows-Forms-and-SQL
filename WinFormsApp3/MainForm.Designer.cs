namespace WinFormsApp3
{
    partial class MainForm
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.min_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.side_panel = new System.Windows.Forms.Panel();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.min_btn);
            this.top_panel.Controls.Add(this.close_btn);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(180, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(948, 75);
            this.top_panel.TabIndex = 1;
            // 
            // min_btn
            // 
            this.min_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min_btn.AutoSize = true;
            this.min_btn.BackgroundImage = global::WinFormsApp3.Properties.Resources.min_butt;
            this.min_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.min_btn.Location = new System.Drawing.Point(822, 3);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(30, 30);
            this.min_btn.TabIndex = 1;
            this.min_btn.UseVisualStyleBackColor = true;
            this.min_btn.Click += new System.EventHandler(this.min_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.AutoSize = true;
            this.close_btn.BackgroundImage = global::WinFormsApp3.Properties.Resources.close;
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close_btn.Location = new System.Drawing.Point(858, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(30, 30);
            this.close_btn.TabIndex = 0;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.SystemColors.GrayText;
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(180, 652);
            this.side_panel.TabIndex = 2;
            // 
            // bottom_panel
            // 
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(180, 612);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(948, 40);
            this.bottom_panel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 652);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.side_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel top_panel;
        private Panel side_panel;
        private Panel bottom_panel;
        private Button close_btn;
        private Button min_btn;
    }
}
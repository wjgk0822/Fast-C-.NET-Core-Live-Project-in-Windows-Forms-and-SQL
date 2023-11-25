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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Incoming letter");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Outgoing letter");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("My Letters", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("All folders", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.top_panel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Data_entry_btn = new System.Windows.Forms.Button();
            this.min_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.side_panel = new System.Windows.Forms.Panel();
            this.User_img_pic = new System.Windows.Forms.PictureBox();
            this.KJH = new System.Windows.Forms.Label();
            this.analogClock1 = new AnalogClock.AnalogClock();
            this.panel1 = new System.Windows.Forms.Panel();
            this.day_week_lbl = new System.Windows.Forms.Label();
            this.day_month_lbl = new System.Windows.Forms.Label();
            this.month_name_lbl = new System.Windows.Forms.Label();
            this.Year_num_lbl = new System.Windows.Forms.Label();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tree_panel = new System.Windows.Forms.Panel();
            this.collapse_btn = new System.Windows.Forms.Button();
            this.expand_btn = new System.Windows.Forms.Button();
            this.main_Tree_view = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.top_panel.SuspendLayout();
            this.side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_img_pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.tree_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.button4);
            this.top_panel.Controls.Add(this.button3);
            this.top_panel.Controls.Add(this.button2);
            this.top_panel.Controls.Add(this.Data_entry_btn);
            this.top_panel.Controls.Add(this.min_btn);
            this.top_panel.Controls.Add(this.close_btn);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(180, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(948, 75);
            this.top_panel.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WinFormsApp3.Properties.Resources.butt_background;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::WinFormsApp3.Properties.Resources.help;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(581, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 62);
            this.button4.TabIndex = 5;
            this.button4.Text = "Help F5";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WinFormsApp3.Properties.Resources.butt_background;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::WinFormsApp3.Properties.Resources.tools;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(447, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 62);
            this.button3.TabIndex = 4;
            this.button3.Text = "Tools F4";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WinFormsApp3.Properties.Resources.butt_background;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::WinFormsApp3.Properties.Resources.report;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(265, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reports F3";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Data_entry_btn
            // 
            this.Data_entry_btn.BackgroundImage = global::WinFormsApp3.Properties.Resources.butt_background;
            this.Data_entry_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Data_entry_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Data_entry_btn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Data_entry_btn.Image = global::WinFormsApp3.Properties.Resources.input;
            this.Data_entry_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Data_entry_btn.Location = new System.Drawing.Point(12, 10);
            this.Data_entry_btn.Name = "Data_entry_btn";
            this.Data_entry_btn.Size = new System.Drawing.Size(250, 62);
            this.Data_entry_btn.TabIndex = 2;
            this.Data_entry_btn.Text = "Data Entry F2";
            this.Data_entry_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Data_entry_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Data_entry_btn.UseVisualStyleBackColor = true;
            this.Data_entry_btn.Click += new System.EventHandler(this.Data_entry_btn_Click);
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
            this.side_panel.Controls.Add(this.User_img_pic);
            this.side_panel.Controls.Add(this.KJH);
            this.side_panel.Controls.Add(this.analogClock1);
            this.side_panel.Controls.Add(this.panel1);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(180, 652);
            this.side_panel.TabIndex = 2;
            // 
            // User_img_pic
            // 
            this.User_img_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_img_pic.Image = global::WinFormsApp3.Properties.Resources.Default_user;
            this.User_img_pic.Location = new System.Drawing.Point(13, 393);
            this.User_img_pic.Name = "User_img_pic";
            this.User_img_pic.Size = new System.Drawing.Size(150, 162);
            this.User_img_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User_img_pic.TabIndex = 5;
            this.User_img_pic.TabStop = false;
            // 
            // KJH
            // 
            this.KJH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KJH.Location = new System.Drawing.Point(12, 558);
            this.KJH.Name = "KJH";
            this.KJH.Size = new System.Drawing.Size(149, 38);
            this.KJH.TabIndex = 5;
            this.KJH.Text = "KJH";
            this.KJH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // analogClock1
            // 
            this.analogClock1.DrawHourHand = true;
            this.analogClock1.DrawHourHandShadow = true;
            this.analogClock1.DrawMinuteHand = true;
            this.analogClock1.DrawMinuteHandShadow = true;
            this.analogClock1.DrawRim = false;
            this.analogClock1.DrawSecondHand = true;
            this.analogClock1.DropShadowColor = System.Drawing.Color.Black;
            this.analogClock1.DropShadowOffset = new System.Drawing.Point(0, 0);
            this.analogClock1.FaceColorHigh = System.Drawing.Color.RoyalBlue;
            this.analogClock1.FaceColorLow = System.Drawing.Color.SkyBlue;
            this.analogClock1.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.analogClock1.FaceImage = null;
            this.analogClock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.analogClock1.HourHandColor = System.Drawing.Color.Gainsboro;
            this.analogClock1.HourHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.Location = new System.Drawing.Point(3, 0);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.WhiteSmoke;
            this.analogClock1.MinuteHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.NumeralColor = System.Drawing.Color.WhiteSmoke;
            this.analogClock1.RimColorHigh = System.Drawing.Color.RoyalBlue;
            this.analogClock1.RimColorLow = System.Drawing.Color.SkyBlue;
            this.analogClock1.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.analogClock1.SecondHandColor = System.Drawing.Color.Tomato;
            this.analogClock1.SecondHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.analogClock1.SecondHandTickStyle = AnalogClock.TickStyle.Normal;
            this.analogClock1.Size = new System.Drawing.Size(178, 178);
            this.analogClock1.TabIndex = 1;
            this.analogClock1.Time = new System.DateTime(((long)(0)));
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WinFormsApp3.Properties.Resources.calendar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.day_week_lbl);
            this.panel1.Controls.Add(this.day_month_lbl);
            this.panel1.Controls.Add(this.month_name_lbl);
            this.panel1.Controls.Add(this.Year_num_lbl);
            this.panel1.Location = new System.Drawing.Point(12, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 152);
            this.panel1.TabIndex = 0;
            // 
            // day_week_lbl
            // 
            this.day_week_lbl.BackColor = System.Drawing.Color.Transparent;
            this.day_week_lbl.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day_week_lbl.ForeColor = System.Drawing.Color.Black;
            this.day_week_lbl.Location = new System.Drawing.Point(15, 105);
            this.day_week_lbl.Name = "day_week_lbl";
            this.day_week_lbl.Size = new System.Drawing.Size(136, 34);
            this.day_week_lbl.TabIndex = 8;
            this.day_week_lbl.Text = "Sunday";
            this.day_week_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day_month_lbl
            // 
            this.day_month_lbl.BackColor = System.Drawing.Color.Transparent;
            this.day_month_lbl.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day_month_lbl.ForeColor = System.Drawing.Color.Black;
            this.day_month_lbl.Location = new System.Drawing.Point(46, 63);
            this.day_month_lbl.Name = "day_month_lbl";
            this.day_month_lbl.Size = new System.Drawing.Size(59, 42);
            this.day_month_lbl.TabIndex = 7;
            this.day_month_lbl.Text = "23";
            this.day_month_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // month_name_lbl
            // 
            this.month_name_lbl.AutoSize = true;
            this.month_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.month_name_lbl.ForeColor = System.Drawing.Color.White;
            this.month_name_lbl.Location = new System.Drawing.Point(100, 29);
            this.month_name_lbl.Name = "month_name_lbl";
            this.month_name_lbl.Size = new System.Drawing.Size(49, 25);
            this.month_name_lbl.TabIndex = 6;
            this.month_name_lbl.Text = "April";
            // 
            // Year_num_lbl
            // 
            this.Year_num_lbl.AutoSize = true;
            this.Year_num_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Year_num_lbl.ForeColor = System.Drawing.Color.White;
            this.Year_num_lbl.Location = new System.Drawing.Point(15, 29);
            this.Year_num_lbl.Name = "Year_num_lbl";
            this.Year_num_lbl.Size = new System.Drawing.Size(52, 25);
            this.Year_num_lbl.TabIndex = 5;
            this.Year_num_lbl.Text = "2022";
            // 
            // bottom_panel
            // 
            this.bottom_panel.Controls.Add(this.button1);
            this.bottom_panel.Controls.Add(this.button6);
            this.bottom_panel.Controls.Add(this.button5);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(180, 612);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(948, 40);
            this.bottom_panel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackgroundImage = global::WinFormsApp3.Properties.Resources.butt_background;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Image = global::WinFormsApp3.Properties.Resources.calc_butt;
            this.button6.Location = new System.Drawing.Point(688, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 34);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::WinFormsApp3.Properties.Resources.butt_background;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Image = global::WinFormsApp3.Properties.Resources.background;
            this.button5.Location = new System.Drawing.Point(762, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 34);
            this.button5.TabIndex = 0;
            this.button5.Text = "Background";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tree_panel
            // 
            this.tree_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tree_panel.Controls.Add(this.collapse_btn);
            this.tree_panel.Controls.Add(this.expand_btn);
            this.tree_panel.Controls.Add(this.main_Tree_view);
            this.tree_panel.Location = new System.Drawing.Point(192, 81);
            this.tree_panel.Name = "tree_panel";
            this.tree_panel.Size = new System.Drawing.Size(270, 404);
            this.tree_panel.TabIndex = 5;
            this.tree_panel.Visible = false;
            // 
            // collapse_btn
            // 
            this.collapse_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collapse_btn.Image = global::WinFormsApp3.Properties.Resources.collapse;
            this.collapse_btn.Location = new System.Drawing.Point(222, 3);
            this.collapse_btn.Name = "collapse_btn";
            this.collapse_btn.Size = new System.Drawing.Size(43, 29);
            this.collapse_btn.TabIndex = 8;
            this.collapse_btn.UseVisualStyleBackColor = true;
            this.collapse_btn.Click += new System.EventHandler(this.button7_Click);
            // 
            // expand_btn
            // 
            this.expand_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expand_btn.Image = global::WinFormsApp3.Properties.Resources.expand;
            this.expand_btn.Location = new System.Drawing.Point(173, 3);
            this.expand_btn.Name = "expand_btn";
            this.expand_btn.Size = new System.Drawing.Size(43, 29);
            this.expand_btn.TabIndex = 7;
            this.expand_btn.UseVisualStyleBackColor = true;
            this.expand_btn.Click += new System.EventHandler(this.expand_btn_Click);
            // 
            // main_Tree_view
            // 
            this.main_Tree_view.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_Tree_view.ImageIndex = 0;
            this.main_Tree_view.ImageList = this.imageList1;
            this.main_Tree_view.Location = new System.Drawing.Point(3, 3);
            this.main_Tree_view.Name = "main_Tree_view";
            treeNode1.ImageKey = "review.png";
            treeNode1.Name = "Incoming_letter";
            treeNode1.SelectedImageKey = "review.png";
            treeNode1.Text = "Incoming letter";
            treeNode2.ImageKey = "kToolStripButton2.Image.png";
            treeNode2.Name = "Outgoing_letter";
            treeNode2.SelectedImageKey = "kToolStripButton2.Image.png";
            treeNode2.Text = "Outgoing letter";
            treeNode3.Name = "My_Letters";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "My Letters";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "All folders";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "All folders";
            this.main_Tree_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.main_Tree_view.SelectedImageIndex = 0;
            this.main_Tree_view.Size = new System.Drawing.Size(262, 396);
            this.main_Tree_view.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dep_1.png");
            this.imageList1.Images.SetKeyName(1, "kToolStripButton2.Image.png");
            this.imageList1.Images.SetKeyName(2, "RadMenuItem2.png");
            this.imageList1.Images.SetKeyName(3, "review.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 652);
            this.Controls.Add(this.tree_panel);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.side_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_img_pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bottom_panel.ResumeLayout(false);
            this.tree_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel top_panel;
        private Panel side_panel;
        private Panel bottom_panel;
        private Button close_btn;
        private Button min_btn;
        private Button Data_entry_btn;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private Label day_week_lbl;
        private Label day_month_lbl;
        private Label month_name_lbl;
        private Label Year_num_lbl;
        private AnalogClock.AnalogClock analogClock1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox User_img_pic;
        private Label KJH;
        private Panel tree_panel;
        private TreeView main_Tree_view;
        private Button button1;
        private Button expand_btn;
        private Button collapse_btn;
        private ImageList imageList1;
    }
}
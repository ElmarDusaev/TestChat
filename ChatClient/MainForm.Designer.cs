namespace ChatClient
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
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.MessagesPanel = new System.Windows.Forms.Panel();
            this.MessagesListPanel = new System.Windows.Forms.Panel();
            this.MessagesItemsTbl = new System.Windows.Forms.TableLayoutPanel();
            this.MessageSendPanel = new System.Windows.Forms.Panel();
            this.Send = new System.Windows.Forms.Button();
            this.MessageInputPanel = new System.Windows.Forms.Panel();
            this.MessageText = new System.Windows.Forms.RichTextBox();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.UsersPanel = new System.Windows.Forms.Panel();
            this.UsersPic = new System.Windows.Forms.PictureBox();
            this.UsersLbl = new System.Windows.Forms.Label();
            this.StatusOnline = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MinimazeBtn = new System.Windows.Forms.Button();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CanvasPanel.SuspendLayout();
            this.MessagesPanel.SuspendLayout();
            this.MessagesListPanel.SuspendLayout();
            this.MessageSendPanel.SuspendLayout();
            this.NavPanel.SuspendLayout();
            this.UsersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPic)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Controls.Add(this.MessagesPanel);
            this.CanvasPanel.Controls.Add(this.NavPanel);
            this.CanvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanvasPanel.Location = new System.Drawing.Point(0, 76);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(1092, 657);
            this.CanvasPanel.TabIndex = 0;
            // 
            // MessagesPanel
            // 
            this.MessagesPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MessagesPanel.Controls.Add(this.MessagesListPanel);
            this.MessagesPanel.Controls.Add(this.MessageSendPanel);
            this.MessagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesPanel.Location = new System.Drawing.Point(232, 0);
            this.MessagesPanel.Name = "MessagesPanel";
            this.MessagesPanel.Size = new System.Drawing.Size(860, 657);
            this.MessagesPanel.TabIndex = 2;
            // 
            // MessagesListPanel
            // 
            this.MessagesListPanel.AutoScroll = true;
            this.MessagesListPanel.BackColor = System.Drawing.Color.White;
            this.MessagesListPanel.Controls.Add(this.MessagesItemsTbl);
            this.MessagesListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesListPanel.Location = new System.Drawing.Point(0, 0);
            this.MessagesListPanel.Margin = new System.Windows.Forms.Padding(25);
            this.MessagesListPanel.Name = "MessagesListPanel";
            this.MessagesListPanel.Size = new System.Drawing.Size(860, 575);
            this.MessagesListPanel.TabIndex = 0;
            // 
            // MessagesItemsTbl
            // 
            this.MessagesItemsTbl.AutoSize = true;
            this.MessagesItemsTbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MessagesItemsTbl.BackColor = System.Drawing.SystemColors.Window;
            this.MessagesItemsTbl.ColumnCount = 1;
            this.MessagesItemsTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MessagesItemsTbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessagesItemsTbl.Location = new System.Drawing.Point(0, 0);
            this.MessagesItemsTbl.Name = "MessagesItemsTbl";
            this.MessagesItemsTbl.RowCount = 1;
            this.MessagesItemsTbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessagesItemsTbl.Size = new System.Drawing.Size(860, 0);
            this.MessagesItemsTbl.TabIndex = 1;
            // 
            // MessageSendPanel
            // 
            this.MessageSendPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MessageSendPanel.Controls.Add(this.Send);
            this.MessageSendPanel.Controls.Add(this.MessageInputPanel);
            this.MessageSendPanel.Controls.Add(this.MessageText);
            this.MessageSendPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessageSendPanel.Location = new System.Drawing.Point(0, 575);
            this.MessageSendPanel.Name = "MessageSendPanel";
            this.MessageSendPanel.Size = new System.Drawing.Size(860, 82);
            this.MessageSendPanel.TabIndex = 2;
            // 
            // Send
            // 
            this.Send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Send.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Send.FlatAppearance.BorderSize = 0;
            this.Send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Image = global::ChatClient.Properties.Resources.unnamed__2_;
            this.Send.Location = new System.Drawing.Point(795, 12);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(50, 46);
            this.Send.TabIndex = 1;
            this.Send.UseVisualStyleBackColor = false;
            // 
            // MessageInputPanel
            // 
            this.MessageInputPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MessageInputPanel.Location = new System.Drawing.Point(29, 62);
            this.MessageInputPanel.Name = "MessageInputPanel";
            this.MessageInputPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MessageInputPanel.Size = new System.Drawing.Size(748, 2);
            this.MessageInputPanel.TabIndex = 2;
            // 
            // MessageText
            // 
            this.MessageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageText.Location = new System.Drawing.Point(29, 14);
            this.MessageText.Margin = new System.Windows.Forms.Padding(10);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(745, 44);
            this.MessageText.TabIndex = 1;
            this.MessageText.Text = "";
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NavPanel.Controls.Add(this.flowLayoutPanel1);
            this.NavPanel.Controls.Add(this.UsersPanel);
            this.NavPanel.Controls.Add(this.StatusOnline);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(232, 657);
            this.NavPanel.TabIndex = 0;
            // 
            // UsersPanel
            // 
            this.UsersPanel.Controls.Add(this.UsersPic);
            this.UsersPanel.Controls.Add(this.UsersLbl);
            this.UsersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersPanel.Location = new System.Drawing.Point(0, 0);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(232, 61);
            this.UsersPanel.TabIndex = 0;
            // 
            // UsersPic
            // 
            this.UsersPic.Image = global::ChatClient.Properties.Resources.users;
            this.UsersPic.Location = new System.Drawing.Point(32, 19);
            this.UsersPic.Name = "UsersPic";
            this.UsersPic.Size = new System.Drawing.Size(30, 28);
            this.UsersPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsersPic.TabIndex = 1;
            this.UsersPic.TabStop = false;
            // 
            // UsersLbl
            // 
            this.UsersLbl.AutoSize = true;
            this.UsersLbl.Location = new System.Drawing.Point(77, 24);
            this.UsersLbl.Name = "UsersLbl";
            this.UsersLbl.Size = new System.Drawing.Size(129, 20);
            this.UsersLbl.TabIndex = 0;
            this.UsersLbl.Text = "Участники чата";
            // 
            // StatusOnline
            // 
            this.StatusOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusOnline.ForeColor = System.Drawing.Color.LightCoral;
            this.StatusOnline.Location = new System.Drawing.Point(12, 601);
            this.StatusOnline.Name = "StatusOnline";
            this.StatusOnline.Size = new System.Drawing.Size(214, 32);
            this.StatusOnline.TabIndex = 2;
            this.StatusOnline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusOnline.DoubleClick += new System.EventHandler(this.StatusOnline_DoubleClick);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.AllowDrop = true;
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.Controls.Add(this.MinimazeBtn);
            this.HeaderPanel.Controls.Add(this.LogoPic);
            this.HeaderPanel.Controls.Add(this.CloseBtn);
            this.HeaderPanel.Controls.Add(this.WelcomeLbl);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1092, 76);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);
            this.HeaderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseUp);
            // 
            // MinimazeBtn
            // 
            this.MinimazeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimazeBtn.FlatAppearance.BorderSize = 0;
            this.MinimazeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.MinimazeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.MinimazeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimazeBtn.ForeColor = System.Drawing.Color.Red;
            this.MinimazeBtn.Location = new System.Drawing.Point(963, 0);
            this.MinimazeBtn.Name = "MinimazeBtn";
            this.MinimazeBtn.Size = new System.Drawing.Size(62, 61);
            this.MinimazeBtn.TabIndex = 5;
            this.MinimazeBtn.Text = "_";
            this.MinimazeBtn.UseVisualStyleBackColor = true;
            this.MinimazeBtn.Click += new System.EventHandler(this.MinimazeBtn_Click);
            // 
            // LogoPic
            // 
            this.LogoPic.Image = global::ChatClient.Properties.Resources._7_2_chat_png_hd;
            this.LogoPic.Location = new System.Drawing.Point(12, 0);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(70, 75);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPic.TabIndex = 4;
            this.LogoPic.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.Red;
            this.CloseBtn.Location = new System.Drawing.Point(1030, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(62, 61);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoEllipsis = true;
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.WelcomeLbl.Location = new System.Drawing.Point(108, 22);
            this.WelcomeLbl.MaximumSize = new System.Drawing.Size(800, 0);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(298, 36);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "добро пожаловать!";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 518);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 733);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать";
            this.CanvasPanel.ResumeLayout(false);
            this.MessagesPanel.ResumeLayout(false);
            this.MessagesListPanel.ResumeLayout(false);
            this.MessagesListPanel.PerformLayout();
            this.MessageSendPanel.ResumeLayout(false);
            this.NavPanel.ResumeLayout(false);
            this.UsersPanel.ResumeLayout(false);
            this.UsersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPic)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Panel MessagesPanel;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Panel MessageSendPanel;
        private System.Windows.Forms.Panel MessagesListPanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TableLayoutPanel MessagesItemsTbl;
        private System.Windows.Forms.RichTextBox MessageText;
        private System.Windows.Forms.Panel MessageInputPanel;
        private System.Windows.Forms.Panel UsersPanel;
        private System.Windows.Forms.PictureBox UsersPic;
        private System.Windows.Forms.Label UsersLbl;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Label StatusOnline;
        private System.Windows.Forms.Button MinimazeBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}


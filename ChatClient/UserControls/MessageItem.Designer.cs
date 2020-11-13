namespace ChatClient.UserControls
{
    partial class MessageItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftName = new System.Windows.Forms.Label();
            this.leftMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftName
            // 
            this.leftName.AutoSize = true;
            this.leftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.leftName.Location = new System.Drawing.Point(26, 7);
            this.leftName.Name = "leftName";
            this.leftName.Size = new System.Drawing.Size(51, 20);
            this.leftName.TabIndex = 0;
            this.leftName.Text = "label1";
            this.leftName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // leftMessage
            // 
            this.leftMessage.AutoSize = true;
            this.leftMessage.BackColor = System.Drawing.SystemColors.Info;
            this.leftMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftMessage.Location = new System.Drawing.Point(25, 27);
            this.leftMessage.MaximumSize = new System.Drawing.Size(360, 0);
            this.leftMessage.Name = "leftMessage";
            this.leftMessage.Padding = new System.Windows.Forms.Padding(15);
            this.leftMessage.Size = new System.Drawing.Size(94, 55);
            this.leftMessage.TabIndex = 1;
            this.leftMessage.Text = "label2";
            this.leftMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.leftMessage);
            this.Controls.Add(this.leftName);
            this.Name = "MessageItem";
            this.Size = new System.Drawing.Size(800, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leftName;
        private System.Windows.Forms.Label leftMessage;
    }
}

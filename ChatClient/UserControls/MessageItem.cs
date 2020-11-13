using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ChatCommonLib.Models;
using System.Windows.Forms;
using Message = ChatCommonLib.Models.Message;

namespace ChatClient.UserControls
{
    public enum MessagePos
    {
        Left, Right
    }
    public partial class MessageItem : UserControl
    {
        public MessageItem(Message messangerDTO, MessagePos pos)
        {
            InitializeComponent();

            GenerateControl(messangerDTO, pos);
        }

        private void GenerateControl(Message response, MessagePos pos)
        {
            switch (pos)
            {
                case MessagePos.Left:
                    leftName.Text = response.UserName;
                    leftMessage.Text = response.MessageContent;
                    break;

                case MessagePos.Right:
                    leftName.Text = response.UserName;
                    leftMessage.Text = response.MessageContent;
                    leftMessage.BackColor = Color.Honeydew;
                    leftName.Location = new Point(550 - leftName.PreferredWidth, leftName.Location.Y);
                    leftMessage.Location = new Point(550 - leftMessage.PreferredWidth, leftMessage.Location.Y);
                    break;
            }
        }
    }
}

using CharCommonLib.Models;
using ChatClient.UserControls;
using ChatClient.Utils;
using ChatCommonLib.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;
using System.Drawing;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = ChatCommonLib.Models.Message;

namespace ChatClient
{
    public partial class MainForm : Form
    {
        ClientWebSocket clientWebSocket;
        User user;
        Message message;

        public MainForm(User user)
        {
            InitializeComponent();
            InitControls(user);
            RunWebSocket();
        }

        private void InitControls(User user)
        {
            this.user = user;
            message = new Message();
            message.UserName = user.Name;
            message.Type = MessageType.Message;
            WelcomeLbl.Text = $"{message.UserName}, добро пожаловать";
        }

        public async void RunWebSocket()
        {
            try
            {
                clientWebSocket = new ClientWebSocket();
                await clientWebSocket.ConnectAsync(new Uri($"{ConfigurationManager.AppSettings["WSServer"]}/ws"), CancellationToken.None);

                StatusOnline.Text = "В СЕТИ";
                StatusOnline.ForeColor = Color.Green;

                var sending = Task.Run(() =>
                {
                    Send.Click += async (s, e) =>
                    {
                        if (clientWebSocket.State == WebSocketState.Open)
                        {
                            message.MessageContent = MessageText.Text;
                            var messageDto = JsonConvert.SerializeObject(message);
                            var bytes = Encoding.UTF8.GetBytes(messageDto);
                            await clientWebSocket.SendAsync(buffer: new ArraySegment<byte>(Encoding.UTF8.GetBytes(messageDto)),
                                    messageType: WebSocketMessageType.Text,
                                    endOfMessage: true,
                                    cancellationToken: CancellationToken.None);
                            MessageText.Text = "";
                        }
                    };

                });

                var receiving = Receiving();

                await Task.WhenAll(sending, receiving);

            }
            catch (Exception ex)
            {
                StatusOnline.Text = "ОТКЛЮЧЕН";
                StatusOnline.ForeColor = Color.Red;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task Receiving()
        {
            var buffer = new byte[1024 * 4];

            while (true)
            {
                var result = await clientWebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                if (result.MessageType == WebSocketMessageType.Text)
                {
                    string messageText = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    var response = JsonConvert.DeserializeObject<Message>(messageText);

                    MesssageOperation(response);
                }

                else if (result.MessageType == WebSocketMessageType.Close)
                {
                    await clientWebSocket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                    break;
                }
            }
        }

        private void MesssageOperation(Message response)
        {
            switch (response.Type)
            {
                case MessageType.Connect:
                    if (message.SocketId == null)
                    {
                        user.SocketId = response.SocketId;
                        message.SocketId = response.SocketId;
                        UserConnected();
                    }
                    break;

                case MessageType.Message:
                    AddMessageItem(response);
                    break;

                case MessageType.Disconnect:
                    break;

                case MessageType.Update:
                    flowLayoutPanel1.Controls.Clear();

                    foreach (var item in response.ChatRoomUsers)
                    {
                        ChatRoomUserControl control = new ChatRoomUserControl(item.Name);
                        flowLayoutPanel1.Controls.Add(control);
                    }

                    break;
            }
        }

        private void UserConnected()
        {
            ApiRestUtils.UserConnected(user);
        }


        int MessageRowCount = 1;

        private void AddMessageItem(Message response)
        {
                MessagePos pos = MessagePos.Left;

                if (response.SocketId == message.SocketId)
                            pos = MessagePos.Right;

                MessageItem item = new MessageItem(response, pos);
                MessagesItemsTbl.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                MessagesItemsTbl.Controls.Add(item,0, MessageRowCount);
                MessageRowCount++;
                MessagesListPanel.ScrollControlIntoView(item);
        }


        private void StatusOnline_DoubleClick(object sender, EventArgs e)
        {
            if (clientWebSocket.State == WebSocketState.Closed)
                RunWebSocket();
        }


        int mouseX, mouseY;
        bool mouseM;

        private void HeaderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseM = false;
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseM = true;
        }

        private void MinimazeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseM)
            {
                SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
        private async void CloseBtn_Click(object sender, EventArgs e)
        {
            await clientWebSocket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
            ApiRestUtils.UserDisConnected(user);
            Application.Exit();
        }

    }
}

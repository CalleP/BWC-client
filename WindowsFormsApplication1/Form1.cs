using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Threading;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private bool connected = false;
        private List<string> list = new List<string>();
        private List<string> Recievedlist = new List<string>();

        private WebSocket client;
        
        public Form1()
        {
            InitializeComponent();
            listBoxCommands.DataSource = list;
            timer1.Start();
        }
        
       //initializes the server
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                client = new WebSocket(textBoxAddress.Text);
                client.OnOpen += (sender2, e2) =>
                    connected = true;
                client.OnClose += (sender2, e2) =>
                    connected = false;
                client.OnMessage += (sender2, e2) =>
                    Recievedlist.Add(e2.Data);

                client.Connect();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                client.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GamePadState gamePadState = GamePad.GetState(PlayerIndex.One);
            
            if (gamePadState.IsConnected)
            {
                labelXbox.Text = "Controller is connected";
               
                if (gamePadState.Buttons.A == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    Forward();
                }

                else if (gamePadState.Buttons.B == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    Back();
                }

                else if (gamePadState.Buttons.LeftShoulder == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    Left();
                }

                else if (gamePadState.Buttons.RightShoulder == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    Right();
                }

                else if (gamePadState.Buttons.X == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    Sonar();
                }
            }
            
            else labelXbox.Text = "Controller is not connected";
            
            if (connected) labelConnected.Text = "Connected";
            else labelConnected.Text = "Not Connected";
        }
        
        void Send(String command)
        {
            if (connected)
            {
                client.Send(command);
                list.Add(command);
                RefreshList();
            }
        }

        void Forward()
        {
            Send("forward");
        }

        void Left()
        {
            Send("left");
        }

        void Right()
        {
            Send("right");
        }

        void Back()
        {
            Send("back");
        }

        void Sonar()
        {
            Send("GetSonar");
        }

        void RefreshList()
        {
            listBoxRecieved.DataSource = null;
            listBoxRecieved.DataSource = Recievedlist;
            int visibleItems = listBoxRecieved.ClientSize.Height / listBoxRecieved.ItemHeight;
            listBoxRecieved.TopIndex = Math.Max(listBoxRecieved.Items.Count - visibleItems + 1, 0);

            listBoxCommands.DataSource = null;
            listBoxCommands.DataSource = list;
            int visibleItems2 = listBoxCommands.ClientSize.Height / listBoxCommands.ItemHeight;
            listBoxCommands.TopIndex = Math.Max(listBoxCommands.Items.Count - visibleItems2 + 1, 0);
        }

        private void btnForward_MouseDown(object sender, MouseEventArgs e)
        {
            Forward();
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            Left();
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            Right();
        }

        private void btnBack_MouseDown(object sender, MouseEventArgs e)
        {
            Back();
        }

        private void btnSonar_Click(object sender, EventArgs e)
        {
            Sonar();
        }
    }
}

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
        
        private WebSocket client;
        
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = list;
            timer1.Start();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                client = new WebSocket(textBox1.Text);

                client.OnOpen += (sender2, e2) =>
                 connected = true;

                client.OnClose += (sender2, e2) =>
                 connected = false;

                client.Connect();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (connected) client.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GamePadState gamePadState = GamePad.GetState(PlayerIndex.One);
            
            if (gamePadState.IsConnected)
            {
                label2.Text = "Controller is connected";
               
                if (connected)
                {
                   
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
                }
                
            }
            else label2.Text = "Controller is not connected";

            if (connected) label3.Text = "Connected";
            else label3.Text = "Not Connected";
            
            Thread.Sleep(100);
        }
        
        void Forward()
        {
            if (connected)
            {
                client.Send("forward");
                list.Add("forward");
                Refresh();
            }
        }

        void Left()
        {
            if (connected)
            {
                client.Send("left");
                list.Add("left");
                Refresh();
            }
        }

        void Right()
        {
            if (connected)
            {
                client.Send("right");
                list.Add("right");
                Refresh();
            }
        }

        void Back()
        {
            if (connected)
            {
                client.Send("back");
                list.Add("back");
                Refresh();
            }
        }

        void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Forward();
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            Left();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Right();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            Back();
        }
    }
}

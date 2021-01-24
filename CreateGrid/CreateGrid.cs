using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace CreateGrid
{
    public partial class CreateGrid : Form
    {
        private int _tempNum;
        public CreateGrid()
        {
            InitializeComponent();
        }

        private void CreateGrid_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            for (int i = 0; i < 81; i++)
            {
                //有几条数据，就创建几个按钮
                Button btn = new Button();
                _tempNum = i + 1;
                btn.Name = "At" + _tempNum + "";
                btn.Size = new Size(25, 25);
                btn.BackColor = Color.AliceBlue;
                btn.Text = "0";
                ButtonPanel.AutoScroll = true;
                ButtonPanel.Controls.Add(btn);
                btn.Click += button1_Click;
                //btn.MouseDown += button1_MouseDown;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "0")
            {
                btn.Text = "1";
                btn.BackColor = Color.BurlyWood;
                Console.WriteLine(btn.Name);
            }
            else if (btn.Text == "1")
            {
                btn.Text = "0";
                btn.BackColor = Color.AliceBlue;
                Console.WriteLine(btn.Name);
            }
        }

        private void CreateJson_Click(object sender, EventArgs e)
        {
            if (LevelNameBox.Text == "")
            {
                MessageBox.Show("Please Input The LevelName!", "Warning");
                return;
            }
            JsonClassList cl = new JsonClassList();
            cl.gridClasses = new List<GridClass>();
            //遍历控件集合
            foreach (Control control in ButtonPanel.Controls)
            {
                //如果控件是按钮
                if (control is Button)
                {
                    //强转
                    Button btn = (Button)control;
                    GridClass gc = new GridClass();
                    gc.location = btn.Name;
                    gc.status = btn.Text;
                    cl.gridClasses.Add(gc);
                
                }
            }
            string convertedJson = JsonConvert.SerializeObject(cl);
            string relativePath = System.Windows.Forms.Application.StartupPath + "\\" + LevelNameBox.Text + ".json";
            //string jsonFileName = LevelNameBox.Text + ".json";
            using (StreamWriter sw = new StreamWriter(relativePath, false))
            {
                sw.Write(convertedJson);
            }
            MessageBox.Show("Json Create Successfu!", "创建成功");
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LevelNameBox.Text = "";
            foreach (Control control in ButtonPanel.Controls)
            {
                //如果控件是按钮
                if (control is Button)
                {
                    //强转
                    Button btn = (Button)control;
                    btn.Text = "0";
                    btn.BackColor = Color.AliceBlue;
                }
            }
        }
    }
}

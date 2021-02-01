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
        private int _tempNum = 0;
        public GridList cl = new GridList();
        
        public CreateGrid()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Alt)
            {
                Button btn = sender as Button;
                if (btn.Text == "0")
                {
                    btn.Text = "1";
                    btn.BackColor = Color.BurlyWood;
                    //Console.WriteLine(btn.Name);
                }
                else if (btn.Text == "1")
                {
                    btn.Text = "0";
                    btn.BackColor = Color.AliceBlue;
                }
            }
        }


        private void CreateGrid_Load(object sender, EventArgs e)
        {
            cl.gridDetails = new List<GridDetail>();
            ElementPanel.Visible = false;
            ButtonPanel.Visible = false;
            BarrierCreatePanel.Visible = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            for (int i = 0; i < 81; i++) //生成按钮
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
                btn.MouseEnter += button1_MouseEnter;


            }

            for (int i = 0; i < 81; i++)
            {
                ComboBox cb = new ComboBox();
                cb.Size = new Size(50, 30);
                cb.Margin = new Padding(1, 15, 1, 15);
                cb.Items.Add("薄冰");
                cb.Items.Add("中冰");
                cb.Items.Add("厚冰");
                cb.Items.Add("豆荚");
                cb.Items.Add("魔藤");
                cb.Items.Add("灰球");
                cb.Items.Add("传送");
                cb.Items.Add("礼盒");
                cb.Font = new System.Drawing.Font("宋体", 8.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                cb.FlatStyle = FlatStyle.Standard;
                cb.DropDownHeight = 80;
                BarrierCreatePanel.AutoScroll = true;
                BarrierCreatePanel.Controls.Add(cb);
            }

            for (int i = 0; i < 81; i++) //生成元素
            {
                ComboBox cb = new ComboBox();
                cb.Size = new Size(50, 30);
                cb.Margin = new Padding(1, 15, 1, 15);
                cb.Items.Add("小熊");
                cb.Items.Add("猫猫");
                cb.Items.Add("小鸡");
                cb.Items.Add("狐狸");
                cb.Items.Add("青蛙");
                cb.Items.Add("河马");

                cb.Items.Add("LR熊");
                cb.Items.Add("LR猫");
                cb.Items.Add("LR鸡");
                cb.Items.Add("LR狐");
                cb.Items.Add("LR蛙");
                cb.Items.Add("LR马");

                cb.Items.Add("UD熊");
                cb.Items.Add("UD猫");
                cb.Items.Add("UD鸡");
                cb.Items.Add("UD狐");
                cb.Items.Add("UD蛙");
                cb.Items.Add("UD马");

                cb.Items.Add("炸熊");
                cb.Items.Add("炸猫");
                cb.Items.Add("炸鸡");
                cb.Items.Add("炸狐");
                cb.Items.Add("炸蛙");
                cb.Items.Add("炸马");

                cb.Items.Add("魔鸟");

                cb.Font = new System.Drawing.Font("宋体", 8.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                cb.FlatStyle = FlatStyle.Standard;
                cb.DropDownHeight = 80;
                ElementPanel.AutoScroll = true;
                ElementPanel.Controls.Add(cb);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "0")
            {
                btn.Text = "1";
                btn.BackColor = Color.BurlyWood;
                //Console.WriteLine(btn.Name);
            }
            else if (btn.Text == "1")
            {
                btn.Text = "0";
                btn.BackColor = Color.AliceBlue;
            }
            
        }
        private void FillJsonClass()
        {
            //遍历控件集合
            foreach (Control control in ButtonPanel.Controls)
            {
                //如果控件是按钮
                if (control is Button)
                {
                    //强转
                    Button btn = (Button)control;
                    GridDetail gc = new GridDetail();
                    gc.Location = btn.Name;
                    gc.Status = btn.Text;
                    cl.gridDetails.Add(gc);
                }
            }
        }
        private void CreateJson_Click(object sender, EventArgs e)
        {
            if (LevelNameBox.Text == "")
            {
                MessageBox.Show("请输入关卡名称!", "Warning");
                return;
            }
            if (cl.gridDetails != null)
            {
                //再次生成Json
                for (int i = 0; i < ElementPanel.Controls.Count; i++)
                {
                    if (cl.gridDetails[i].Status == "1")
                    {
                        if (ElementPanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                            if (cbb.SelectedItem != null)
                            {
                                cl.gridDetails[i].ElementType = cbb.SelectedItem.ToString();
                            }

                            ComboBox cbb2 = (ComboBox)BarrierCreatePanel.Controls[i];
                            if (cbb2.SelectedItem !=null)
                            {
                            cl.gridDetails[i].BarrierType = cbb2.SelectedItem.ToString();
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

            }
            string convertedJson = JsonConvert.SerializeObject(cl);
            string relativePath = System.Windows.Forms.Application.StartupPath + "\\" + LevelNameBox.Text + ".json";
            //string jsonFileName = LevelNameBox.Text + ".json";
            using (StreamWriter sw = new StreamWriter(relativePath, false))
            {
                sw.Write(convertedJson);
            }
            MessageBox.Show("Json创建成功!", "创建成功");


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

            foreach (Control control in ElementPanel.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cbb = (ComboBox)control;
                    cbb.SelectedIndex = -1;
                    cbb.Enabled = true;
                }
            }

            foreach (Control control in BarrierCreatePanel.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cbb = (ComboBox)control;
                    cbb.SelectedIndex = -1;
                    cbb.Enabled = true;
                }
            }

        }


        private void CreateGridButton_Click(object sender, EventArgs e)
        {
            ButtonPanel.Visible = true;
            BarrierCreatePanel.Visible = false;
            ElementPanel.Visible = false;
        }



        private void SwitchToElement_Click(object sender, EventArgs e)
        {
            cl.gridDetails.Clear();
            FillJsonClass();
            if (cl.gridDetails == null)
            {
                MessageBox.Show("尚未设计地图!", "Warning");
                return;
            }
            BarrierCreatePanel.Visible = false;
            if (cl != null)
            {
                for (int i = 0; i < ElementPanel.Controls.Count; i++)
                {
                    if (cl.gridDetails[i].Status == "0")
                    {
                        if (ElementPanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                            cbb.Enabled = false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (cl.gridDetails[i].Status == "1")
                    {
                        if (ElementPanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                            cbb.Enabled = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            ButtonPanel.Visible = false;
            ElementPanel.Visible = true;
        }

        private void BarrierButton_Click(object sender, EventArgs e)
        {
            cl.gridDetails.Clear();
            FillJsonClass();
            if (cl.gridDetails == null)
            {
                MessageBox.Show("尚未设计地图!", "Warning");
                return;
            }
            ElementPanel.Visible = false;
            ButtonPanel.Visible = false;
            BarrierCreatePanel.Visible = true;

            if (cl != null)
            {
                for (int i = 0; i < BarrierCreatePanel.Controls.Count; i++)
                {
                    if (cl.gridDetails[i].Status == "0")
                    {
                        if (BarrierCreatePanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)BarrierCreatePanel.Controls[i];
                            cbb.Enabled = false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (cl.gridDetails[i].Status == "1")
                    {
                        if (BarrierCreatePanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)BarrierCreatePanel.Controls[i];
                            cbb.Enabled = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

    }
}

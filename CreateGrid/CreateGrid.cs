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
        public JsonClassList cl = new JsonClassList();
        public CreateGrid()
        {
            InitializeComponent();
        }

        private void CreateGrid_Load(object sender, EventArgs e)
        {
            ElementPanel.Visible = false;
            ButtonPanel.Visible = false;
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

                cb.Font = new System.Drawing.Font("幼圆", 8.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
                //Console.WriteLine(btn.Name);
            }
        }
        private void FillJsonClass()
        {
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
                    gc.Location = btn.Name;
                    gc.Status = btn.Text;
                    cl.gridClasses.Add(gc);
                }
            }
        }
        private void CreateJson_Click(object sender, EventArgs e)
        {
            if (ElementPanel.Visible == false)
            {
                MessageBox.Show("请先设计好Json类型!", "Warning");
                return;
            }


            if (LevelNameBox.Text == "")
            {
                MessageBox.Show("请输入关卡名称!", "Warning");
                return;
            }
            #region trashFile
            //cl.gridClasses = new List<GridClass>();
            ////遍历控件集合
            //foreach (Control control in ButtonPanel.Controls)
            //{
            //    //如果控件是按钮
            //    if (control is Button)
            //    {
            //        //强转
            //        Button btn = (Button)control;
            //        GridClass gc = new GridClass();
            //        gc.location = btn.Name;
            //        gc.status = btn.Text;
            //        cl.gridClasses.Add(gc);
            //    }
            //}
            #endregion
            if (cl.gridClasses != null)
            {
                //再次生成Json
                for (int i = 0; i < ElementPanel.Controls.Count; i++)
                {
                    if (cl.gridClasses[i].Status == "1")
                    {
                        if (ElementPanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                            cl.gridClasses[i].ElementType = cbb.SelectedItem.ToString();
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
            JsonPath.Text = "";
            ChooseJson.Enabled = true;
            CreateElementButton.Enabled = true;
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
        }

        private void CreateElementButton_Click(object sender, EventArgs e)
        {
            if (JsonPath.Text == "")
            {
                MessageBox.Show("Json地图尚未载入!", "Warning");
                return;
            }
            ButtonPanel.Visible = false;
            ElementPanel.Visible = true;
        }

        private void CreateGridButton_Click(object sender, EventArgs e)
        {
            ButtonPanel.Visible = true;
            ElementPanel.Visible = false;
        }

        private void ChooseJson_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.RestoreDirectory = true;
            openFD.Filter = "Json文件(*.json)|*.json|所有文件(*.*)|*.*";
            if (DialogResult.OK == openFD.ShowDialog())
            {
                JsonPath.Text = openFD.FileName;
            }

        }

        private void SwitchToElement_Click(object sender, EventArgs e)
        {
            FillJsonClass();
            if (cl.gridClasses == null)
            {
                MessageBox.Show("尚未设计地图!", "Warning");
                return;
            }
            JsonPath.Text = "已由现存地图Json直接生成！";
            ChooseJson.Enabled = false;
            CreateElementButton.Enabled = false;
            if (cl != null)
            {
                for (int i = 0; i < ElementPanel.Controls.Count; i++)
                {
                    if (cl.gridClasses[i].Status == "0")
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
                }
            }
            ButtonPanel.Visible = false;
            ElementPanel.Visible = true;
        }
    }
}

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
        public GridList cl = new GridList();
        public static string dragJsonFilePath;

        private string jsonFolderPath;

        public CreateGrid()
        {
            jsonFolderPath = Application.StartupPath + "\\" + "JsonFile";
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
            if (!File.Exists("userInfo.config")) //创建配置文件
            {
                File.Create("userInfo.config");
            }

            if (Directory.Exists(jsonFolderPath))
            {
                UpdateListbox();
            }
            else
            {
                Directory.CreateDirectory(jsonFolderPath);
                JsonList.Items.Add("尚未创建Json文件。");
            }

            int _tempNum = 0;
            dragJsonFilePath = "";
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

                cb.Items.Add("魔鸟");
                cb.Items.Add("豆荚");
                cb.Items.Add("雪块1");
                cb.Items.Add("雪块2");
                cb.Items.Add("雪块3");
                cb.Items.Add("灰球");

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
            Console.WriteLine(btn.Name);
            if (btn.Text == "0")
            {
                btn.Text = "1";
                btn.BackColor = Color.BurlyWood;
            }
            else if (btn.Text == "1")
            {
                btn.Text = "2";
                btn.BackColor = Color.BurlyWood;
            }
            else if (btn.Text == "2")
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
                    if (((Button)ButtonPanel.Controls[i]).Text == "1" || ((Button)ButtonPanel.Controls[i]).Text == "2")
                    {
                        if (ElementPanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                            if (cbb.SelectedItem != null)
                            {
                                cl.gridDetails[i].ElementType = cbb.SelectedItem.ToString();
                            }

                            ComboBox cbb2 = (ComboBox)BarrierCreatePanel.Controls[i];
                            if (cbb2.SelectedItem != null)
                            {
                                cl.gridDetails[i].BarrierType = cbb2.SelectedItem.ToString();
                            }
                        }
                        else
                        {
                            if (ElementPanel.Controls[i] is ComboBox)
                            {
                                ((ComboBox)ElementPanel.Controls[i]).SelectedItem = null;
                                ((ComboBox)BarrierCreatePanel.Controls[i]).SelectedItem = null;

                            }
                        }
                    }
                }

            }
            string convertedJson = JsonConvert.SerializeObject(cl);
            if (!Directory.Exists(jsonFolderPath))
            {
                Directory.CreateDirectory(jsonFolderPath);
            }
            string jsonPath = jsonFolderPath + "\\" + LevelNameBox.Text + ".json";
            using (StreamWriter sw = new StreamWriter(jsonPath, false))
            {
                sw.Write(convertedJson);
            }
            MessageBox.Show("Json创建成功!", "创建成功");

            UpdateListbox();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void ResetData()
        {
            LevelNameBox.Text = "";
            this.Text = "CreateGrid";
            UpdateListbox();
            JsonList.SelectedIndex = -1;
            SearchJsonName.Text = "";
            cl.gridDetails.Clear();
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
                    if (((Button)ButtonPanel.Controls[i]).Text == "0")
                    {
                        if (ElementPanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                            cbb.SelectedItem = null;
                            cbb.Enabled = false;
                        }
                    }
                    else if (((Button)ButtonPanel.Controls[i]).Text == "1" || ((Button)ButtonPanel.Controls[i]).Text == "2")
                    {
                        if (ElementPanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                            cbb.Enabled = true;
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
                    if (((Button)ButtonPanel.Controls[i]).Text == "0")
                    {
                        if (BarrierCreatePanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)BarrierCreatePanel.Controls[i];
                            cbb.SelectedItem = null;
                            cbb.Enabled = false;
                        }
                    }
                    else if (((Button)ButtonPanel.Controls[i]).Text == "1" || ((Button)ButtonPanel.Controls[i]).Text == "2")
                    {
                        if (BarrierCreatePanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)BarrierCreatePanel.Controls[i];
                            cbb.Enabled = true;
                        }
                    }
                }
            }
        }

        private void CreateGrid_DragEnter(object sender, DragEventArgs e)
        {
            //只允许文件拖放
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void CreateGrid_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] rs = (string[])e.Data.GetData(DataFormats.FileDrop);
                dragJsonFilePath = rs[0];
                LevelNameBox.Text = Path.GetFileNameWithoutExtension(dragJsonFilePath);
                this.Text = "CreateGrid" + " 文件: " + dragJsonFilePath;
                FillAllPanel(rs[0]);
            }
        }

        private void FillAllPanel(string jsonFilePath)
        {
            StringBuilder sb = new StringBuilder();
            cl = null;
            using (StreamReader sr = new StreamReader(jsonFilePath, false))
            {
                sb.Append(sr.ReadToEnd());
            }
            //反序列化
            cl = JsonConvert.DeserializeObject<GridList>(sb.ToString());
            //开始三个遍历，把数据放到面板里面
            if (cl != null)
            {
                //读取按钮面板
                for (int i = 0; i < ButtonPanel.Controls.Count; i++)
                {
                    if (cl.gridDetails[i].Status == "0")
                    {
                        if (ButtonPanel.Controls[i] is Button)
                        {
                            Button btn = (Button)ButtonPanel.Controls[i];
                            btn.Text = "0";
                            btn.BackColor = Color.AliceBlue;
                        }
                    }
                    else if (cl.gridDetails[i].Status == "1")
                    {
                        if (ButtonPanel.Controls[i] is Button)
                        {
                            Button btn = (Button)ButtonPanel.Controls[i];
                            btn.Text = "1";
                            btn.BackColor = Color.BurlyWood;
                        }
                    }
                    else if (cl.gridDetails[i].Status == "2")
                    {
                        if (ButtonPanel.Controls[i] is Button)
                        {
                            Button btn = (Button)ButtonPanel.Controls[i];
                            btn.Text = "2";
                            btn.BackColor = Color.BurlyWood;
                        }
                    }
                }

                //读取元素面板
                for (int i = 0; i < ElementPanel.Controls.Count; i++)
                {
                    if (cl.gridDetails[i].ElementType != null)
                    {
                        if (ElementPanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                            cbb.SelectedItem = cl.gridDetails[i].ElementType;
                            cbb.Enabled = true;
                        }
                    }
                    else
                    {
                        if (ElementPanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                            cbb.SelectedItem = null;
                            cbb.Enabled = false;
                        }
                    }
                }

                //读取障碍物面板
                for (int i = 0; i < BarrierCreatePanel.Controls.Count; i++)
                {
                    if (cl.gridDetails[i].BarrierType != null)
                    {
                        if (BarrierCreatePanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)BarrierCreatePanel.Controls[i];
                            cbb.SelectedItem = cl.gridDetails[i].BarrierType;
                            cbb.Enabled = true;
                        }
                    }
                    else
                    {
                        if (BarrierCreatePanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)BarrierCreatePanel.Controls[i];
                            cbb.SelectedItem = null;
                            cbb.Enabled = false;
                        }

                    }
                }
            }

            //把按钮面板显示出来
            ButtonPanel.Visible = true;
            BarrierCreatePanel.Visible = false;
            ElementPanel.Visible = false;
        }

        private void UpdateListbox()
        {
            JsonList.Items.Clear();
            string[] jsonFiles = Directory.GetFiles(jsonFolderPath);
            for (int i = 0; i < jsonFiles.Length; i++)
            {
                JsonList.Items.Add(Path.GetFileName(jsonFiles[i]));
            }
        }

        private void JsonList_DoubleClick(object sender, EventArgs e)
        {
            cl = null;

            if (JsonList.SelectedItem != null && JsonList.SelectedIndex != -1)
            {
                FillAllPanel(jsonFolderPath + "\\" + JsonList.SelectedItem);
                LevelNameBox.Text = Path.GetFileNameWithoutExtension(JsonList.SelectedItem.ToString());
                this.Text = "CreateGrid" + " 文件: " + JsonList.SelectedItem;
            }
        }

        private void SearchJsonButton_Click(object sender, EventArgs e)
        {
            List<string> searchList = new List<string>();
            if (SearchJsonName.Text != "")
            {
                foreach (string jsonItems in JsonList.Items)
                {
                    if (jsonItems.Contains(SearchJsonName.Text))
                    {
                        searchList.Add(jsonItems.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("尚未输入查询条件!", "Warning");
                return;
            }

            if (searchList.Count > 0) //如果找到了相应的内容
            {
                JsonList.Items.Clear();
                foreach (var jsonName in searchList)
                {
                    JsonList.Items.Add(jsonName);
                }
            }
            else
            {
                MessageBox.Show("没有找到!", "Warning");
                return;
            }
        }

        private void SearchJsonName_MouseClick(object sender, MouseEventArgs e)
        {
            SearchJsonName.Text = "";
        }

    }
}

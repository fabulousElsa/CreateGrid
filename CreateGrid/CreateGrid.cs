using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading;

namespace CreateGrid
{
    public partial class CreateGrid : Form
    {
        public GridList cl = new GridList();
        public static string DragJsonFilePath;

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
            //if (!File.Exists("ReadMe.txt")) //创建配置文件
            //{
            //    File.Create("ReadMe.txt");
            //}

            if (Directory.Exists(jsonFolderPath))
            {
                UpdateListbox();
            }
            else
            {
                Directory.CreateDirectory(jsonFolderPath);
                JsonList.Items.Add("尚未创建Json文件。");
            }

            DragJsonFilePath = "";
            cl.GridDetails = new List<GridDetail>();
            cl.MissionDetails = new List<MissionDetail>();
            cl.DuranceDetails = new List<DuranceDetail>();
            ElementPanel.Visible = false;
            ButtonPanel.Visible = false;
            BarrierCreatePanel.Visible = false;
            AstrictFlowPanel.Visible = false;
            DurancePanel.Visible = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            //地图生成按钮
            for (int i = 0; i < 81; i++)
            {
                int tempNum = 0;
                //有几条数据，就创建几个按钮
                Button btn = new Button();
                tempNum = i + 1;
                btn.Name = "At" + tempNum + "";
                btn.Size = new Size(25, 25);
                btn.BackColor = Color.AliceBlue;
                btn.Text = "0";
                ButtonPanel.AutoScroll = true;
                ButtonPanel.Controls.Add(btn);
                btn.Click += button1_Click;
                btn.MouseEnter += button1_MouseEnter;
            }

            //生成底部障碍
            for (int i = 0; i < 81; i++)
            {
                ComboBox cb = new ComboBox();
                cb.Size = new Size(50, 30);
                cb.Margin = new Padding(1, 15, 1, 15);
                cb.Items.Add("薄冰");
                cb.Items.Add("中冰");
                cb.Items.Add("厚冰");
                cb.Font = new System.Drawing.Font("宋体", 8.71429F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                cb.FlatStyle = FlatStyle.Standard;
                cb.DropDownHeight = 80;
                BarrierCreatePanel.AutoScroll = true;
                BarrierCreatePanel.Controls.Add(cb);
            }

            //生成元素
            for (int i = 0; i < 81; i++)
            {
                ComboBox cb = new ComboBox
                {
                    Size = new Size(50, 30),
                    Margin = new Padding(1, 15, 1, 15)
                };
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

                cb.Font = new System.Drawing.Font("宋体", 8.71429F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                cb.FlatStyle = FlatStyle.Standard;
                cb.DropDownHeight = 80;
                ElementPanel.AutoScroll = true;
                ElementPanel.Controls.Add(cb);
            }

            //生成顶部障碍物
            for (int i = 0; i < 81; i++)
            {
                ComboBox cb = new ComboBox
                {
                    Size = new Size(50, 30),
                    Margin = new Padding(1, 15, 1, 15)
                };
                cb.Items.Add("灰球");
                cb.Items.Add("牢笼");
                cb.Items.Add("章鱼");
                cb.Font = new Font("宋体", 8.71429F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                cb.FlatStyle = FlatStyle.Standard;
                cb.DropDownHeight = 80;
                DurancePanel.AutoScroll = true;
                DurancePanel.Controls.Add(cb);
            }

            //生成限制元素
            for (int i = 0; i < 81; i++)
            {
                TextBox tb = new TextBox()
                {
                    Size = new Size(50, 30),
                    Margin = new Padding(1, 15, 1, 15)
                };
                tb.Font = new Font("宋体", 8.71429F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                AstrictFlowPanel.AutoScroll = true;
                AstrictFlowPanel.Controls.Add(tb);
            }
        }

        /// <summary>
        /// 地图生成面板中的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            cl.GridDetails?.Clear();
            cl.DuranceDetails = cl.DuranceDetails == null ? new List<DuranceDetail>() : cl.DuranceDetails;
            cl.DuranceDetails.Clear();
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
                    cl.GridDetails.Add(gc);

                    DuranceDetail dd = new DuranceDetail();
                    dd.Location = btn.Name;
                    dd.Status = btn.Text;
                    cl.DuranceDetails.Add(dd);
                }
            }
        }

        /// <summary>
        /// 生成Json按钮按下以后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateJson_Click(object sender, EventArgs e)
        {
            if (LevelNameBox.Text == "")
            {
                MessageBox.Show("请输入关卡名称!", "Warning");
                return;
            }

            if (cl.MissionDetails != null)
            {
                cl.MissionDetails.Clear();
            }
            else
            {
                cl.MissionDetails = new List<MissionDetail>();
            }

            if (LevelStepNum.Text != "" && LevelGoalNumber.Text != "" && PassNum1.Text != "")
            {
                MissionDetail md = new MissionDetail();
                md.StepLimit = LevelStepNum.Text;
                md.GoalNumber = LevelGoalNumber.Text;
                if (PassGoalType1.SelectedItem != null)
                {
                    md.GoalTypeOne = PassGoalType1.SelectedItem.ToString();
                }

                if (PassGoalType2.SelectedItem != null)
                {
                    md.GoalTypeTwo = PassGoalType2.SelectedItem.ToString();
                }

                md.GoalTypeOneNum = PassNum1.Text;
                if (PassNum2.Text != "")
                {
                    md.GoalTypeTwoNum = PassNum2.Text;
                }
                md.BanElemType = HideBaseType.Text;
                cl.MissionDetails.Add(md);
            }
            else
            {
                MessageBox.Show("关卡任务数据未填写完全!", "Warning");
                return;
            }

            if (cl.GridDetails != null)
            {
                //再次生成Json
                for (int i = 0; i < ElementPanel.Controls.Count; i++)
                {
                    if (((Button)ButtonPanel.Controls[i]).Text == "1" ||
                        ((Button)ButtonPanel.Controls[i]).Text == "2")
                    {
                        ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                        if (cbb.SelectedItem != null)
                        {
                            cl.GridDetails[i].ElementType = cbb.SelectedItem.ToString();
                        }

                        ComboBox cbb2 = (ComboBox)BarrierCreatePanel.Controls[i];
                        if (cbb2.SelectedItem != null)
                        {
                            cl.GridDetails[i].BarrierType = cbb2.SelectedItem.ToString();
                        }

                        ComboBox cbb3 = (ComboBox)DurancePanel.Controls[i];
                        if (cbb3.SelectedItem != null)
                        {
                            cl.DuranceDetails[i].DuranceType = cbb3.SelectedItem.ToString();
                        }

                        TextBox tbb = (TextBox)AstrictFlowPanel.Controls[i];
                        if (!string.IsNullOrWhiteSpace(tbb.Text))
                        {
                            cl.DuranceDetails[i].RopeType = cbb3.Text;
                        }
                    }
                    else
                    {
                        ((ComboBox)ElementPanel.Controls[i]).SelectedItem = null;
                        ((ComboBox)BarrierCreatePanel.Controls[i]).SelectedItem = null;
                        ((ComboBox)DurancePanel.Controls[i]).SelectedItem = null;
                        ((TextBox)AstrictFlowPanel.Controls[i]).Text = null;
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
            UpdateListbox();
            JsonList.SelectedIndex = -1;
        }

        /// <summary>
        /// 重置数据
        /// </summary>
        private void ResetData()
        {
            LevelNameBox.Text = "";
            this.Text = "CreateGrid";
            //UpdateListbox();
            //JsonList.SelectedIndex = -1;
            SearchJsonName.Text = "";

            if (cl != null && cl.GridDetails != null)
            {
                cl.GridDetails.Clear();
            }

            if (cl != null && cl.MissionDetails != null)
            {
                cl.MissionDetails.Clear();
            }

            LevelStepNum.Text = "";
            LevelGoalNumber.Text = "";
            PassGoalType1.SelectedItem = null;
            PassGoalType2.SelectedItem = null;
            PassNum1.Text = "";
            PassNum2.Text = "";

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

            foreach (Control control in DurancePanel.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cbb = (ComboBox)control;
                    cbb.SelectedIndex = -1;
                    cbb.Enabled = true;
                }
            }

            foreach (Control control in AstrictFlowPanel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox cbb = (TextBox)control;
                    cbb.Text = "";
                    cbb.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 地图生成面板按钮按下以后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateGridButton_Click(object sender, EventArgs e)
        {
            ButtonPanel.Visible = true;
            BarrierCreatePanel.Visible = false;
            ElementPanel.Visible = false;
            DurancePanel.Visible = false;
            AstrictFlowPanel.Visible = false;
        }

        /// <summary>
        /// 元素面板按钮按下以后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchToElement_Click(object sender, EventArgs e)
        {
            cl.GridDetails.Clear();
            FillJsonClass();
            if (cl.GridDetails == null)
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
                    else if (((Button)ButtonPanel.Controls[i]).Text == "1" ||
                             ((Button)ButtonPanel.Controls[i]).Text == "2")
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
            DurancePanel.Visible = false;
            AstrictFlowPanel.Visible = false;
        }

        /// <summary>
        /// 障碍物面板按钮按下以后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarrierButton_Click(object sender, EventArgs e)
        {
            cl.GridDetails.Clear();
            FillJsonClass();
            if (cl.GridDetails == null)
            {
                MessageBox.Show("尚未设计地图!", "Warning");
                return;
            }

            ElementPanel.Visible = false;
            ButtonPanel.Visible = false;
            BarrierCreatePanel.Visible = true;
            DurancePanel.Visible = false;
            AstrictFlowPanel.Visible = false;

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
                    else if (((Button)ButtonPanel.Controls[i]).Text == "1" ||
                             ((Button)ButtonPanel.Controls[i]).Text == "2")
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

        /// <summary>
        /// 拖入文件以后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 拖拽文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateGrid_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] rs = (string[])e.Data.GetData(DataFormats.FileDrop);
                DragJsonFilePath = rs[0];
                LevelNameBox.Text = Path.GetFileNameWithoutExtension(DragJsonFilePath);
                this.Text = "CreateGrid" + " 文件: " + DragJsonFilePath;
                FillAllPanel(rs[0]);
            }
        }

        /// <summary>
        /// 加载数据到程序中
        /// </summary>
        /// <param name="jsonFilePath"></param>
        private void FillAllPanel(string jsonFilePath)
        {
            ResetData();

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
                    if (cl.GridDetails[i].Status == "0")
                    {
                        if (ButtonPanel.Controls[i] is Button)
                        {
                            Button btn = (Button)ButtonPanel.Controls[i];
                            btn.Text = "0";
                            btn.BackColor = Color.AliceBlue;
                        }
                    }
                    else if (cl.GridDetails[i].Status == "1")
                    {
                        if (ButtonPanel.Controls[i] is Button)
                        {
                            Button btn = (Button)ButtonPanel.Controls[i];
                            btn.Text = "1";
                            btn.BackColor = Color.BurlyWood;
                        }
                    }
                    else if (cl.GridDetails[i].Status == "2")
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
                    if (cl.GridDetails[i].ElementType != null)
                    {
                        if (ElementPanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)ElementPanel.Controls[i];
                            cbb.SelectedItem = cl.GridDetails[i].ElementType;
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
                    if (cl.GridDetails[i].BarrierType != null)
                    {
                        if (BarrierCreatePanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)BarrierCreatePanel.Controls[i];
                            cbb.SelectedItem = cl.GridDetails[i].BarrierType;
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

            if (cl.MissionDetails != null)
            {
                LevelStepNum.Text = cl.MissionDetails[0].StepLimit;
                LevelGoalNumber.Text = cl.MissionDetails[0].GoalNumber;
                PassGoalType1.SelectedItem = cl.MissionDetails[0].GoalTypeOne;
                PassGoalType2.SelectedItem = cl.MissionDetails[0].GoalTypeTwo;
                PassNum1.Text = cl.MissionDetails[0].GoalTypeOneNum;
                PassNum2.Text = cl.MissionDetails[0].GoalTypeTwoNum;
            }
            else
            {
                cl.MissionDetails = new List<MissionDetail>();
            }

            PassGoalType1.SelectedText.ToString();
        }

        /// <summary>
        /// 更新列表文件
        /// </summary>
        private void UpdateListbox()
        {
            JsonList.Items.Clear();
            string[] jsonFiles = Directory.GetFiles(jsonFolderPath);
            for (int i = 0; i < jsonFiles.Length; i++)
            {
                JsonList.Items.Add(Path.GetFileName(jsonFiles[i]));
            }
        }

        /// <summary>
        /// 双击列表中的文件打开文件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 按文件名搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (JsonList.SelectedItem != null)
            {
                File.Delete(jsonFolderPath + "\\" + JsonList.SelectedItem);
                UpdateListbox();
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (JsonList.SelectedItem != null)
            {
                System.Diagnostics.Process.Start("notepad.exe", jsonFolderPath + "\\" + JsonList.SelectedItem);
            }
        }

        private void 打开文件所在位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (JsonList.SelectedItem != null)
            {
                System.Diagnostics.Process.Start("Explorer",
                    "/select," + jsonFolderPath + "\\" + JsonList.SelectedItem);
            }
        }

        private void DuranceCreate_Click(object sender, EventArgs e)
        {
            FillJsonClass();
            if (cl.GridDetails == null)
            {
                MessageBox.Show("尚未设计地图!", "Warning");
                return;
            }

            if (cl != null)
            {
                for (int i = 0; i < DurancePanel.Controls.Count; i++)
                {
                    if (((Button)ButtonPanel.Controls[i]).Text == "0")
                    {
                        if (DurancePanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)DurancePanel.Controls[i];
                            cbb.SelectedItem = null;
                            cbb.Enabled = false;
                        }
                    }
                    else if (((Button)ButtonPanel.Controls[i]).Text == "1" ||
                             ((Button)ButtonPanel.Controls[i]).Text == "2")
                    {
                        if (DurancePanel.Controls[i] is ComboBox)
                        {
                            ComboBox cbb = (ComboBox)DurancePanel.Controls[i];
                            cbb.Enabled = true;
                        }
                    }
                }
            }

            ButtonPanel.Visible = false;
            BarrierCreatePanel.Visible = false;
            ElementPanel.Visible = false;
            DurancePanel.Visible = true;
            AstrictFlowPanel.Visible = false;
        }

        private void FallingPlan_Click(object sender, EventArgs e)
        {
        }

        private void AstrictPanel_Click(object sender, EventArgs e)
        {
            FillJsonClass();
            if (cl.GridDetails == null)
            {
                MessageBox.Show("尚未设计地图!", "Warning");
                return;
            }
            if (cl != null)
            {
                for (int i = 0; i < DurancePanel.Controls.Count; i++)
                {
                    if (((Button)ButtonPanel.Controls[i]).Text == "0")
                    {
                        if (AstrictFlowPanel.Controls[i] is TextBox)
                        {
                            TextBox cbb = (TextBox)AstrictFlowPanel.Controls[i];
                            cbb.Text = "";
                            cbb.Enabled = false;
                        }
                    }
                    else if (((Button)ButtonPanel.Controls[i]).Text == "1" ||
                             ((Button)ButtonPanel.Controls[i]).Text == "2")
                    {
                        if (AstrictFlowPanel.Controls[i] is TextBox)
                        {
                            TextBox cbb = (TextBox)AstrictFlowPanel.Controls[i];
                            cbb.Enabled = true;
                        }
                    }
                }
            }

            ButtonPanel.Visible = false;
            BarrierCreatePanel.Visible = false;
            ElementPanel.Visible = false;
            DurancePanel.Visible = false;
            AstrictFlowPanel.Visible = true;
        }
    }
}
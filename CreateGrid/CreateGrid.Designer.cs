namespace CreateGrid
{
    partial class CreateGrid
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGrid));
            this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateJson = new System.Windows.Forms.Button();
            this.LevelNameBox = new System.Windows.Forms.RichTextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CreateGridButton = new System.Windows.Forms.Button();
            this.ElementPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SwitchToElement = new System.Windows.Forms.Button();
            this.BarrierButton = new System.Windows.Forms.Button();
            this.BarrierCreatePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.JsonList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchJsonName = new System.Windows.Forms.RichTextBox();
            this.SearchJsonButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PassGoalType1 = new System.Windows.Forms.ComboBox();
            this.LevelGoalNumber = new System.Windows.Forms.TextBox();
            this.LevelStepNum = new System.Windows.Forms.TextBox();
            this.PassGoalType2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PassNum1 = new System.Windows.Forms.TextBox();
            this.PassNum2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.JsonListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件所在位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JsonListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Location = new System.Drawing.Point(180, 136);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(509, 552);
            this.ButtonPanel.TabIndex = 0;
            // 
            // CreateJson
            // 
            this.CreateJson.Location = new System.Drawing.Point(895, 769);
            this.CreateJson.Name = "CreateJson";
            this.CreateJson.Size = new System.Drawing.Size(116, 45);
            this.CreateJson.TabIndex = 1;
            this.CreateJson.Text = "生成Json";
            this.CreateJson.UseVisualStyleBackColor = true;
            this.CreateJson.Click += new System.EventHandler(this.CreateJson_Click);
            // 
            // LevelNameBox
            // 
            this.LevelNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.LevelNameBox.CausesValidation = false;
            this.LevelNameBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LevelNameBox.Location = new System.Drawing.Point(895, 721);
            this.LevelNameBox.Name = "LevelNameBox";
            this.LevelNameBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LevelNameBox.Size = new System.Drawing.Size(254, 42);
            this.LevelNameBox.TabIndex = 4;
            this.LevelNameBox.Text = "";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetButton.Location = new System.Drawing.Point(1033, 769);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(116, 45);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "重置数据";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CreateGridButton
            // 
            this.CreateGridButton.Location = new System.Drawing.Point(895, 9);
            this.CreateGridButton.Name = "CreateGridButton";
            this.CreateGridButton.Size = new System.Drawing.Size(254, 46);
            this.CreateGridButton.TabIndex = 5;
            this.CreateGridButton.Text = "1:地图生成面板";
            this.CreateGridButton.UseVisualStyleBackColor = true;
            this.CreateGridButton.Click += new System.EventHandler(this.CreateGridButton_Click);
            // 
            // ElementPanel
            // 
            this.ElementPanel.Location = new System.Drawing.Point(12, 12);
            this.ElementPanel.Name = "ElementPanel";
            this.ElementPanel.Padding = new System.Windows.Forms.Padding(2);
            this.ElementPanel.Size = new System.Drawing.Size(867, 820);
            this.ElementPanel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(905, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 9;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwitchToElement
            // 
            this.SwitchToElement.Location = new System.Drawing.Point(895, 70);
            this.SwitchToElement.Name = "SwitchToElement";
            this.SwitchToElement.Size = new System.Drawing.Size(254, 46);
            this.SwitchToElement.TabIndex = 12;
            this.SwitchToElement.Text = "2:元素生成模板";
            this.SwitchToElement.UseVisualStyleBackColor = true;
            this.SwitchToElement.Click += new System.EventHandler(this.SwitchToElement_Click);
            // 
            // BarrierButton
            // 
            this.BarrierButton.Location = new System.Drawing.Point(895, 131);
            this.BarrierButton.Name = "BarrierButton";
            this.BarrierButton.Size = new System.Drawing.Size(254, 46);
            this.BarrierButton.TabIndex = 18;
            this.BarrierButton.Text = "3:障碍生成面板";
            this.BarrierButton.UseVisualStyleBackColor = true;
            this.BarrierButton.Click += new System.EventHandler(this.BarrierButton_Click);
            // 
            // BarrierCreatePanel
            // 
            this.BarrierCreatePanel.Location = new System.Drawing.Point(11, 11);
            this.BarrierCreatePanel.Name = "BarrierCreatePanel";
            this.BarrierCreatePanel.Padding = new System.Windows.Forms.Padding(2);
            this.BarrierCreatePanel.Size = new System.Drawing.Size(867, 820);
            this.BarrierCreatePanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(891, 687);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "请输入Json名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JsonList
            // 
            this.JsonList.BackColor = System.Drawing.SystemColors.Menu;
            this.JsonList.ContextMenuStrip = this.JsonListMenu;
            this.JsonList.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JsonList.FormattingEnabled = true;
            this.JsonList.ItemHeight = 25;
            this.JsonList.Location = new System.Drawing.Point(895, 385);
            this.JsonList.Name = "JsonList";
            this.JsonList.Size = new System.Drawing.Size(254, 279);
            this.JsonList.Sorted = true;
            this.JsonList.TabIndex = 21;
            this.JsonList.DoubleClick += new System.EventHandler(this.JsonList_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(891, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Json文件列表";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchJsonName
            // 
            this.SearchJsonName.BackColor = System.Drawing.SystemColors.Window;
            this.SearchJsonName.CausesValidation = false;
            this.SearchJsonName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchJsonName.Location = new System.Drawing.Point(895, 337);
            this.SearchJsonName.Name = "SearchJsonName";
            this.SearchJsonName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.SearchJsonName.Size = new System.Drawing.Size(161, 42);
            this.SearchJsonName.TabIndex = 25;
            this.SearchJsonName.Text = "";
            this.SearchJsonName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchJsonName_MouseClick);
            // 
            // SearchJsonButton
            // 
            this.SearchJsonButton.Location = new System.Drawing.Point(1062, 337);
            this.SearchJsonButton.Name = "SearchJsonButton";
            this.SearchJsonButton.Size = new System.Drawing.Size(87, 42);
            this.SearchJsonButton.TabIndex = 26;
            this.SearchJsonButton.Text = "搜索";
            this.SearchJsonButton.UseVisualStyleBackColor = true;
            this.SearchJsonButton.Click += new System.EventHandler(this.SearchJsonButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(1170, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "关卡步数";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(1170, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "通关目标个数";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(1170, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "通关目标1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(1172, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "通关目标2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassGoalType1
            // 
            this.PassGoalType1.FormattingEnabled = true;
            this.PassGoalType1.Items.AddRange(new object[] {
            "小熊",
            "猫猫",
            "小鸡",
            "狐狸",
            "青蛙",
            "河马",
            "灰球",
            "薄冰",
            "雪块1",
            "豆荚"});
            this.PassGoalType1.Location = new System.Drawing.Point(1174, 253);
            this.PassGoalType1.Name = "PassGoalType1";
            this.PassGoalType1.Size = new System.Drawing.Size(134, 29);
            this.PassGoalType1.TabIndex = 34;
            // 
            // LevelGoalNumber
            // 
            this.LevelGoalNumber.Location = new System.Drawing.Point(1174, 169);
            this.LevelGoalNumber.Name = "LevelGoalNumber";
            this.LevelGoalNumber.Size = new System.Drawing.Size(134, 31);
            this.LevelGoalNumber.TabIndex = 35;
            // 
            // LevelStepNum
            // 
            this.LevelStepNum.Location = new System.Drawing.Point(1174, 92);
            this.LevelStepNum.Name = "LevelStepNum";
            this.LevelStepNum.Size = new System.Drawing.Size(134, 31);
            this.LevelStepNum.TabIndex = 36;
            // 
            // PassGoalType2
            // 
            this.PassGoalType2.FormattingEnabled = true;
            this.PassGoalType2.Items.AddRange(new object[] {
            "小熊",
            "猫猫",
            "小鸡",
            "狐狸",
            "青蛙",
            "河马",
            "灰球",
            "薄冰",
            "雪块1",
            "豆荚"});
            this.PassGoalType2.Location = new System.Drawing.Point(1176, 426);
            this.PassGoalType2.Name = "PassGoalType2";
            this.PassGoalType2.Size = new System.Drawing.Size(134, 29);
            this.PassGoalType2.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(1170, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "通关目标1个数";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Location = new System.Drawing.Point(1172, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 21);
            this.label9.TabIndex = 39;
            this.label9.Text = "通关目标2个数";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassNum1
            // 
            this.PassNum1.Location = new System.Drawing.Point(1174, 337);
            this.PassNum1.Name = "PassNum1";
            this.PassNum1.Size = new System.Drawing.Size(134, 31);
            this.PassNum1.TabIndex = 40;
            // 
            // PassNum2
            // 
            this.PassNum2.Location = new System.Drawing.Point(1176, 510);
            this.PassNum2.Name = "PassNum2";
            this.PassNum2.Size = new System.Drawing.Size(134, 31);
            this.PassNum2.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Info;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(1172, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 21);
            this.label10.TabIndex = 43;
            this.label10.Text = "关卡任务设置";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JsonListMenu
            // 
            this.JsonListMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.JsonListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.打开文件所在位置ToolStripMenuItem});
            this.JsonListMenu.Name = "JsonListMenu";
            this.JsonListMenu.Size = new System.Drawing.Size(271, 144);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 打开文件所在位置ToolStripMenuItem
            // 
            this.打开文件所在位置ToolStripMenuItem.Name = "打开文件所在位置ToolStripMenuItem";
            this.打开文件所在位置ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.打开文件所在位置ToolStripMenuItem.Text = "打开文件所在位置";
            this.打开文件所在位置ToolStripMenuItem.Click += new System.EventHandler(this.打开文件所在位置ToolStripMenuItem_Click);
            // 
            // CreateGrid
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1334, 841);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PassNum2);
            this.Controls.Add(this.PassNum1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BarrierCreatePanel);
            this.Controls.Add(this.PassGoalType2);
            this.Controls.Add(this.SearchJsonButton);
            this.Controls.Add(this.LevelStepNum);
            this.Controls.Add(this.SearchJsonName);
            this.Controls.Add(this.LevelGoalNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassGoalType1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.JsonList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BarrierButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SwitchToElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ElementPanel);
            this.Controls.Add(this.CreateGridButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.LevelNameBox);
            this.Controls.Add(this.CreateJson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateGrid";
            this.Load += new System.EventHandler(this.CreateGrid_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CreateGrid_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CreateGrid_DragEnter);
            this.JsonListMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button CreateJson;
        private System.Windows.Forms.RichTextBox LevelNameBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CreateGridButton;
        private System.Windows.Forms.FlowLayoutPanel ElementPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SwitchToElement;
        private System.Windows.Forms.Button BarrierButton;
        private System.Windows.Forms.FlowLayoutPanel BarrierCreatePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox JsonList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox SearchJsonName;
        private System.Windows.Forms.Button SearchJsonButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LevelStepNum;
        private System.Windows.Forms.TextBox LevelGoalNumber;
        private System.Windows.Forms.ComboBox PassGoalType1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PassGoalType2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PassNum1;
        private System.Windows.Forms.TextBox PassNum2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip JsonListMenu;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件所在位置ToolStripMenuItem;
    }
}


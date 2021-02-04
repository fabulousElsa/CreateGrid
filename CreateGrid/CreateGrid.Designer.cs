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
            // CreateGrid
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1190, 841);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.BarrierCreatePanel);
            this.Controls.Add(this.SearchJsonButton);
            this.Controls.Add(this.SearchJsonName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JsonList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarrierButton);
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
    }
}


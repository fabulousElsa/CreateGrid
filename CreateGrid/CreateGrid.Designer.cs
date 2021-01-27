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
            this.label1 = new System.Windows.Forms.Label();
            this.LevelNameBox = new System.Windows.Forms.RichTextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CreateGridButton = new System.Windows.Forms.Button();
            this.ElementPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SwitchToElement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BarrierButton = new System.Windows.Forms.Button();
            this.BarrierCreatePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Location = new System.Drawing.Point(173, 172);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(494, 492);
            this.ButtonPanel.TabIndex = 0;
            // 
            // CreateJson
            // 
            this.CreateJson.Location = new System.Drawing.Point(895, 737);
            this.CreateJson.Name = "CreateJson";
            this.CreateJson.Size = new System.Drawing.Size(141, 45);
            this.CreateJson.TabIndex = 1;
            this.CreateJson.Text = "生成Json";
            this.CreateJson.UseVisualStyleBackColor = true;
            this.CreateJson.Click += new System.EventHandler(this.CreateJson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(900, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入关卡名称";
            // 
            // LevelNameBox
            // 
            this.LevelNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.LevelNameBox.CausesValidation = false;
            this.LevelNameBox.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LevelNameBox.Location = new System.Drawing.Point(895, 653);
            this.LevelNameBox.Name = "LevelNameBox";
            this.LevelNameBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LevelNameBox.Size = new System.Drawing.Size(381, 60);
            this.LevelNameBox.TabIndex = 4;
            this.LevelNameBox.Text = "";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetButton.Location = new System.Drawing.Point(1135, 737);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(141, 45);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "重置数据";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CreateGridButton
            // 
            this.CreateGridButton.Location = new System.Drawing.Point(895, 61);
            this.CreateGridButton.Name = "CreateGridButton";
            this.CreateGridButton.Size = new System.Drawing.Size(184, 46);
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
            this.SwitchToElement.Location = new System.Drawing.Point(895, 122);
            this.SwitchToElement.Name = "SwitchToElement";
            this.SwitchToElement.Size = new System.Drawing.Size(184, 46);
            this.SwitchToElement.TabIndex = 12;
            this.SwitchToElement.Text = "2:元素生成模板";
            this.SwitchToElement.UseVisualStyleBackColor = true;
            this.SwitchToElement.Click += new System.EventHandler(this.SwitchToElement_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(900, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "在这里进行地图的设计";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(900, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "LR表示左右四消元素";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(900, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "UD表示上下四消元素";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(900, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "炸+动物表示炸弹元素";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(900, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "魔鸟是魔力鸟，其他是普通动物";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarrierButton
            // 
            this.BarrierButton.Location = new System.Drawing.Point(895, 183);
            this.BarrierButton.Name = "BarrierButton";
            this.BarrierButton.Size = new System.Drawing.Size(184, 46);
            this.BarrierButton.TabIndex = 18;
            this.BarrierButton.Text = "3:障碍生成面板";
            this.BarrierButton.UseVisualStyleBackColor = true;
            this.BarrierButton.Click += new System.EventHandler(this.BarrierButton_Click);
            // 
            // BarrierCreatePanel
            // 
            this.BarrierCreatePanel.Location = new System.Drawing.Point(12, 9);
            this.BarrierCreatePanel.Name = "BarrierCreatePanel";
            this.BarrierCreatePanel.Padding = new System.Windows.Forms.Padding(2);
            this.BarrierCreatePanel.Size = new System.Drawing.Size(867, 820);
            this.BarrierCreatePanel.TabIndex = 8;
            // 
            // CreateGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1314, 841);
            this.Controls.Add(this.BarrierCreatePanel);
            this.Controls.Add(this.BarrierButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SwitchToElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.ElementPanel);
            this.Controls.Add(this.CreateGridButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LevelNameBox);
            this.Controls.Add(this.CreateJson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateGrid";
            this.Load += new System.EventHandler(this.CreateGrid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button CreateJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox LevelNameBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CreateGridButton;
        private System.Windows.Forms.FlowLayoutPanel ElementPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SwitchToElement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BarrierButton;
        private System.Windows.Forms.FlowLayoutPanel BarrierCreatePanel;
    }
}


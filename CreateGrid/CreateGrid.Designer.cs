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
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Location = new System.Drawing.Point(12, 12);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(517, 492);
            this.ButtonPanel.TabIndex = 0;
            // 
            // CreateJson
            // 
            this.CreateJson.Location = new System.Drawing.Point(576, 364);
            this.CreateJson.Name = "CreateJson";
            this.CreateJson.Size = new System.Drawing.Size(168, 46);
            this.CreateJson.TabIndex = 1;
            this.CreateJson.Text = "CreateJson";
            this.CreateJson.UseVisualStyleBackColor = true;
            this.CreateJson.Click += new System.EventHandler(this.CreateJson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(560, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入关卡名称";
            // 
            // LevelNameBox
            // 
            this.LevelNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.LevelNameBox.CausesValidation = false;
            this.LevelNameBox.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LevelNameBox.Location = new System.Drawing.Point(548, 269);
            this.LevelNameBox.Name = "LevelNameBox";
            this.LevelNameBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LevelNameBox.Size = new System.Drawing.Size(223, 60);
            this.LevelNameBox.TabIndex = 4;
            this.LevelNameBox.Text = "";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetButton.Location = new System.Drawing.Point(576, 436);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(168, 46);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "ResetData";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CreateGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(783, 520);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LevelNameBox);
            this.Controls.Add(this.CreateJson);
            this.Controls.Add(this.ButtonPanel);
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
    }
}


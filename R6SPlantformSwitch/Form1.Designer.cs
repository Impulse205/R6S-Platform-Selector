
namespace R6SPlantformSwitch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.UplayRadio = new System.Windows.Forms.RadioButton();
            this.SteamRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.changeFileButton = new System.Windows.Forms.Button();
            this.gameFolderLoc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择平台";
            // 
            // UplayRadio
            // 
            this.UplayRadio.Location = new System.Drawing.Point(12, 38);
            this.UplayRadio.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.UplayRadio.Name = "UplayRadio";
            this.UplayRadio.Size = new System.Drawing.Size(129, 41);
            this.UplayRadio.TabIndex = 1;
            this.UplayRadio.TabStop = true;
            this.UplayRadio.Text = "Uplay平台\r\n(Ubisoft Connect)";
            this.UplayRadio.UseVisualStyleBackColor = true;
            this.UplayRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SteamRadio
            // 
            this.SteamRadio.AutoSize = true;
            this.SteamRadio.Location = new System.Drawing.Point(12, 27);
            this.SteamRadio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.SteamRadio.Name = "SteamRadio";
            this.SteamRadio.Size = new System.Drawing.Size(77, 16);
            this.SteamRadio.TabIndex = 2;
            this.SteamRadio.TabStop = true;
            this.SteamRadio.Text = "Steam平台";
            this.SteamRadio.UseVisualStyleBackColor = true;
            this.SteamRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "更新于Y6S2.1\r\n程序版本v1.0\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "游戏文件夹位置";
            // 
            // gameFolderBrowser
            // 
            this.gameFolderBrowser.Description = "选择游戏位置";
            this.gameFolderBrowser.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            // 
            // changeFileButton
            // 
            this.changeFileButton.Location = new System.Drawing.Point(405, 54);
            this.changeFileButton.Name = "changeFileButton";
            this.changeFileButton.Size = new System.Drawing.Size(131, 33);
            this.changeFileButton.TabIndex = 5;
            this.changeFileButton.Text = "确认更换文件";
            this.changeFileButton.UseVisualStyleBackColor = true;
            this.changeFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameFolderLoc
            // 
            this.gameFolderLoc.Location = new System.Drawing.Point(146, 27);
            this.gameFolderLoc.Name = "gameFolderLoc";
            this.gameFolderLoc.Size = new System.Drawing.Size(390, 21);
            this.gameFolderLoc.TabIndex = 6;
            this.gameFolderLoc.TextChanged += new System.EventHandler(this.gameFolderLoc_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "浏览游戏文件夹位置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(85, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "说明";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 99);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameFolderLoc);
            this.Controls.Add(this.changeFileButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SteamRadio);
            this.Controls.Add(this.UplayRadio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "彩六：围攻平台文件更换工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton UplayRadio;
        private System.Windows.Forms.RadioButton SteamRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog gameFolderBrowser;
        private System.Windows.Forms.Button changeFileButton;
        private System.Windows.Forms.TextBox gameFolderLoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


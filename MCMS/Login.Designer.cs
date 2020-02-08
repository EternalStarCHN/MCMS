namespace MCMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.text_ADID = new System.Windows.Forms.TextBox();
            this.text_ADPW = new System.Windows.Forms.TextBox();
            this.label_ADID = new System.Windows.Forms.Label();
            this.label_ADPW = new System.Windows.Forms.Label();
            this.skinButton_SignIN = new CCWin.SkinControl.SkinButton();
            this.skinButton_SignUp = new CCWin.SkinControl.SkinButton();
            this.skinButton_Quit = new CCWin.SkinControl.SkinButton();
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.其他设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.skinMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_ADID
            // 
            this.text_ADID.BackColor = System.Drawing.Color.LightCyan;
            this.text_ADID.Location = new System.Drawing.Point(121, 80);
            this.text_ADID.Name = "text_ADID";
            this.text_ADID.Size = new System.Drawing.Size(203, 21);
            this.text_ADID.TabIndex = 0;
            // 
            // text_ADPW
            // 
            this.text_ADPW.BackColor = System.Drawing.Color.LightCyan;
            this.text_ADPW.Location = new System.Drawing.Point(121, 134);
            this.text_ADPW.Name = "text_ADPW";
            this.text_ADPW.PasswordChar = '*';
            this.text_ADPW.Size = new System.Drawing.Size(203, 21);
            this.text_ADPW.TabIndex = 1;
            // 
            // label_ADID
            // 
            this.label_ADID.AutoSize = true;
            this.label_ADID.BackColor = System.Drawing.Color.Transparent;
            this.label_ADID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ADID.ForeColor = System.Drawing.Color.Black;
            this.label_ADID.Location = new System.Drawing.Point(12, 81);
            this.label_ADID.Name = "label_ADID";
            this.label_ADID.Size = new System.Drawing.Size(97, 14);
            this.label_ADID.TabIndex = 2;
            this.label_ADID.Text = "管理员账号：";
            // 
            // label_ADPW
            // 
            this.label_ADPW.AutoSize = true;
            this.label_ADPW.BackColor = System.Drawing.Color.Transparent;
            this.label_ADPW.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ADPW.Location = new System.Drawing.Point(12, 135);
            this.label_ADPW.Name = "label_ADPW";
            this.label_ADPW.Size = new System.Drawing.Size(97, 14);
            this.label_ADPW.TabIndex = 3;
            this.label_ADPW.Text = "管理员密码：";
            // 
            // skinButton_SignIN
            // 
            this.skinButton_SignIN.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_SignIN.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_SignIN.DownBack = null;
            this.skinButton_SignIN.Location = new System.Drawing.Point(12, 189);
            this.skinButton_SignIN.MouseBack = null;
            this.skinButton_SignIN.Name = "skinButton_SignIN";
            this.skinButton_SignIN.NormlBack = null;
            this.skinButton_SignIN.Size = new System.Drawing.Size(103, 34);
            this.skinButton_SignIN.TabIndex = 8;
            this.skinButton_SignIN.Text = "登录";
            this.skinButton_SignIN.UseVisualStyleBackColor = false;
            this.skinButton_SignIN.Click += new System.EventHandler(this.skinButton_SignIN_Click);
            // 
            // skinButton_SignUp
            // 
            this.skinButton_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_SignUp.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_SignUp.DownBack = null;
            this.skinButton_SignUp.Location = new System.Drawing.Point(121, 189);
            this.skinButton_SignUp.MouseBack = null;
            this.skinButton_SignUp.Name = "skinButton_SignUp";
            this.skinButton_SignUp.NormlBack = null;
            this.skinButton_SignUp.Size = new System.Drawing.Size(103, 34);
            this.skinButton_SignUp.TabIndex = 9;
            this.skinButton_SignUp.Text = "注册";
            this.skinButton_SignUp.UseVisualStyleBackColor = false;
            this.skinButton_SignUp.Click += new System.EventHandler(this.skinButton_SignUp_Click);
            // 
            // skinButton_Quit
            // 
            this.skinButton_Quit.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_Quit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.skinButton_Quit.DownBack = null;
            this.skinButton_Quit.Location = new System.Drawing.Point(230, 189);
            this.skinButton_Quit.MouseBack = null;
            this.skinButton_Quit.Name = "skinButton_Quit";
            this.skinButton_Quit.NormlBack = null;
            this.skinButton_Quit.Size = new System.Drawing.Size(103, 34);
            this.skinButton_Quit.TabIndex = 10;
            this.skinButton_Quit.Text = "退出";
            this.skinButton_Quit.UseVisualStyleBackColor = false;
            this.skinButton_Quit.Click += new System.EventHandler(this.skinButton_Quit_Click);
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.其他设置ToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(349, 25);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 11;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 其他设置ToolStripMenuItem
            // 
            this.其他设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作说明ToolStripMenuItem,
            this.关于作者ToolStripMenuItem});
            this.其他设置ToolStripMenuItem.Name = "其他设置ToolStripMenuItem";
            this.其他设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.其他设置ToolStripMenuItem.Text = "其他设置";
            // 
            // 操作说明ToolStripMenuItem
            // 
            this.操作说明ToolStripMenuItem.Name = "操作说明ToolStripMenuItem";
            this.操作说明ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.操作说明ToolStripMenuItem.Text = "操作说明";
            this.操作说明ToolStripMenuItem.Click += new System.EventHandler(this.操作说明ToolStripMenuItem_Click);
            // 
            // 关于作者ToolStripMenuItem
            // 
            this.关于作者ToolStripMenuItem.Name = "关于作者ToolStripMenuItem";
            this.关于作者ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于作者ToolStripMenuItem.Text = "关于作者";
            this.关于作者ToolStripMenuItem.Click += new System.EventHandler(this.关于作者ToolStripMenuItem_Click);
            // 
            // skinLine1
            // 
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.Black;
            this.skinLine1.LineHeight = 1;
            this.skinLine1.Location = new System.Drawing.Point(15, 173);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(318, 10);
            this.skinLine1.TabIndex = 12;
            this.skinLine1.Text = "skinLine1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.skinButton_Quit;
            this.ClientSize = new System.Drawing.Size(349, 235);
            this.Controls.Add(this.skinLine1);
            this.Controls.Add(this.skinButton_Quit);
            this.Controls.Add(this.skinButton_SignUp);
            this.Controls.Add(this.skinButton_SignIN);
            this.Controls.Add(this.label_ADPW);
            this.Controls.Add(this.label_ADID);
            this.Controls.Add(this.text_ADPW);
            this.Controls.Add(this.text_ADID);
            this.Controls.Add(this.skinMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_ADID;
        private System.Windows.Forms.TextBox text_ADPW;
        private System.Windows.Forms.Label label_ADID;
        private System.Windows.Forms.Label label_ADPW;
        private CCWin.SkinControl.SkinButton skinButton_SignIN;
        private CCWin.SkinControl.SkinButton skinButton_SignUp;
        private CCWin.SkinControl.SkinButton skinButton_Quit;
        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 其他设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于作者ToolStripMenuItem;
        private CCWin.SkinControl.SkinLine skinLine1;
    }
}


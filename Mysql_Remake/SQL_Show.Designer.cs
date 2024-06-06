
namespace Mysql_Remake
{
    partial class SQL_Show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQL_Show));
            this.ServerIp_box = new Sunny.UI.UIIPTextBox();
            this.Username_box = new Sunny.UI.UITextBox();
            this.Password_box = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.SQLData_box = new Sunny.UI.UIComboBox();
            this.uiTransfer1 = new Sunny.UI.UITransfer();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // ServerIp_box
            // 
            this.ServerIp_box.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ServerIp_box.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerIp_box.Location = new System.Drawing.Point(142, 72);
            this.ServerIp_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServerIp_box.MinimumSize = new System.Drawing.Size(1, 1);
            this.ServerIp_box.Name = "ServerIp_box";
            this.ServerIp_box.Padding = new System.Windows.Forms.Padding(1);
            this.ServerIp_box.ShowText = false;
            this.ServerIp_box.Size = new System.Drawing.Size(150, 29);
            this.ServerIp_box.TabIndex = 0;
            this.ServerIp_box.Text = "127.0.0.1";
            this.ServerIp_box.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ServerIp_box.Value = ((System.Net.IPAddress)(resources.GetObject("ServerIp_box.Value")));
            // 
            // Username_box
            // 
            this.Username_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_box.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Username_box.Location = new System.Drawing.Point(458, 72);
            this.Username_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username_box.MinimumSize = new System.Drawing.Size(1, 16);
            this.Username_box.Name = "Username_box";
            this.Username_box.Padding = new System.Windows.Forms.Padding(5);
            this.Username_box.ShowText = false;
            this.Username_box.Size = new System.Drawing.Size(150, 29);
            this.Username_box.TabIndex = 1;
            this.Username_box.Text = "root";
            this.Username_box.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Username_box.Watermark = "";
            // 
            // Password_box
            // 
            this.Password_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_box.DoubleValue = 111111D;
            this.Password_box.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password_box.IntValue = 111111;
            this.Password_box.Location = new System.Drawing.Point(777, 72);
            this.Password_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_box.MinimumSize = new System.Drawing.Size(1, 16);
            this.Password_box.Name = "Password_box";
            this.Password_box.Padding = new System.Windows.Forms.Padding(5);
            this.Password_box.ShowText = false;
            this.Password_box.Size = new System.Drawing.Size(161, 29);
            this.Password_box.TabIndex = 2;
            this.Password_box.Text = "111111";
            this.Password_box.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Password_box.Watermark = "";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(620, 138);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(116, 35);
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "连接";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // SQLData_box
            // 
            this.SQLData_box.DataSource = null;
            this.SQLData_box.FillColor = System.Drawing.Color.White;
            this.SQLData_box.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SQLData_box.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.SQLData_box.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.SQLData_box.Location = new System.Drawing.Point(45, 144);
            this.SQLData_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SQLData_box.MinimumSize = new System.Drawing.Size(63, 0);
            this.SQLData_box.Name = "SQLData_box";
            this.SQLData_box.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.SQLData_box.Size = new System.Drawing.Size(545, 29);
            this.SQLData_box.SymbolSize = 24;
            this.SQLData_box.TabIndex = 4;
            this.SQLData_box.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.SQLData_box.Watermark = "";
            this.SQLData_box.SelectedIndexChanged += new System.EventHandler(this.SQLData_box_SelectedIndexChanged);
            // 
            // uiTransfer1
            // 
            this.uiTransfer1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTransfer1.Location = new System.Drawing.Point(45, 203);
            this.uiTransfer1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.uiTransfer1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTransfer1.Name = "uiTransfer1";
            this.uiTransfer1.Padding = new System.Windows.Forms.Padding(1);
            this.uiTransfer1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiTransfer1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiTransfer1.ShowText = false;
            this.uiTransfer1.Size = new System.Drawing.Size(545, 454);
            this.uiTransfer1.TabIndex = 5;
            this.uiTransfer1.Text = "uiTransfer1";
            this.uiTransfer1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(620, 299);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(116, 35);
            this.uiButton2.TabIndex = 6;
            this.uiButton2.Text = "生成";
            this.uiButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(822, 138);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(116, 35);
            this.uiSymbolButton1.TabIndex = 7;
            this.uiSymbolButton1.Text = "选择文件夹";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(620, 203);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(318, 29);
            this.uiTextBox1.TabIndex = 8;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(788, 299);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(150, 35);
            this.uiButton3.TabIndex = 9;
            this.uiButton3.Text = "修改SQL配置文件";
            this.uiButton3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(42, 78);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(93, 23);
            this.uiLabel1.TabIndex = 10;
            this.uiLabel1.Text = "数据库IP :";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(358, 78);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(93, 23);
            this.uiLabel2.TabIndex = 11;
            this.uiLabel2.Text = "数据库ID :";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(677, 78);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(93, 23);
            this.uiLabel3.TabIndex = 12;
            this.uiLabel3.Text = "数据库密码 :";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SQL_Show
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(969, 696);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiTransfer1);
            this.Controls.Add(this.SQLData_box);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.Username_box);
            this.Controls.Add(this.ServerIp_box);
            this.MaximizeBox = false;
            this.Name = "SQL_Show";
            this.ShowIcon = false;
            this.Text = "";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIIPTextBox ServerIp_box;
        private Sunny.UI.UITextBox Username_box;
        private Sunny.UI.UITextBox Password_box;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIComboBox SQLData_box;
        private Sunny.UI.UITransfer uiTransfer1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
    }
}


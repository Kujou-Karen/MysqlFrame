using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using BLL;
using Model;
using Creat;

namespace Mysql_Remake
{
    public partial class SQL_Show : UIForm
    {

        DB dbModel = new DB();
        Model1 model1 = new Model1();
        DAL1 dal1 = new DAL1();
        BLL1 bll1 = new BLL1();
        MysqlHelper sqlhelper = new MysqlHelper();
        DBHandle dbhandle;
        public sqlcon sqlcon;

        public SQL_Show()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

            string serverIp = ServerIp_box.Text;
            string username = Username_box.Text;
            string password = Password_box.Text;

            dbModel.ServerIp = serverIp;
            dbModel.Username = username;
            dbModel.Password = password;

            dbhandle = new DBHandle(serverIp, username, password);
            sqlcon = new sqlcon(serverIp, username, password, SQLData_box.Text);

            // 处理DBModel
            dbhandle.ProcessDBModel(dbModel);

            // 将数据库名称加载到ComboBox中
            SQLData_box.Items.Clear();
            uiTransfer1.ItemsRight.Clear();
            uiTransfer1.ItemsLeft.Clear();
            foreach (string dbName in dbModel.DatabaseNames)
            {
                SQLData_box.Items.Add(dbName);
            }
            if (SQLData_box.Items.Count > 0)
            {
                SQLData_box.SelectedIndex = 0;
            }
        }

        private void SQLData_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDatabase = SQLData_box.SelectedItem.ToString();
            uiTransfer1.ItemsLeft.Clear();
            foreach (string tableName in dbModel.TablesInDatabases[selectedDatabase])
            {
                uiTransfer1.ItemsLeft.Add(tableName);
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            string a = SQLData_box.Text;
            foreach (string tableName in uiTransfer1.ItemsRight)
            {
                DataTable data = dbhandle.ColumnsInData(a, tableName);
                if (string.IsNullOrEmpty(uiTextBox1.Text))
                {
                    UIMessageTip.ShowOk("路径不能为空");
                }
                else
                { 
                    model1.CreatModel(tableName, data, uiTextBox1.Text);
                    dal1.CreatDAL(tableName, data, uiTextBox1.Text);
                    bll1.CreatBLL(tableName, data, uiTextBox1.Text);                
                }
               
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string dir = "";
            if (DirEx.SelectDirEx("扩展打开文件夹", ref dir))
            {
                uiTextBox1.Text = dir;
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            bool result = sqlhelper.CreatMYSQLHelper(sqlcon, uiTextBox1.Text);

            if (result)
            {
                MessageBox.Show("successfully");
            }
            else
            {
                MessageBox.Show("MysqlHelper.cs file not found.");
            }
        }
    }
}

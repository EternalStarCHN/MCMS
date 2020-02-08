using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MCMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        static string connString = "server=localhost;database=mcms;uid=root;pwd=697399";
        MySqlConnection conn = new MySqlConnection(connString);

        private void skinButton_SignIN_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (text_ADID.Text.Trim() == "" || text_ADPW.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名或密码", "提示");
                text_ADID.Focus();
            }
            else
            {
                string sql = "select password from administrator where administratorid='" + text_ADID.Text + "'";
                MySqlCommand mys = new MySqlCommand(sql, conn);
                MySqlDataReader reader = mys.ExecuteReader();
                while (reader.Read())
                {
                    string getpasswd = reader.GetString(reader.GetOrdinal("Password"));
                    if (getpasswd == text_ADPW.Text)
                    {
                        MessageBox.Show("登录成功", "恭喜！");
                        Form Form_User = new User();
                        Form_User.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密码错误", "出错了！");
                    }
                }
            }
            conn.Close();
        }

        private void skinButton_SignUp_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (text_ADID.Text.Trim() == "" || text_ADPW.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名或密码", "提示");
                text_ADID.Focus();
            }
            else
            {
                string sql = "insert into administrator values('" + text_ADID.Text + "','" + text_ADPW.Text + "')";
                MySqlCommand mys = new MySqlCommand(sql, conn);
                int result = mys.ExecuteNonQuery();
                if (result != 0)
                {
                    MessageBox.Show("注册成功","恭喜！");
                }
                else
                {
                    MessageBox.Show("注册失败","出错了！");
                }
            }
            conn.Close();
        }

        private void skinButton_Quit_Click(object sender, EventArgs e)
        {
            text_ADID.Clear();
            text_ADPW.Clear();
            text_ADID.Focus();
            this.Close();
            Application.Exit();
        }

        private void 关于作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("电信1702\r\n刘永欣\r\n31702440", "作者说明");
        }

        private void 操作说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1、新用户需先进行注册后登录数据库操作\r\n2、输入正确的账号密码即可登录数据库", "操作说明");
        }
    }
}

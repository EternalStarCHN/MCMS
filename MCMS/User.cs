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
using MySQLDriverCS;

namespace MCMS
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        MySQLConnection conn1 = new MySQLConnection(new MySQLConnectionString("localhost", "mcms", "root", "697399").AsString);
        static string connString = "server=localhost;database=mcms;uid=root;pwd=697399";
        MySqlConnection conn = new MySqlConnection(connString);

        string weekstr = "";

        private void User_Load(object sender, EventArgs e)
        {
            conn1.Open();
            string sql = "select mealcardid as '饭卡ID号',mealcardinformation as '饭卡余额', mealcardstatus as '饭卡状态' from mealcard";
            MySQLDataAdapter ada1 = new MySQLDataAdapter(sql, conn1);
            DataSet ds1 = new DataSet();
            ada1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            sql = "select dishid as '菜品ID号', dishquantity as '菜品数量', dishinformation as '菜品单价',dishstatus as '菜品状态' from Dish";
            MySQLDataAdapter ada2 = new MySQLDataAdapter(sql, conn1);
            DataSet ds2 = new DataSet();
            ada2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            conn1.Close();

            this.timer1.Start();
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday": weekstr = "星期一"; break;
                case "Tuesday": weekstr = "星期二"; break;
                case "Wednesday": weekstr = "星期三"; break;
                case "Thursday": weekstr = "星期四"; break;
                case "Friday": weekstr = "星期五"; break;
                case "Saturday": weekstr = "星期六"; break;
                case "Sunday": weekstr = "星期日"; break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MealCardID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox_MealCardInformation.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_MealCardStatus.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_DishID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox_DishQuantity.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox_DishInformation.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBox_DishStatus.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void skinButton_MealCardIncrease_Click(object sender, EventArgs e)
        {
            conn1.Open();
            string mealcardid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string mealcardinformation = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string mealcardstatus = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string sql = "insert into mealcard values('" + mealcardid + "','" + mealcardinformation + "','" + mealcardstatus + "')";
            MySQLCommand mys = new MySQLCommand(sql, conn1);
            if (mys.ExecuteNonQuery() != -1)
            {
                MessageBox.Show("新增成功！", "恭喜");
                sql = "select * from mealcard";
                MySQLDataAdapter ada1 = new MySQLDataAdapter(sql, conn1);
                DataSet ds1 = new DataSet();
                ada1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];

                textBox_MealCardID.Clear();
                textBox_MealCardInformation.Clear();
                textBox_MealCardStatus.Clear();
            }
        }

        private void skinButton_MealCardEdit_Click(object sender, EventArgs e)
        {
            conn1.Open();
            if (MessageBox.Show("确定要从数据库中修改这一行数据吗？", "数据无法恢复请慎重选择！", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string mealcardid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string mealcardinformation = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string mealcardstatus = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string sql = "update mealcard set mealcardid=" + mealcardid + ",mealcardinformation=" + mealcardinformation + ",mealcardstatus=" + mealcardstatus + " where mealcardid=" + mealcardid;
                MySQLCommand mys = new MySQLCommand(sql, conn1);
                if (mys.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("修改成功！", "恭喜");
                    sql = "select * from mealcard";
                    MySQLDataAdapter ada1 = new MySQLDataAdapter(sql, conn1);
                    DataSet ds1 = new DataSet();
                    ada1.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                }
            }
            conn1.Close();
        }

        private void skinButton_Refreash1_Click(object sender, EventArgs e)
        {
            conn1.Open();
            string sql = "select * from mealcard";
            MySQLDataAdapter ada1 = new MySQLDataAdapter(sql, conn1);
            DataSet ds1 = new DataSet();
            ada1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            MessageBox.Show("已刷新", "提示");
            conn1.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            conn1.Open();
            if (MessageBox.Show("确定要从数据库中删除这一行数据吗？", "数据无法恢复请慎重选择！", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int mealcardid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                string sql = "delete from mealcard where mealcardid=" + mealcardid;
                MySQLCommand mys = new MySQLCommand(sql, conn1);
                if (mys.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("删除成功！", "恭喜");
                    sql = "select * from mealcard";
                    MySQLDataAdapter ada1 = new MySQLDataAdapter(sql, conn1);
                    DataSet ds1 = new DataSet();
                    ada1.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示");
                }
            }
            conn1.Close();
        }

        private void skinButton_DishIncrease_Click(object sender, EventArgs e)
        {
            conn1.Open();
            string dishid = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            string dishquantity = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            string dishinformation = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            string dishstatus = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            string sql = "insert into dish values('" + dishid + "','" + dishquantity + "','" + dishinformation + "','" + dishstatus + "')";
            MySQLCommand mys = new MySQLCommand(sql, conn1);
            if (mys.ExecuteNonQuery() != -1)
            {
                MessageBox.Show("新增成功！", "恭喜");
                sql = "select * from dish";
                MySQLDataAdapter ada2 = new MySQLDataAdapter(sql, conn1);
                DataSet ds2 = new DataSet();
                ada2.Fill(ds2);
                dataGridView2.DataSource = ds2.Tables[0];

                textBox_DishID.Clear();
                textBox_DishQuantity.Clear();
                textBox_DishInformation.Clear();
                textBox_DishStatus.Clear();
            }
            conn1.Close();
        }

        private void skinButton_DishEdit_Click(object sender, EventArgs e)
        {
            conn1.Open();
            if (MessageBox.Show("确定要从数据库中修改这一行数据吗？", "数据无法恢复请慎重选择！", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string dishid = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string dishquantity = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                string dishinformation = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                string dishstatus = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                string sql = "update dish set dishid=" + dishid + ",dishquantity=" + dishquantity + ",dishinformation=" + dishinformation + ",dishstatus=" + dishstatus + " where dishid=" + dishid;
                MySQLCommand mys = new MySQLCommand(sql, conn1);
                if (mys.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("修改成功！", "恭喜");
                    sql = "select * from dish";
                    MySQLDataAdapter ada2 = new MySQLDataAdapter(sql, conn1);
                    DataSet ds2 = new DataSet();
                    ada2.Fill(ds2);
                    dataGridView2.DataSource = ds2.Tables[0];

                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                }
            }
            conn1.Close();
        }

        private void skinButton_Refreash2_Click(object sender, EventArgs e)
        {
            conn1.Open();
            string sql = "select * from dish";
            MySQLDataAdapter ada2 = new MySQLDataAdapter(sql, conn1);
            DataSet ds2 = new DataSet();
            ada2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            MessageBox.Show("已刷新","提示");
            conn1.Close();
        }

        private void skinButton_DishDelete_Click(object sender, EventArgs e)
        {
            conn1.Open();
            if (MessageBox.Show("确定要从数据库中删除这一行数据吗？", "数据无法恢复请慎重选择！", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int dishid = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                string sql = "delete from dish where dishid=" + dishid;
                MySQLCommand mys = new MySQLCommand(sql, conn1);
                if (mys.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("删除成功！", "提示");
                    sql = "select * from dish";
                    MySQLDataAdapter ada2 = new MySQLDataAdapter(sql, conn1);
                    DataSet ds2 = new DataSet();
                    ada2.Fill(ds2);
                    dataGridView2.DataSource = ds2.Tables[0];
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示");
                }
            }
            conn1.Close();
        }

        private void skinButton_Find1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox_MealCardID.Text.Trim() == "")
            {
                MessageBox.Show("请输入饭卡ID号", "提示");
            }
            else
            {
                String sql = "select * from mealcard where mealcardid =" + textBox_MealCardID.Text;
                MySqlCommand mys = new MySqlCommand(sql, conn);
                MySqlDataReader reader = mys.ExecuteReader();
                while (reader.Read())
                {
                    string getmealcardinformation = reader.GetString(reader.GetOrdinal("mealcardinformation"));
                    string getmealcardstatus = reader.GetString(reader.GetOrdinal("mealcardstatus"));
                    textBox_MealCardInformation.Text = getmealcardinformation;
                    textBox_MealCardStatus.Text = getmealcardstatus;
                }
                MessageBox.Show("查询成功！", "恭喜");
            }
            conn.Close();
        }

        private void skinButton1_Click_1(object sender, EventArgs e)
        {
            textBox_MealCardID.Clear();
            textBox_MealCardInformation.Clear();
            textBox_MealCardStatus.Clear();
        }

        private void skinButton_Find2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox_DishID.Text.Trim() == "")
            {
                MessageBox.Show("请输入菜品ID号", "提示");
            }
            else
            {
                String sql = "select * from dish where dishid =" + textBox_DishID.Text;
                MySqlCommand mys = new MySqlCommand(sql, conn);
                MySqlDataReader reader = mys.ExecuteReader();
                while (reader.Read())
                {
                    string getdishquantity = reader.GetString(reader.GetOrdinal("dishquantity"));
                    string getdishinformation = reader.GetString(reader.GetOrdinal("dishinformation"));
                    string getdishstatus = reader.GetString(reader.GetOrdinal("dishstatus"));
                    textBox_DishQuantity.Text = getdishquantity;
                    textBox_DishInformation.Text = getdishinformation;
                    textBox_DishStatus.Text = getdishstatus;
                }
                MessageBox.Show("查询成功！","恭喜");
            }
            conn.Close();
        }

        private void skinButton_Clear2_Click(object sender, EventArgs e)
        {
            textBox_DishID.Clear();
            textBox_DishQuantity.Clear();
            textBox_DishInformation.Clear();
            textBox_DishStatus.Clear();
        }

        private void 功能介绍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此程序集合了数据库的增删改查功能\r\n增加、修改、删除操作可以直接在表给内进行操作\r\n查询须在相应输入框内输入ID号进行查询","功能介绍");
        }

        private void skinButton_Quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("成功退出！","谢谢您的使用");
                this.Close();
                Application.Exit();
            }
            else
            {

            }
        }

        private void 关于作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("电信1702\r\n刘永欣\r\n31702440", "作者说明");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Time.Text = "当前时间:" + DateTime.Now.ToString() + " " + weekstr;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label_Infor1.Text = label_Infor1.Text.Substring(1) + label_Infor1.Text.Substring(0, 1);
            label_Infor2.Text = label_Infor2.Text.Substring(1) + label_Infor2.Text.Substring(0, 1);
        }
    }
}
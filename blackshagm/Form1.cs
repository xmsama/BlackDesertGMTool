using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackshagm
{
    public partial class Form1 : Form
    {
        public class Users {
            public Users(string _id, string family,string lastLogout,string playedTime)
            {
                this._id = _id;
                this.family = family;
                this.lastLogout = lastLogout;
                this.playedTime = playedTime;
            }
             public string _id { get; set; }
             public string family { get; set; }
            public string lastLogout { get; set; }
            public string playedTime { get; set; }



        }
        public static MongoClient client;
        public static IMongoCollection<MongoDB.Bson.BsonDocument> collection;   //注意全局变量要使用static 
        public static IList<Users> cList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                client = new MongoClient("mongodb://" + textBox3.Text + ":" + textBox2.Text);
            
                client.ListDatabaseNames();
                button1.Enabled = false;
                button1.Text = "不给你断开";
                button2.Enabled = true;
                MessageBox.Show("连接成功！");
            
            }
            catch {
                MessageBox.Show("连接失败！");
            }
           
           
        }
        public static DateTime GetTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
        public static string GetPlayTime(int timeStamp)
        {
            int minutes = timeStamp / 60;
            int hour = minutes / 60;
            minutes -= hour * 60;
            int day= hour / 24;
            hour -= day * 24;
            int months = day / 30;
            day -= months * 30;
            return months+"月 "+day+"天 "+hour+"小时 "+minutes+"分钟";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var database = client.GetDatabase("gameserver");
                collection = database.GetCollection<BsonDocument>("accounts");
               
                List<BsonDocument> ccList;
                cList = new BindingList<Users>();
                if (textBox8.Text == "")
                {
                     ccList = collection.Find(new BsonDocument()).ToList();
                }
                else {
                     ccList = collection.Find(Builders<BsonDocument>.Filter.Eq("family", textBox8.Text)).ToList();
                }

                //   Console.WriteLine($"【当前集合数据量】>>>【{ccList.Count}】>>>{DateTime.Now}");
                foreach (var user in ccList)
                {
                    string lastlogout = (user["lastLogout"].ToInt64() / 1000).ToString();

                    int playedTime = (int)(user["playedTime"].ToInt64() / 1000);

                    Users u = new Users(user["_id"].ToString(), user["family"].ToString(), GetTime(lastlogout).ToString(), GetPlayTime(playedTime).ToString());

                    cList.Add(u);
                }

                Console.Write(cList[0]);
                this.dataGridView1.DataSource = cList;
            }
            catch {

                MessageBox.Show("没有找到相关账号！");
            }
           
        }




         //选择账号ID
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch {

            }
            
        }
        public string GetTimeStamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64((ts.TotalSeconds)*1000).ToString();
        }
        public void insermail(string accountid)
        {
            try
            {

                var database = client.GetDatabase("gameserver");

                collection = database.GetCollection<BsonDocument>("mails");
                Console.WriteLine("wuhu ");

                //查找最大id

                var maillist = collection.Find(new BsonDocument()).ToList();

                long max = 0;
                foreach (var mail in maillist)
                {
                    if (mail["_id"] > max)
                    {
                        max = mail["_id"].ToInt64();
                    }
                }

                var document = new BsonDocument
            {
                { "_id", new BsonInt64 (max+1) },
                { "accountId",  new BsonInt64 (long.Parse(accountid)) },
                { "senderAccountId",  new BsonInt64(-1) },
                { "name", textBox6.Text },
                { "mailSubject",textBox7.Text },
                { "mailMessage", textBox9.Text},
                {"receivedTime", new BsonInt64( long.Parse(GetTimeStamp()))},
                { "item", new BsonDocument{
                     { "objectId", new BsonInt64(-1)  },
                     { "itemId", int.Parse(textBox4.Text) },
                     { "regionId", 1 },
                     { "enchantLevel",int.Parse(textBox12.Text)},
                     { "count",new BsonInt64 (long.Parse(textBox5.Text))  },
                     { "endurance",int.Parse(textBox10.Text) },
                     { "maxEndurance",int.Parse(textBox11.Text) },
                     { "expirationPeriod", new BsonInt64(-1)},
                     { "price",  new BsonInt64(1)},
                     { "alchemyStoneExp",0},
                     { "colorPaletteType",0},
                     { "jewels", new BsonArray { } },
                     { "colorPalettes", new BsonArray { }},
                }},
                 { "buyCashItem",BsonNull.Value },
                 { "type",0 },
                 { "read",0 },
                };



                collection.InsertOne(document);
              
            }
            catch
            {
                MessageBox.Show("先连接数据库！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                var database = client.GetDatabase("gameserver");

                collection = database.GetCollection<BsonDocument>("mails");
                Console.WriteLine("wuhu ");

                //查找最大id

                var maillist = collection.Find(new BsonDocument()).ToList();

                long max = 0;
                foreach (var mail in maillist)
                {
                    if (mail["_id"] > max)
                    {
                        max = mail["_id"].ToInt64();
                    }
                }

                var document = new BsonDocument
            {
                { "_id", new BsonInt64 (max+1) },
                { "accountId",  new BsonInt64 (long.Parse(textBox1.Text)) },
                { "senderAccountId",  new BsonInt64(-1) },
                { "name", textBox6.Text },
                { "mailSubject",textBox7.Text },
                { "mailMessage", textBox9.Text},
                {"receivedTime", new BsonInt64( long.Parse(GetTimeStamp()))},
                { "item", new BsonDocument{
                     { "objectId", new BsonInt64(-1)  },
                     { "itemId", int.Parse(textBox4.Text) },
                     { "regionId", 1 },
                     { "enchantLevel",int.Parse(textBox12.Text)},
                     { "count",new BsonInt64 (long.Parse(textBox5.Text))  },
                     { "endurance",int.Parse(textBox10.Text) },
                     { "maxEndurance",int.Parse(textBox11.Text) },
                     { "expirationPeriod", new BsonInt64(-1)},
                     { "price",  new BsonInt64(1)},
                     { "alchemyStoneExp",0},
                     { "colorPaletteType",0},
                     { "jewels", new BsonArray { } },
                     { "colorPalettes", new BsonArray { }},
                }},
                 { "buyCashItem",BsonNull.Value },
                 { "type",0 },
                 { "read",0 },
                };



                collection.InsertOne(document);
                MessageBox.Show("发送成功 小退显示！");
            }
            catch {
                MessageBox.Show("先连接数据库！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                var database = client.GetDatabase("gameserver");
                collection = database.GetCollection<BsonDocument>("mails");
                collection.DeleteMany(Builders<BsonDocument>.Filter.Eq("accountId", new BsonInt64(long.Parse(textBox1.Text)))); //删除指定id的邮件
                MessageBox.Show("删除成功 小退显示！");
                
            }
            catch
            {
                MessageBox.Show("先连接数据库！");
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //其实遍历cclist就好了
                var j = 0;
                foreach (var user in cList)
                {
                    insermail(user._id);
                    j++;
                    
                }
                MessageBox.Show("发送成功 共发送" + j.ToString() + "份邮件 小退显示！");

            }
            catch {
                MessageBox.Show("先获取账号信息！");
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("不说了没写吗");

            /*
            var database = client.GetDatabase("gameserver");
            collection = database.GetCollection<BsonDocument>("mails");
            collection.DeleteMany(Builders<BsonDocument>.Filter.Empty);//无条件删除*/

        }
    }
}

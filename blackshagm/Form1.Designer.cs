namespace blackshagm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(293, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "27714";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "数据库IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(197, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "数据库端口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(502, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "MongoDB默认空密码 不允许远程连接";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(91, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "127.0.0.1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountId,
            this.HomeName,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(16, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(464, 222);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // AccountId
            // 
            this.AccountId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AccountId.DataPropertyName = "_id";
            this.AccountId.HeaderText = "账号ID";
            this.AccountId.Name = "AccountId";
            this.AccountId.ReadOnly = true;
            this.AccountId.Width = 61;
            // 
            // HomeName
            // 
            this.HomeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.HomeName.DataPropertyName = "family";
            this.HomeName.HeaderText = "家门名称";
            this.HomeName.Name = "HomeName";
            this.HomeName.ReadOnly = true;
            this.HomeName.Width = 61;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "lastLogout";
            this.Column1.HeaderText = "最后登出时间";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "playedTime";
            this.Column2.HeaderText = "游玩时长";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(362, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "获取账号信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "账号ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(486, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 528);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送邮件";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(178, 486);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 31);
            this.button5.TabIndex = 20;
            this.button5.Text = "发送全服";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox12.Location = new System.Drawing.Point(93, 294);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(68, 26);
            this.textBox12.TabIndex = 28;
            this.textBox12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(16, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "强化等级";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox11.Location = new System.Drawing.Point(210, 258);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(68, 26);
            this.textBox11.TabIndex = 26;
            this.textBox11.Text = "0";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(178, 215);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(68, 26);
            this.textBox10.TabIndex = 25;
            this.textBox10.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(15, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = "装备最大耐久度(道具写0)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(15, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "装备耐久度(道具写0)";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(93, 112);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(192, 93);
            this.textBox9.TabIndex = 22;
            this.textBox9.Text = "GM给你送了点好东西 赶紧V50";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(16, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "邮件内容";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 31);
            this.button4.TabIndex = 20;
            this.button4.Text = "清空他的邮件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 28);
            this.button3.TabIndex = 19;
            this.button3.Text = "发送";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(93, 32);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(140, 26);
            this.textBox7.TabIndex = 18;
            this.textBox7.Text = "GM给你发的垃圾";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(93, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(140, 26);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "GM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(16, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "寄件人";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "邮件标题";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(93, 420);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 26);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(15, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "物品数量";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(93, 378);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 26);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "物品ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(93, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label9.Location = new System.Drawing.Point(12, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "搜索家门名称(留空搜索全部)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(205, 69);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(147, 21);
            this.textBox8.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(0, 587);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(281, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "黑色沙漠  邮件GM工具 BY：小明姐姐";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1099, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(406, 17);
            this.toolStripStatusLabel1.Text = "黑色沙漠GM工具V1.0 BY:小明姐姐 宣传一下自己的群:978439087";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(63, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(336, 48);
            this.label16.TabIndex = 13;
            this.label16.Text = "天下苦黑沙GM已久 今有热心网友写一工具解之\r\n本软件完全免费 谁卖给你请立刻差评退款\r\n\r\n";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(306, 610);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(820, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 243);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待开发功能区";
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(21, 125);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 31);
            this.button8.TabIndex = 31;
            this.button8.Text = "角色信息修改";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(21, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 31);
            this.button7.TabIndex = 30;
            this.button7.Text = "配置修改";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(21, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 31);
            this.button6.TabIndex = 29;
            this.button6.Text = "删除全服邮件";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "黑沙GM邮件工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}


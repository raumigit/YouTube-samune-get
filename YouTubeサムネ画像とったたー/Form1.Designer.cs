namespace YouTubeサムネ画像とったたー
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonMaxresdefault = new System.Windows.Forms.RadioButton();
            this.radioButtonSdddefault = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxテキスト = new System.Windows.Forms.CheckBox();
            this.checkBoxクリップボード = new System.Windows.Forms.CheckBox();
            this.loglist = new System.Windows.Forms.ListBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "変換";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(18, 35);
            this.textBox_input.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(257, 19);
            this.textBox_input.TabIndex = 2;
            this.textBox_input.Click += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "YouTube短縮URL";
            // 
            // radioButtonMaxresdefault
            // 
            this.radioButtonMaxresdefault.AutoSize = true;
            this.radioButtonMaxresdefault.Checked = true;
            this.radioButtonMaxresdefault.Location = new System.Drawing.Point(5, 19);
            this.radioButtonMaxresdefault.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMaxresdefault.Name = "radioButtonMaxresdefault";
            this.radioButtonMaxresdefault.Size = new System.Drawing.Size(158, 16);
            this.radioButtonMaxresdefault.TabIndex = 4;
            this.radioButtonMaxresdefault.TabStop = true;
            this.radioButtonMaxresdefault.Text = "maxresdefault(一番大きい)";
            this.radioButtonMaxresdefault.UseVisualStyleBackColor = true;
            // 
            // radioButtonSdddefault
            // 
            this.radioButtonSdddefault.AutoSize = true;
            this.radioButtonSdddefault.Location = new System.Drawing.Point(5, 39);
            this.radioButtonSdddefault.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSdddefault.Name = "radioButtonSdddefault";
            this.radioButtonSdddefault.Size = new System.Drawing.Size(76, 16);
            this.radioButtonSdddefault.TabIndex = 5;
            this.radioButtonSdddefault.Text = "sdddefault";
            this.radioButtonSdddefault.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel1.Location = new System.Drawing.Point(16, 265);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "サムネ表示";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "出力";
            // 
            // checkBoxテキスト
            // 
            this.checkBoxテキスト.AutoSize = true;
            this.checkBoxテキスト.Location = new System.Drawing.Point(11, 125);
            this.checkBoxテキスト.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxテキスト.Name = "checkBoxテキスト";
            this.checkBoxテキスト.Size = new System.Drawing.Size(108, 16);
            this.checkBoxテキスト.TabIndex = 8;
            this.checkBoxテキスト.Text = "テキストとして出す";
            this.checkBoxテキスト.UseVisualStyleBackColor = true;
            // 
            // checkBoxクリップボード
            // 
            this.checkBoxクリップボード.AutoSize = true;
            this.checkBoxクリップボード.Location = new System.Drawing.Point(11, 144);
            this.checkBoxクリップボード.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxクリップボード.Name = "checkBoxクリップボード";
            this.checkBoxクリップボード.Size = new System.Drawing.Size(124, 16);
            this.checkBoxクリップボード.TabIndex = 9;
            this.checkBoxクリップボード.Text = "クリップボードに付ける";
            this.checkBoxクリップボード.UseVisualStyleBackColor = true;
            // 
            // loglist
            // 
            this.loglist.FormattingEnabled = true;
            this.loglist.ItemHeight = 12;
            this.loglist.Items.AddRange(new object[] {
            "Youtubeサムネ取得ver1.4.1",
            ">_"});
            this.loglist.Location = new System.Drawing.Point(275, 250);
            this.loglist.Margin = new System.Windows.Forms.Padding(2);
            this.loglist.Name = "loglist";
            this.loglist.Size = new System.Drawing.Size(182, 64);
            this.loglist.TabIndex = 11;
            this.loglist.SelectedIndexChanged += new System.EventHandler(this.SelectedYTcode);
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(11, 166);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(105, 16);
            this.checkBoxAll.TabIndex = 12;
            this.checkBoxAll.Text = "全解像度を出力";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "YoutubeIDをクリップボードに添付";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radioButtonSdddefault);
            this.groupBox1.Controls.Add(this.radioButtonMaxresdefault);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 61);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "サムネイルのサイズ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(469, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxAll);
            this.Controls.Add(this.loglist);
            this.Controls.Add(this.checkBoxクリップボード);
            this.Controls.Add(this.checkBoxテキスト);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "YouTubeサムネ取得";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonMaxresdefault;
        private System.Windows.Forms.RadioButton radioButtonSdddefault;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxテキスト;
        private System.Windows.Forms.CheckBox checkBoxクリップボード;
        private System.Windows.Forms.ListBox loglist;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


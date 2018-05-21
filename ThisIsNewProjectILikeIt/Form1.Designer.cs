namespace ThisIsNewProjectILikeIt
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findResult = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.findCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFuture = new System.Windows.Forms.Button();
            this.btnPast = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "찾기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn1_Clicked);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "찾을 내용";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "※주의사항 : 대,소문자 구분함, 한글 입력 이상함";
            // 
            // findResult
            // 
            this.findResult.AutoSize = true;
            this.findResult.Location = new System.Drawing.Point(694, 141);
            this.findResult.Name = "findResult";
            this.findResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.findResult.Size = new System.Drawing.Size(57, 12);
            this.findResult.TabIndex = 4;
            this.findResult.Text = "찾은 갯수";
            this.findResult.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Hack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(47, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(731, 192);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeft.BackgroundImage")));
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Location = new System.Drawing.Point(47, 133);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(18, 20);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRight.BackgroundImage")));
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Location = new System.Drawing.Point(71, 133);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(18, 20);
            this.btnRight.TabIndex = 6;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // findCount
            // 
            this.findCount.AutoSize = true;
            this.findCount.Location = new System.Drawing.Point(95, 137);
            this.findCount.Name = "findCount";
            this.findCount.Size = new System.Drawing.Size(23, 12);
            this.findCount.TabIndex = 7;
            this.findCount.Text = "0/0";
            this.findCount.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "바꾸기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(465, 112);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(100, 21);
            this.tbReplace.TabIndex = 2;
            this.tbReplace.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "를";
            this.label5.Visible = false;
            // 
            // btnFuture
            // 
            this.btnFuture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFuture.BackgroundImage")));
            this.btnFuture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFuture.Location = new System.Drawing.Point(557, 137);
            this.btnFuture.Name = "btnFuture";
            this.btnFuture.Size = new System.Drawing.Size(18, 20);
            this.btnFuture.TabIndex = 6;
            this.btnFuture.UseVisualStyleBackColor = true;
            this.btnFuture.Click += new System.EventHandler(this.btnFuture_Click);
            // 
            // btnPast
            // 
            this.btnPast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPast.BackgroundImage")));
            this.btnPast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPast.Location = new System.Drawing.Point(533, 137);
            this.btnPast.Name = "btnPast";
            this.btnPast.Size = new System.Drawing.Size(18, 20);
            this.btnPast.TabIndex = 6;
            this.btnPast.UseVisualStyleBackColor = true;
            this.btnPast.Click += new System.EventHandler(this.btnPast_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "로";
            this.label6.Visible = false;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(336, 136);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(88, 16);
            this.cbAll.TabIndex = 9;
            this.cbAll.Text = "모두 바꾸기";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 471);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.findCount);
            this.Controls.Add(this.btnFuture);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnPast);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.findResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label findResult;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label findCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFuture;
        private System.Windows.Forms.Button btnPast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbAll;
    }
}


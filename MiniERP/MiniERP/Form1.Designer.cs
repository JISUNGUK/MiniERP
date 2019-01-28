namespace MiniERP
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel_MesMap = new System.Windows.Forms.Panel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menu_1 = new System.Windows.Forms.Splitter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menu_2 = new System.Windows.Forms.Splitter();
            this.btn_Enroll = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_Enroll = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel_Enroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel_Enroll);
            this.splitContainer2.Size = new System.Drawing.Size(963, 503);
            this.splitContainer2.SplitterDistance = 733;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel_MesMap);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabMenu);
            this.splitContainer3.Size = new System.Drawing.Size(733, 503);
            this.splitContainer3.SplitterDistance = 244;
            this.splitContainer3.TabIndex = 0;
            // 
            // panel_MesMap
            // 
            this.panel_MesMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MesMap.Location = new System.Drawing.Point(0, 0);
            this.panel_MesMap.Name = "panel_MesMap";
            this.panel_MesMap.Size = new System.Drawing.Size(244, 503);
            this.panel_MesMap.TabIndex = 1;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPage3);
            this.tabMenu.Controls.Add(this.tabPage4);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(485, 503);
            this.tabMenu.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btn_Enroll);
            this.tabPage3.Controls.Add(this.menu_1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(477, 477);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "재고 I";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menu_1
            // 
            this.menu_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_1.Location = new System.Drawing.Point(3, 3);
            this.menu_1.Name = "menu_1";
            this.menu_1.Size = new System.Drawing.Size(471, 31);
            this.menu_1.TabIndex = 0;
            this.menu_1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.menu_2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(477, 477);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "재고 II";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // menu_2
            // 
            this.menu_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_2.Location = new System.Drawing.Point(3, 3);
            this.menu_2.Name = "menu_2";
            this.menu_2.Size = new System.Drawing.Size(471, 31);
            this.menu_2.TabIndex = 1;
            this.menu_2.TabStop = false;
            // 
            // btn_Enroll
            // 
            this.btn_Enroll.Location = new System.Drawing.Point(6, 6);
            this.btn_Enroll.Name = "btn_Enroll";
            this.btn_Enroll.Size = new System.Drawing.Size(83, 25);
            this.btn_Enroll.TabIndex = 1;
            this.btn_Enroll.Text = "기초등록";
            this.btn_Enroll.UseVisualStyleBackColor = true;
            this.btn_Enroll.Click += new System.EventHandler(this.btn_Enroll_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "영업 관리";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "구매 관리";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(273, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 25);
            this.button4.TabIndex = 4;
            this.button4.Text = "생산";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(362, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 25);
            this.button5.TabIndex = 5;
            this.button5.Text = "기타 이동";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel_Enroll
            // 
            this.panel_Enroll.Controls.Add(this.button11);
            this.panel_Enroll.Controls.Add(this.button10);
            this.panel_Enroll.Controls.Add(this.button9);
            this.panel_Enroll.Controls.Add(this.button8);
            this.panel_Enroll.Controls.Add(this.button7);
            this.panel_Enroll.Controls.Add(this.button1);
            this.panel_Enroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Enroll.Location = new System.Drawing.Point(0, 0);
            this.panel_Enroll.Name = "panel_Enroll";
            this.panel_Enroll.Size = new System.Drawing.Size(226, 503);
            this.panel_Enroll.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 25);
            this.button6.TabIndex = 2;
            this.button6.Text = "A/S 관리";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "거래처 등록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(223, 28);
            this.button7.TabIndex = 1;
            this.button7.Text = "창고 등록";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 174);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(223, 28);
            this.button8.TabIndex = 2;
            this.button8.Text = "품목 등록";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 216);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(223, 28);
            this.button9.TabIndex = 3;
            this.button9.Text = "품목별 단가";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 258);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(223, 28);
            this.button10.TabIndex = 4;
            this.button10.Text = "사원(담당) 등록";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 300);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(223, 28);
            this.button11.TabIndex = 5;
            this.button11.Text = "A/S등록";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 503);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel_Enroll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel_MesMap;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Splitter menu_1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Splitter menu_2;
        private System.Windows.Forms.Button btn_Enroll;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_Enroll;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
    }
}


namespace BoardAndCardGames
{
    partial class frmGame
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.picCard = new System.Windows.Forms.PictureBox();
            this.lvwPlayCards = new System.Windows.Forms.ListView();
            this.imgListCards = new System.Windows.Forms.ImageList(this.components);
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard
            // 
            this.picCard.Location = new System.Drawing.Point(749, 403);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(359, 232);
            this.picCard.TabIndex = 0;
            this.picCard.TabStop = false;
            this.picCard.Click += new System.EventHandler(this.picCard_Click);
            // 
            // lvwPlayCards
            // 
            this.lvwPlayCards.HideSelection = false;
            this.lvwPlayCards.LargeImageList = this.imgListCards;
            this.lvwPlayCards.Location = new System.Drawing.Point(37, 26);
            this.lvwPlayCards.Name = "lvwPlayCards";
            this.lvwPlayCards.Size = new System.Drawing.Size(1071, 281);
            this.lvwPlayCards.TabIndex = 1;
            this.lvwPlayCards.UseCompatibleStateImageBehavior = false;
            this.lvwPlayCards.SelectedIndexChanged += new System.EventHandler(this.lvwPlayCards_SelectedIndexChanged);
            // 
            // imgListCards
            // 
            this.imgListCards.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCards.ImageStream")));
            this.imgListCards.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCards.Images.SetKeyName(0, "d1.jpg");
            this.imgListCards.Images.SetKeyName(1, "d2.jpg");
            this.imgListCards.Images.SetKeyName(2, "d3.jpg");
            this.imgListCards.Images.SetKeyName(3, "d4.jpg");
            this.imgListCards.Images.SetKeyName(4, "d5.jpg");
            this.imgListCards.Images.SetKeyName(5, "d6.jpg");
            this.imgListCards.Images.SetKeyName(6, "d7.jpg");
            this.imgListCards.Images.SetKeyName(7, "d8.jpg");
            this.imgListCards.Images.SetKeyName(8, "d9.jpg");
            this.imgListCards.Images.SetKeyName(9, "d10.jpg");
            this.imgListCards.Images.SetKeyName(10, "d11.jpg");
            this.imgListCards.Images.SetKeyName(11, "d12.jpg");
            this.imgListCards.Images.SetKeyName(12, "d13.jpg");
            this.imgListCards.Images.SetKeyName(13, "h1.jpg");
            this.imgListCards.Images.SetKeyName(14, "h2.jpg");
            this.imgListCards.Images.SetKeyName(15, "h3.jpg");
            this.imgListCards.Images.SetKeyName(16, "h4.jpg");
            this.imgListCards.Images.SetKeyName(17, "h5.jpg");
            this.imgListCards.Images.SetKeyName(18, "h6.jpg");
            this.imgListCards.Images.SetKeyName(19, "h7.jpg");
            this.imgListCards.Images.SetKeyName(20, "h8.jpg");
            this.imgListCards.Images.SetKeyName(21, "h9.jpg");
            this.imgListCards.Images.SetKeyName(22, "h10.jpg");
            this.imgListCards.Images.SetKeyName(23, "h11.jpg");
            this.imgListCards.Images.SetKeyName(24, "h12.jpg");
            this.imgListCards.Images.SetKeyName(25, "h13.jpg");
            this.imgListCards.Images.SetKeyName(26, "j.jpg");
            this.imgListCards.Images.SetKeyName(27, "p1.jpg");
            this.imgListCards.Images.SetKeyName(28, "p2.jpg");
            this.imgListCards.Images.SetKeyName(29, "p3.jpg");
            this.imgListCards.Images.SetKeyName(30, "p4.jpg");
            this.imgListCards.Images.SetKeyName(31, "p5.jpg");
            this.imgListCards.Images.SetKeyName(32, "p6.jpg");
            this.imgListCards.Images.SetKeyName(33, "p7.jpg");
            this.imgListCards.Images.SetKeyName(34, "p8.jpg");
            this.imgListCards.Images.SetKeyName(35, "p9.jpg");
            this.imgListCards.Images.SetKeyName(36, "p10.jpg");
            this.imgListCards.Images.SetKeyName(37, "p11.jpg");
            this.imgListCards.Images.SetKeyName(38, "p12.jpg");
            this.imgListCards.Images.SetKeyName(39, "p13.jpg");
            this.imgListCards.Images.SetKeyName(40, "s1.jpg");
            this.imgListCards.Images.SetKeyName(41, "s2.jpg");
            this.imgListCards.Images.SetKeyName(42, "s3.jpg");
            this.imgListCards.Images.SetKeyName(43, "s4.jpg");
            this.imgListCards.Images.SetKeyName(44, "s5.jpg");
            this.imgListCards.Images.SetKeyName(45, "s6.jpg");
            this.imgListCards.Images.SetKeyName(46, "s7.jpg");
            this.imgListCards.Images.SetKeyName(47, "s8.jpg");
            this.imgListCards.Images.SetKeyName(48, "s9.jpg");
            this.imgListCards.Images.SetKeyName(49, "s10.jpg");
            this.imgListCards.Images.SetKeyName(50, "s11.jpg");
            this.imgListCards.Images.SetKeyName(51, "s12.jpg");
            this.imgListCards.Images.SetKeyName(52, "s13.jpg");
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(37, 570);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(133, 93);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "發牌";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(278, 570);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(133, 93);
            this.btnStay.TabIndex = 3;
            this.btnStay.Text = "過牌";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(526, 570);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(133, 93);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "重新開始";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(33, 380);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(106, 24);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "分數顯示";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(33, 486);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(154, 24);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "勝負狀態提示";
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1000;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 738);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lvwPlayCards);
            this.Controls.Add(this.picCard);
            this.Name = "frmGame";
            this.Text = "21點卡牌遊戲";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGame_FormClosing);
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.ListView lvwPlayCards;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.ImageList imgListCards;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardAndCardGames
{
    public partial class frmGame : Form
    {
        private List<int> cards = new List<int>();
        private SoundPlayer dealSound;
        private SoundPlayer winSound;
        private int playTotalScore = 0;
        private int remainingTime = 30;
        private SoundPlayer loseSound;
        public frmGame()
        {
            InitializeComponent();
        }
        private void frmGame_Load(object sender, EventArgs e)
        {
            try
            {
                dealSound = new SoundPlayer("sounds/deal.wav");
                winSound = new SoundPlayer("sounds/win.wav");
                loseSound = new SoundPlayer("sounds/lose.wav");
            }
            catch
            {

            }
            ResetGame();
        }
        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("確定要離開遊戲嗎?", "離開", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (cards.Count > 0)
            {
                try
                {
                    dealSound.Play();
                }
                catch
                {
                }

                int cardId = cards[0];
                cards.RemoveAt(0);

                ListViewItem item = new ListViewItem();
                item.ImageIndex = cardId;
                lvwPlayCards.Items.Add(item);

                int cardValue = (cardId % 13) + 1;
                if (cardValue > 10)
                {
                    cardValue = 10;
                }
                playTotalScore += cardValue;

                lblScore.Text = "當前牌點: " + playTotalScore.ToString();

                if (playTotalScore > 21)
                {
                    btnDraw.Enabled = false;
                    btnStay.Enabled = false;
                    lblStatus.Text = "爆牌了！遊戲結束。";
                    //MessageBox.Show("總點數 " + playTotalScore + " 點，你爆牌輸了！", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    try
                    {
                        if (loseSound != null) loseSound.Play();
                    }
                    catch { }

                    MessageBox.Show("總點數 " + playTotalScore + " 點，你爆牌輸了！", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        private void btnStay_Click(object sender, EventArgs e)
        {
            tmrGame.Stop();
            btnDraw.Enabled = false;
            btnStay.Enabled = false;
            lblStatus.Text = "遊戲結束，結算中...";

            int dealerScore = new Random().Next(15, 25);

            if (dealerScore > 21)
            {
                try
                {
                    if (winSound != null) winSound.Play();
                }
                catch { }
                MessageBox.Show("玩家: " + playTotalScore + " 點\n電腦: " + dealerScore + " 點 (爆牌)\n\n恭喜你贏了！", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (playTotalScore > dealerScore)
            {
                try
                {
                    if (winSound != null) winSound.Play();
                }
                catch { }
                MessageBox.Show("玩家: " + playTotalScore + " 點\n電腦: " + dealerScore + " 點\n\n恭喜你贏了！", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (playTotalScore < dealerScore)
            {
                try
                {
                    if (loseSound != null) loseSound.Play();
                }
                catch { }
                MessageBox.Show("玩家: " + playTotalScore + " 點\n電腦: " + dealerScore + " 點\n\n很遺憾你輸了！", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("玩家: " + playTotalScore + " 點\n電腦: " + dealerScore + " 點\n\n雙方平手！", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            cards.Clear();
            for (int i = 0; i < 52; i++)
            {
                cards.Add(i);
            }
            Shuffle();

            lvwPlayCards.Items.Clear();
            playTotalScore = 0;
            remainingTime = 30;

            btnDraw.Enabled = true;
            btnStay.Enabled = true;
            lblScore.Text = "點數: 0";
            lblStatus.Text = "剩餘時間: 30 秒";

            tmrGame.Start();
        }

        private void Shuffle()
        {
            Random rand = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                int value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
        private void tmrGame_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            lblStatus.Text = "剩餘時間: " + remainingTime.ToString() + " 秒";

            if (remainingTime <= 0)
            {
                tmrGame.Stop();
                btnDraw.Enabled = false;
                btnStay.Enabled = false;
                lblStatus.Text = "時間到！遊戲結束。";
                try
                {
                    if (loseSound != null) loseSound.Play();
                }
                catch { }

                MessageBox.Show("你思考超時，遊戲結束！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PlaySound(SoundPlayer player)
        {
            try
            {
                player.Play();
            }
            catch
            {

            }
        }

        private void picCard_Click(object sender, EventArgs e)
        {

        }
               
        private void lvwPlayCards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

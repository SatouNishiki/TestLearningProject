using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLearningProject.dice;

namespace TestLearningProject.app
{
    /// <summary>
    /// ダイスを出すフォームです
    /// </summary>
    public partial class DiceForm : Form
    {
        /// <summary>
        /// ダイスの一辺の大きさ
        /// </summary>
        private const int DiceSize = 50;

        /// <summary>
        /// PictureBoxのグラフィックハンドルを格納
        /// </summary>
        private Graphics graphics;

        /// <summary>
        /// 全ての表示ダイスを格納
        /// </summary>
        private List<Dice> dices;

        public DiceForm()
        {
            InitializeComponent();
            this.dices = new List<Dice>();
        }

        private void diceButton_Click(object sender, EventArgs e)
        {
            Dice dice = new Dice();

            this.dices.Add(dice);

            //出現するダイスのx, y座標をランダムで決定
            Random rand = new Random();
            dice.Position = new Point(rand.Next(this.drawPictureBox.Width), rand.Next(this.drawPictureBox.Height));

            graphics.DrawImage(dice.GetPicture(), dice.Position.X, dice.Position.Y, DiceSize, DiceSize);
        }

        private void DiceForm_Load(object sender, EventArgs e)
        {
            this.graphics = this.drawPictureBox.CreateGraphics();
        }

        private void DiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //手動でメモリ解放
            this.graphics.Dispose();

        }

        private void diceFallTimer_Tick(object sender, EventArgs e)
        {
            if (this.dices.Count == 0) return;

            this.drawPictureBox.Refresh();

            //pictureboxの範囲外にいったダイスを格納
            List<Dice> deleteDices = new List<Dice>();

            //ダイスを降らせる
            foreach (var dice in this.dices)
            {
                dice.Position = new Point(dice.Position.X, dice.Position.Y + 10);

                //範囲外に行ったら一旦格納
                if (dice.Position.Y > this.drawPictureBox.Size.Height)
                {
                    deleteDices.Add(dice);
                    continue;
                }
                graphics.DrawImage(dice.GetPicture(), dice.Position.X, dice.Position.Y, DiceSize, DiceSize);
            }

            //一斉に削除
            this.dices.RemoveAll(d => deleteDices.IndexOf(d) >= 0);
        }
    }
}

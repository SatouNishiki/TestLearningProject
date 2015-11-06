using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestLearningProject.dice
{
    /// <summary>
    /// サイコロを表すクラスです
    /// </summary>
    public class Dice
    {
        /// <summary>
        /// ダイスの画像パターン数
        /// </summary>
        private const int DicePattern = 3;

        /// <summary>
        /// ダイス画像
        /// </summary>
        private Bitmap picture;

        /// <summary>
        /// ダイスの画像タイプ
        /// </summary>
        public int DiceType { get; set; }

        /// <summary>
        /// 表示場所
        /// </summary>
        public Point Position { get; set; }
       
        public Dice()
        {
            //ダイスパターンをランダムで生成
            Random rand = new Random();
            this.DiceType = rand.Next(DicePattern);
        }

        /// <summary>
        /// ダイスタイプに応じた画像を返します
        /// </summary>
        /// <returns></returns>
        public Bitmap GetPicture()
        {
            try
            {
                if (this.picture == null)
                {
                    //同名前空間からタイプに応じたダイス画像を読み込み
                    picture = new Bitmap(this.GetType(), "dice" + this.DiceType.ToString() + ".png");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                picture = null;
            }

            return picture;
        }

        ~Dice()
        {
            this.picture.Dispose();
        }
    }
}

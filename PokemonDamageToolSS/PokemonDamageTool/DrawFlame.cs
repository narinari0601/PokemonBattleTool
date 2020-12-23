using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonDamageTool
{
    class DrawFlame
    {
        private PictureBox pictureBox;
        
        public DrawFlame(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void Draw()
        {
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //Penオブジェクトの作成(幅1の黒色)
            //(この場合はPenを作成せずに、Pens.Blackを使っても良い)
            Pen p = new Pen(Color.Black, 2);
            //位置(10, 20)に100x80の長方形を描く
            g.DrawRectangle(p, 0, 0, 318, 360);

            //リソースを解放する
            p.Dispose();
            g.Dispose();

            //PictureBox1に表示する
            pictureBox.Image = canvas;
        }
    }
}

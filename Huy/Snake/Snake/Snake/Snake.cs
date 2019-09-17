using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;

namespace Snake
{
    class Snake
    {
        private Rectangle[] snakeRec;

        public Rectangle[] SnakeRec
        {
            get
            {
                return snakeRec;
            }
        }

        private SolidBrush brush;   // cọ vẽ
        private int x, y, width, height;    // tọa độ

        // hàm khởi tạo rắn
        public Snake()
        {
            snakeRec = new Rectangle[3];    // chiều dài con rắn
            brush = new SolidBrush(Color.Red);
            x = 20;
            y = 0;
            width = 10; // w với h = 10 để thân con rắn là hình tròn
            height = 10;
            
            for(int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10;    // làm cho phần thân con rắn k bị đè lên chính nó
            }
        }

        // Vẽ rắn ban đầu
        public void drawSnake(Graphics paper)
        {
            foreach(Rectangle rec in snakeRec)
            {
                paper.FillEllipse(brush, rec);
            }
        }

        // vẽ rắn trong lúc di chuyển
        public void drawSnakeRun()
        {
            for(int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];  // tọa độ của con rắn sau bằng tọa độ của con bằng đi trước
            }
        }

        // di chuyển lên, xuống, trái, phải
        public void xuong()
        {
            drawSnakeRun();
            snakeRec[0].Y += 10;    // nếu di chuyển xuống thì tọa độ Y của SnakeRec tăng lên 10
        }
        public void len()
        {
            drawSnakeRun();
            snakeRec[0].Y -= 10;    // nếu di chuyển lên thì tọa độ Y của SnakeRec giảm đi 10
        }
        public void phai()
        {
            drawSnakeRun();
            snakeRec[0].X += 10;    // nếu di chuyển sang phải thì tọa độ X của SnakeRec tăng lên 10
        }
        public void trai()
        {
            drawSnakeRun();
            snakeRec[0].X -= 10;    // nếu di sang trái thì tọa độ X của SnakeRec giảm đi 10
        }

        // Hàm tăng kích thước của rắn khi rắn ăn mồi
        public void GrowSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            // kích thước rắn tăng thêm 1 vào vị trí cuối cùng của rắn
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));  
            snakeRec = rec.ToArray();   // cập nhập lại kích thước của rắn sau khi tăng
        }
    }
}

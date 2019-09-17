using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

// Lớp này tạo ra "thính" cho rắn. Khi ăn "Thính", rắn sẽ ngẫu nhiên tăng điểm,giảm điểm,tăng độ dài rắn,tăng tốc độ hoặc giảm tốc độ
namespace Snake
{
    class Thinh
    {
        
        public int x, y, width, height;   // vị trí, dài rộng của thính
        private SolidBrush brush;   // màu
        public Rectangle ThinhRec;  // cục thính

        public Thinh(Random RandomThinh)      // tạo ra thính ngẫu nhiên khác với vị trí của mồi
        {
            x = RandomThinh.Next(0,29)*10;    // tọa độ x
            y = RandomThinh.Next(0,29)*10;    // tọa độ y
            brush = new SolidBrush(Color.Orange);
            width = 15;
            height = 15;    // thính hình tròn
            ThinhRec = new Rectangle(x, y, width, height);
        }

        public void ThinhLo(Random RandomThinh)   // gọi hàm này thì sẽ có 1 miếng thính ở vị trí khác
        {
        
                x = RandomThinh.Next(0, 29)*10;    // tọa độ x
                y = RandomThinh.Next(0, 29)*10;    // tọa độ y
                
        }

        // vẽ thính
        public void drawThinh(Graphics paper)
        {
            ThinhRec.X = x;
            ThinhRec.Y = y;

            paper.FillEllipse(brush, ThinhRec);
        }
    }
}

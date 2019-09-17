using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

// Lớp này tạo ra mồi cho rắn, để rắn ăn vào sẽ dài ra
namespace Snake
{
    class Food
    {
        public int x,y,width,height;   // vị trí, dài rộng của mồi
        private SolidBrush brush;   // màu
        public Rectangle foodRec;

        public Food(Random RandomFood)      // tạo ra mồi ngẫu nhiên
        {
            x = RandomFood.Next(0, 29)*10;    // tọa độ x
            y = RandomFood.Next(0, 29)*10;    // tọa độ y

            brush = new SolidBrush(Color.Blue);

            width = 10;
            height = 10;    // mồi hình tròn
            foodRec = new Rectangle(x, y, width, height);
        }

        public void FoodLo(Random RandomFood)   // gọi hàm này thì sẽ có 1 miếng mồi ở vị trí khác
        {
            x = RandomFood.Next(0, 29)*10;    // tọa độ x
            y = RandomFood.Next(0, 29)*10;    // tọa độ y
        }
        
        public void drawfood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;

            paper.FillEllipse(brush, foodRec);
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Snake;

namespace SnakeProject
{
    public partial class Form1 : Form
    {
        Random RandomFood = new Random();
        Random RamdomThinh = new Random();
        Food food;
        Thinh thinh;
        Graphics paper; // đối tượng vẽ

        Snake.Snake snake = new Snake.Snake();  // Khai báo con rắn mới

        Boolean left = false, right = false, up = false, down = false;// 4 phím điều hướng để điều khiển con rắn

        int score = 0; // điểm
      
        public Form1()
        {
            food = new Food(RandomFood);    // khởi tạo mồi
            thinh = new Thinh(RamdomThinh); // khởi tạo thính
            while(food.x==thinh.x && food.y == thinh.y) // tránh trường hợp thính và food trùng nhau
            {
                thinh = new Thinh(RamdomThinh); // khởi tạo thính
            }
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.drawfood(paper);   // vẽ mồi
            thinh.drawThinh(paper); // vẽ thính
            snake.drawSnake(paper); // vẽ rắn
        }


        // Khi khởi tạo form1 thì 2 label level1 và level2 ẩn đi
        private void Form1_Load(object sender, EventArgs e)
        {
            level1.Hide();
            level2.Hide();
        }
       

        //e= thuộc tính parameter
        // điều hướng con rắn
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // có tất cả 4 trường hợp
            if (e.KeyData == Keys.Up && down == false)     // để tránh trường hợp đang bấm đi lên thì không thể đi xuống được
            {
                up = true;
                down = false;
                left = false;
                right = false;
            }

            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                left = false;
                right = false;
            }

            if (e.KeyData == Keys.Left && right == false)
            {
                left = true;
                right = false;
                up = false;
                down = false;
            }

            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                left = false;
                right = true;
            }

        }

        private void newgame_Click(object sender, EventArgs e)
        {
            level1.Show();
            level2.Show();
            newgame.Hide();
            High.Hide();
            Exit_btn.Hide();
            btn_About.Hide();
            lbSnake.Hide();
        }

        // level chọn để chơi
        private void level1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 200;  // đặt tốc độ ban đầu
            left = false; right = false; up = false; down = false;
            level1.Hide();  // click vào xong thì 2 button level1 và level2 ẩn đi
            level2.Hide();
            panel1.Hide();
        
        }
        private void level2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;  // đặt tốc độ ban đầu
            left = false; right = false; up = false; down = false;
            level1.Hide();  // click vào xong thì 2 button level1 và level2 ẩn đi
            level2.Hide();
            panel1.Hide();
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
           
            // tăng điểm
            toolStripStatusLabelScore.Text = score.ToString();
            toolStripStatusLabelSpeed.Text = timer1.Interval.ToString();
            toolStripStatusLabelLength.Text = snake.SnakeRec.Length.ToString();
            // bắt sự kiện bàn phím ấn nút điều hướng nào
            if (down == true) { snake.xuong(); }
            if (up == true) { snake.len(); }
            if (left == true) { snake.trai(); }
            if (right == true) { snake.phai(); }

            eatmoi(); // ăn mồi
            eatthinh(); // ăn thính
            collision();    // xử lý va chạm tường và cắn đuôi
            this.Invalidate();
        }

        // ăn mồi
        public void eatmoi()
        {
            // Phát hiện rắn ăn mồi sẽ tăng kích thước của rắn lên và thay đổi vị trí của mồi
            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    score += 1;
                    food.FoodLo(RandomFood);    // random mồi mới
                    while (food.x == thinh.x && food.y == thinh.y) // tránh trường hợp thính và food trùng nhau
                    {
                        food.FoodLo(RandomFood);
                    }
                    snake.GrowSnake();  // tăng kích thước rắn lên
                    speedup();
                }
            }
        }
        // ăn thính
        public void eatthinh()
        {
            Random r = new Random();
            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[i].IntersectsWith(thinh.ThinhRec))
                {
                    int random = r.Next(1, 6); // tạo random để khi ăn thính sẽ rơi vào nhiều trường hợp
                    if (random == 1)    // nếu random bằng 1 thì điểm sẽ tăng
                    {
                        score += 10; // tăng điểm

                        thinh.ThinhLo(RamdomThinh);// đổi vị trí thính
                        while (food.x == thinh.x && food.y == thinh.y) // tránh trường hợp thính và food trùng nhau
                        {
                            thinh.ThinhLo(RamdomThinh);
                        }

                    }

                    if (random == 2)    // ăn thính sẽ bị tăng độ dài lên 5 nhưng không tăng điểm
                    {
                        // tăng thêm 5
                        for (int j = 0; j < 5; j++)
                        {
                            snake.GrowSnake();
                        }
                        thinh.ThinhLo(RamdomThinh); // đổi vị trí thính
                        while (food.x == thinh.x && food.y == thinh.y) // tránh trường hợp thính và food trùng nhau
                        {
                            thinh.ThinhLo(RamdomThinh);
                        }
                    }
                    if (random == 3)    // ăn thính không được gì nhưng bị trừ điểm
                    {
                        score -= 5; // trừ điểm

                        thinh.ThinhLo(RamdomThinh); // đổi vị trí thính
                        while (food.x == thinh.x && food.y == thinh.y) // tránh trường hợp thính và food trùng nhau
                        {
                            thinh.ThinhLo(RamdomThinh);
                        }
                    }
                    if (random == 4) // ăn thính này bị tăng tốc độ
                    {
                        if (timer1.Interval > 20) // nếu interval > 20 thì bị trừ 20, tránh trường hợp interval âm
                        {
                            timer1.Interval -= 20;
                        }

                        thinh.ThinhLo(RamdomThinh); // đổi vị trí thính
                        while (food.x == thinh.x && food.y == thinh.y) // tránh trường hợp thính và food trùng nhau
                        {
                            thinh.ThinhLo(RamdomThinh);
                        }
                    }
                    if (random == 5) // ăn thính này giúp rắn giảm tốc độ lại
                    {
                        timer1.Interval += 10; // giảm tốc độ đi 10

                        thinh.ThinhLo(RamdomThinh); // đổi vị trí thính
                        while (food.x == thinh.x && food.y == thinh.y) // tránh trường hợp thính và food trùng nhau
                        {
                            thinh.ThinhLo(RamdomThinh);
                        }
                    }
                }
            }
        }

        // xử lí đụng tường, cắn vào đuôi
        public void collision()
        {
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                // nếu rắn cắn vào thân mình thì dừng chương trình
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    diemcao();
                    reset();
                }
            }

            // xử lí rắn đâm vào tường ( X,Y ở đây bé hơn 290 vì chúng ta đã giới hạn mồi ở trong phạm vi 290 như trên rồi )
            if (snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 290)
            {
                diemcao();
                reset();

            }
            if (snake.SnakeRec[0].X < 0 || snake.SnakeRec[0].X > 290)
            {
                diemcao();
                reset();

            }
        }

        // xử lí tăng tốc độ cho rắn
        // cứ mỗi 5 điểm thì tăng tốc độ cho rắn
        // tăng tốc cho tới khi time1.interval= 50 thì dừng lại
        public void speedup()
        {
            if (score%5==0 && timer1.Interval>50)
            {
                timer1.Interval -= 10;
            }
        }


        // xử lí chơi lại
        public void reset()
        {
            timer1.Enabled = false;
            MessageBox.Show("Điểm: " + score.ToString(), "GAME OVER");
            timer1.Interval = 150;  // đưa tốc độ về lúc ban đầu
            score = 0;  // đưa điểm về lại bằng 0
            toolStripStatusLabelScore.Text = "0";
            newgame.Text = "PLAY AGAIN";
            panel1.Show();
            newgame.Show();
            High.Show();
            Exit_btn.Show();
            btn_About.Show();
            lbSnake.Show();
            level1.Hide();
            level2.Hide();
            snake = new Snake.Snake();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            FrmAbout FrmAbout = new FrmAbout();
            FrmAbout.ShowDialog();
            AddOwnedForm(FrmAbout);
        }

        



        // Ghi số điểm đạt được của rắn ra file
        void diemcao()
        {
            String filepath = @"C:\Users\Huy Tran\Downloads\Snake\Snake\diemcaosnake.txt";// đường dẫn của file muốn tạo      
            StreamWriter sWriter = new StreamWriter(filepath, true);
            sWriter.WriteLine(score.ToString());
            // Ghi và đóng file
            sWriter.Flush();
            sWriter.Close();
        }

        // xử lí điểm cao của rắn
        private void High_Click(object sender, EventArgs e)
        {
            String filepath = @"C:\Users\Huy Tran\Downloads\Snake\Snake\diemcaosnake.txt";
            string[] lines; // đọc dữ liệu từ file
            string[] diem = new string[100];    // lưu dữ liệu file vào mảng diem[]
            int c = 0;


            if (System.IO.File.Exists(filepath))
            {
                lines = System.IO.File.ReadAllLines(filepath);
                for (int i = 0; i < lines.Length; i++)
                {
                    diem[c] = lines[i];
                    c++;
                }
            }

            // sắp xếp điểm đó
            string tmp;
            for (int i = 0; i < c; i++)
            {
                for (int j = i + 1; j < c; j++)
                {
                    if (Convert.ToInt32(diem[i]) < Convert.ToInt32(diem[j]))
                    {
                        //cach trao doi gia tri
                        tmp = diem[i];
                        diem[i] = diem[j];
                        diem[j] = tmp;
                    }
                }
            }
            MessageBox.Show("1st: "+diem[0]+"\n"+"2nd: "+diem[1],"High Score");
        }


        // exit button
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

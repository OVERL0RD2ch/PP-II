using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Snake()
        {
            sign = 'o';
            color = ConsoleColor.Yellow;
            body = new List<Point>();

            body.Add(new Point(12, 10));
            body.Add(new Point(11, 10));
            body.Add(new Point(10, 10));
        }

        public void Move(int dx, int dy)
        {
            Point lastPoint = body[body.Count - 1];
            Console.SetCursorPosition(lastPoint.x, lastPoint.y);
            Console.Write(' ');
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;
            Snakeu();                        
            CollisionWithWall();
            //break;
            if (CanEat())
            {
                Game.food.SetRandomPosition();
            }
        }

        public void Snakeu()
        {
            for (int i = 1; i<Game.snake.body.Count; i++)
            {
                if (Game.snake.body[0].x == Game.snake.body[i].x && Game.snake.body[0].y == Game.snake.body[i].y)
                    Game.GameOver = true;                
            }
        }
        public void CollisionWithWall()
        {
            if (body[0].x < 0)
                body[0].x = 69;
            if (body[0].x > 69)
                body[0].x = 0;
            if (body[0].y < 0)
                body[0].y = 19;
            if (body[0].y > 19)
                body[0].y = 0;
        }

        public bool CanEat()
        {
            if (Game.food.location.x == body[0].x && Game.food.location.y == body[0].y)
            {
                
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y)); 
                return true;
            }
            return false;
        }

        public void Draw()
        {
            int i = 0;
            foreach (Point p in body)
            {
                if (i == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                i++;
            }
        }
    }
}
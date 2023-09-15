using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirFighter
{
    public class DrawningAirFighter
    {
        /// <summary>
        /// Класс-сущность
        /// </summary>
        public EntityAirFighter? EntityAirFighter { get; private set; }
        /// <summary>
        /// Ширина окна
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна
        /// </summary>
        private int _pictureHeight;
        /// <summary>

        /// Левая координата прорисовки автомобиля
        /// </summary>
        private int _startPosX;
        /// <summary>
        /// Верхняя кооридната прорисовки автомобиля
        /// </summary>
        private int _startPosY;
        /// <summary>
        /// Ширина прорисовки автомобиля
        /// </summary>
        private readonly int _airfighterWidth = 174;
        /// <summary>
        /// Высота прорисовки автомобиля
        /// </summary>
        private readonly int _airfighterHeight = 140;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="additionalColor">Дополнительный цвет</param>
        /// <param name="racket">Признак наличия обвеса</param>
        /// <param name="wing">Признак наличия антикрыла</param>

        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        /// <returns>true - объект создан, false - проверка не пройдена,
        public bool Init(int speed, double weight, Color bodyColor, Color
        additionalColor, bool racket, bool wing, int width, int height)
        {
            // TODO: Продумать проверки
            _pictureWidth = width;
            _pictureHeight = height;
            EntityAirFighter = new EntityAirFighter();
            EntityAirFighter.Init(speed, weight, bodyColor, additionalColor,
            racket, wing);
            return true;
        }
        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        public void SetPosition(int x, int y)
        {
            // TODO: Изменение x, y
            _startPosX = x;
            _startPosY = y;
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(DirectionType direction)
        {
            if (EntityAirFighter == null)

            {
                return;
            }
            switch (direction)
            {
                //влево
                case DirectionType.Left:
                    if (_startPosX - EntityAirFighter.Step > 0)
                    {
                        _startPosX -= (int)EntityAirFighter.Step;
                    }
                    break;
                //вверх
                case DirectionType.Up:
                    if (_startPosY - 64 - EntityAirFighter.Step > 0)
                    {
                        _startPosY -= (int)EntityAirFighter.Step;
                    }
                    break;
                // вправо
                case DirectionType.Right:
                    if (_startPosX + EntityAirFighter.Step + _airfighterWidth < 900)
                    {
                        _startPosX += (int)EntityAirFighter.Step;
                    }
                    break;
                //вниз
                case DirectionType.Down:
                    if (_startPosY + EntityAirFighter.Step + _airfighterHeight < 500)
                    {
                        _startPosY += (int)EntityAirFighter.Step;
                    }
                    break;

            }
        }
        /// <summary>
        /// Прорисовка объекта
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            if (EntityAirFighter == null)
            {
                return;
            }
            Pen pen = new(Color.Black);
            Brush additionalBrush = new
            SolidBrush(EntityAirFighter.AdditionalColor);
            // ракеты
            if (EntityAirFighter.Racket)
            {
                
                 Brush brGrey = new SolidBrush(Color.LightGray);
                g.FillRectangle(brGrey, _startPosX + 70, _startPosY -15, 10, 10);
               g.DrawRectangle(pen, _startPosX + 70, _startPosY -15, 10, 10);
                Point[] noseracketPoints =
            {
                new Point(_startPosX + 70, _startPosY -5),
                new Point(_startPosX + 70, _startPosY - 15),
                new Point(_startPosX + 60,_startPosY -10)
            };
            Brush brRed = new SolidBrush(Color.Red);
             g.FillPolygon(brRed, noseracketPoints);
            g.DrawPolygon(pen, noseracketPoints);
                  
                 g.FillRectangle(brGrey, _startPosX + 70, _startPosY -40, 10, 10);
               g.DrawRectangle(pen, _startPosX + 70, _startPosY -40, 10, 10);
                Point[] noseracketPoints2 =
            {
                new Point(_startPosX + 70, _startPosY -30),
                new Point(_startPosX + 70, _startPosY - 40),
                new Point(_startPosX + 60,_startPosY -35)
            };

             g.FillPolygon(brRed, noseracketPoints2);
            g.DrawPolygon(pen, noseracketPoints2);
                g.FillPolygon(brRed, noseracketPoints);
            g.DrawPolygon(pen, noseracketPoints);
                  
                 g.FillRectangle(brGrey, _startPosX + 70, _startPosY + 59, 10, 10);
               g.DrawRectangle(pen, _startPosX + 70, _startPosY +59, 10, 10);
                Point[] noseracketPoints3 =
            {
                new Point(_startPosX + 70, _startPosY +59),
                new Point(_startPosX + 70, _startPosY + 69),
                new Point(_startPosX + 60,_startPosY + 64)
            };

             g.FillPolygon(brRed, noseracketPoints3);
            g.DrawPolygon(pen, noseracketPoints3);


                  g.FillRectangle(brGrey, _startPosX + 70, _startPosY + 34, 10, 10);
               g.DrawRectangle(pen, _startPosX + 70, _startPosY +34, 10, 10);
                Point[] noseracketPoints4 =
            {
                new Point(_startPosX + 70, _startPosY +34),
                new Point(_startPosX + 70, _startPosY + 44),
                new Point(_startPosX + 60,_startPosY + 39)
            };

             g.FillPolygon(brRed, noseracketPoints4);
            g.DrawPolygon(pen, noseracketPoints4);

            }




            Point[] nosePoints =
            {
                new Point(_startPosX + 20, _startPosY + 4),
                new Point(_startPosX + 20, _startPosY + 24),
                new Point(_startPosX,_startPosY + 13)
            };
            Brush brBlack = new SolidBrush(Color.Black);
             g.FillPolygon(brBlack, nosePoints);
            g.DrawPolygon(pen, nosePoints);
           
            Point[] rightwingPoints =
          {
                new Point(_startPosX + 80, _startPosY + 4),
                new Point(_startPosX+80,_startPosY - 64),
                new Point(_startPosX+85,_startPosY - 64),
                new Point(_startPosX + 100, _startPosY + 4)



            };
              g.FillPolygon(additionalBrush, rightwingPoints);
            g.DrawPolygon(pen, rightwingPoints);
          
            Point[] lefttwingPoints =
           {
                new Point(_startPosX + 80, _startPosY + 24),
                new Point(_startPosX + 100, _startPosY + 24),
                 new Point(_startPosX+85,_startPosY + 94),
                new Point(_startPosX+80,_startPosY + 94)

            };
                    g.FillPolygon(additionalBrush, lefttwingPoints);
            g.DrawPolygon(pen, lefttwingPoints);
    

            Point[] leftenginePoints =
            {
                new Point(_startPosX + 140, _startPosY + 24),
                new Point(_startPosX + 160, _startPosY + 24),
                new Point(_startPosX+160,_startPosY + 50),
                new Point(_startPosX+140,_startPosY + 32)




            };
             g.FillPolygon(additionalBrush, leftenginePoints);
            g.DrawPolygon(pen, leftenginePoints);
           


            Point[] rightenginePoints =
           {
                new Point(_startPosX + 140, _startPosY + 24),
                new Point(_startPosX + 160, _startPosY + 24),
                new Point(_startPosX+160,_startPosY - 16),
                new Point(_startPosX+140,_startPosY -4)




            };
             g.FillPolygon(additionalBrush, rightenginePoints);
            g.DrawPolygon(pen, rightenginePoints);
           
             g.FillRectangle(additionalBrush, _startPosX + 20, _startPosY + 4, 140, 20);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 4, 140, 20);
           



            // крыло
            if (EntityAirFighter.Wing)
            {
                Point[] doprightwingPoints =
           {
                new Point(_startPosX + 30, _startPosY + 4),
                new Point(_startPosX+30,_startPosY - 34),
                new Point(_startPosX+35,_startPosY - 34),
                new Point(_startPosX + 45, _startPosY + 4)



            };
                  g.FillPolygon(additionalBrush, doprightwingPoints);
                g.DrawPolygon(pen, doprightwingPoints);
              
                Point[] doplefttwingPoints =
         {
                new Point(_startPosX + 30, _startPosY + 24),
                new Point(_startPosX + 30, _startPosY + 59),
                 new Point(_startPosX+35,_startPosY + 59),
                new Point(_startPosX+45,_startPosY + 24)

            };
                  g.FillPolygon(additionalBrush, doplefttwingPoints);
                g.DrawPolygon(pen, doplefttwingPoints);
              

            }
        }
    }
}



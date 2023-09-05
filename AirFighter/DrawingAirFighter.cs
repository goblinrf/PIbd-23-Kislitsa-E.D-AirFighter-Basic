using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFighter
{
    public class DrawingAirFighter
    {
        /// <summary>
        /// Класс-сущность
        /// </summary>
        public EntitySportCar? EntityAirFighter { get; private set; }
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
        private readonly int _carWidth = 110;
        /// <summary>
        /// Высота прорисовки автомобиля
        /// </summary>
        private readonly int _carHeight = 60;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="additionalColor">Дополнительный цвет</param>
        /// <param name="bodyKit">Признак наличия обвеса</param>
        /// <param name="wing">Признак наличия антикрыла</param>
        /// <param name="sportLine">Признак наличия гоночной полосы</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        /// <returns>true - объект создан, false - проверка не пройдена,
public bool Init(int speed, double weight, Color bodyColor, Color
additionalColor, bool bodyKit, bool wing, bool sportLine, int width, int height)
        {
            // TODO: Продумать проверки
            _pictureWidth = width;
            _pictureHeight = height;
            EntityAirFighter = new EntitySportCar();
            EntityAirFighter.Init(speed, weight, bodyColor, additionalColor,
            bodyKit, wing, sportLine);
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
                    if (_startPosY - EntityAirFighter.Step > 0)
                    {
                        _startPosY -= (int)EntityAirFighter.Step;
                    }
                    break;
                // вправо
                case DirectionType.Right:
                    // TODO: Продумать логику
                    break;
                //вниз
                case DirectionType.Down:
                    // TODO: Продумать логику
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
            // обвесы
            if (EntityAirFighter.BodyKit)
            {
                g.DrawEllipse(pen, _startPosX + 90, _startPosY, 20, 20);
                g.DrawEllipse(pen, _startPosX + 90, _startPosY + 40, 20,
                20);
                g.DrawRectangle(pen, _startPosX + 90, _startPosY + 10,
                20, 40);
                g.DrawRectangle(pen, _startPosX + 90, _startPosY, 15,
                15);
                g.DrawRectangle(pen, _startPosX + 90, _startPosY + 45,
                15, 15);
                g.FillEllipse(additionalBrush, _startPosX + 90,
                _startPosY, 20, 20);
                g.FillEllipse(additionalBrush, _startPosX + 90,
                _startPosY + 40, 20, 20);
                g.FillRectangle(additionalBrush, _startPosX + 90,
                _startPosY + 10, 20, 40);
                
            g.FillRectangle(additionalBrush, _startPosX + 90,
            _startPosY + 1, 15, 15);
                g.FillRectangle(additionalBrush, _startPosX + 90,
                _startPosY + 45, 15, 15);
                g.DrawEllipse(pen, _startPosX, _startPosY, 20, 20);
                g.DrawEllipse(pen, _startPosX, _startPosY + 40, 20, 20);
                g.DrawRectangle(pen, _startPosX, _startPosY + 10, 20,
                40);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY, 14,
                15);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 45,
                14, 15);
                g.FillEllipse(additionalBrush, _startPosX, _startPosY,
                20, 20);
                g.FillEllipse(additionalBrush, _startPosX, _startPosY +
                40, 20, 20);
                g.FillRectangle(additionalBrush, _startPosX + 1,
                _startPosY + 10, 25, 40);
                g.FillRectangle(additionalBrush, _startPosX + 5,
                _startPosY + 1, 15, 15);
                g.FillRectangle(additionalBrush, _startPosX + 5,
                _startPosY + 45, 15, 15);
                g.DrawRectangle(pen, _startPosX + 35, _startPosY, 39,
                15);
                g.DrawRectangle(pen, _startPosX + 35, _startPosY + 45,
                39, 15);
                g.FillRectangle(additionalBrush, _startPosX + 35,
                _startPosY + 1, 40, 15);
                g.FillRectangle(additionalBrush, _startPosX + 35,
                _startPosY + 45, 40, 15);
            }
            //границы автомобиля
            g.DrawEllipse(pen, _startPosX + 10, _startPosY + 5, 20, 20);
            g.DrawEllipse(pen, _startPosX + 10, _startPosY + 35, 20, 20);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY + 5, 20, 20);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY + 35, 20, 20);
            g.DrawRectangle(pen, _startPosX + 9, _startPosY + 15, 10, 30);
            g.DrawRectangle(pen, _startPosX + 90, _startPosY + 15, 10,
            30);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 4, 70, 52);
            //задние фары
            Brush brRed = new SolidBrush(Color.Red);
            g.FillEllipse(brRed, _startPosX + 10, _startPosY + 5, 20, 20);
            g.FillEllipse(brRed, _startPosX + 10, _startPosY + 35, 20,
            20);
            //передние фары
            Brush brYellow = new SolidBrush(Color.Yellow);
            g.FillEllipse(brYellow, _startPosX + 80, _startPosY + 5, 20,
            20);
            g.FillEllipse(brYellow, _startPosX + 80, _startPosY + 35, 20,
            20);
            //кузов
            Brush br = new SolidBrush(EntityAirFighter.BodyColor);
            g.FillRectangle(br, _startPosX + 10, _startPosY + 15, 10, 30);
            g.FillRectangle(br, _startPosX + 90, _startPosY + 15, 10, 30);
            g.FillRectangle(br, _startPosX + 20, _startPosY + 5, 70, 50);
            
        //стекла
Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 70, _startPosY + 10, 5,
            40);
            g.FillRectangle(brBlue, _startPosX + 30, _startPosY + 10, 5,
            40);
            g.FillRectangle(brBlue, _startPosX + 35, _startPosY + 8, 35,
            2);
            g.FillRectangle(brBlue, _startPosX + 35, _startPosY + 51, 35,
            2);
            //выделяем рамкой крышу
            g.DrawRectangle(pen, _startPosX + 35, _startPosY + 10, 35,
            40);
            g.DrawRectangle(pen, _startPosX + 75, _startPosY + 15, 25,
            30);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 15, 15,
            30);
            // спортивная линия
            if (EntityAirFighter.SportLine)
            {
                g.FillRectangle(additionalBrush, _startPosX + 75,
                _startPosY + 23, 25, 15);
                g.FillRectangle(additionalBrush, _startPosX + 35,
                _startPosY + 23, 35, 15);
                g.FillRectangle(additionalBrush, _startPosX + 10,
                _startPosY + 23, 20, 15);
            }
            // крыло
            if (EntityAirFighter.Wing)
            {
                g.FillRectangle(additionalBrush, _startPosX, _startPosY
                + 5, 10, 50);
                g.DrawRectangle(pen, _startPosX, _startPosY + 5, 10,
                50);
            }
        }
    }
}



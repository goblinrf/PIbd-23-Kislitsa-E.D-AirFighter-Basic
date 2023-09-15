using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAirFighter
{
    public partial class FormAirFighter : Form
    {

        private DrawningAirFighter? _drawningAirFighter;
        public FormAirFighter()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            if (_drawningAirFighter == null)
            {
                return;
            }
            Bitmap bmp = new(pictureBoxAirFighter.Width,
            pictureBoxAirFighter.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawningAirFighter.DrawTransport(gr);
            pictureBoxAirFighter.Image = bmp;
        }

        private void ButtonCreateAirFighter_Click(object sender, EventArgs e)
        {
            Random random = new();
            _drawningAirFighter = new DrawningAirFighter();
            _drawningAirFighter.Init(random.Next(100, 300),
            random.Next(1000, 3000),
            Color.FromArgb(random.Next(0, 256), random.Next(0, 256),
            random.Next(0, 256)),
            Color.FromArgb(random.Next(0, 256), random.Next(0, 256),
            random.Next(0, 256)),
            Convert.ToBoolean(random.Next(0, 2)),
             Convert.ToBoolean(random.Next(0, 2)),

            pictureBoxAirFighter.Width, pictureBoxAirFighter.Height);
            _drawningAirFighter.SetPosition(random.Next(10, 100),
            random.Next(70, 100));
            Draw();
        }

    
    private void buttonMove_Click(object sender, EventArgs e)
    {
        if (_drawningAirFighter == null)
        {
            return;
        }
        string name = ((Button)sender)?.Name ?? string.Empty;
        switch (name)
        {
            case "buttonUp":
                _drawningAirFighter.MoveTransport(DirectionType.Up);
                break;
            case "buttonDown":
                _drawningAirFighter.MoveTransport(DirectionType.Down);
                break;
            case "buttonLeft":
                _drawningAirFighter.MoveTransport(DirectionType.Left);
                break;
            case "buttonRight":
                _drawningAirFighter.MoveTransport(DirectionType.Right);
                break;
        }
        Draw();
    }
   }

}
  


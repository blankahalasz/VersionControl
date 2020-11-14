using gyak_8_gwsb1a.Abstractions;
using gyak_8_gwsb1a.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak_8_gwsb1a
{
    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy>();

        private BallFactory _factory;
        public BallFactory IToyFactory
        {
            get { return _factory; }
            set { _factory = value; }
        }


        public Form1()
        {
            InitializeComponent();
            IToyFactory = new BallFactory();
            
        }

        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var toy = IToyFactory.CreateNew();
            _toys.Add(toy);
            Left = -toy.Width;
            mainpanel.Controls.Add(toy);
        }

        private void ConveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                {
                    maxPosition = toy.Left;
                }
            }

            if (maxPosition > 1000)
            {
                var oldestBall = _toys[0];
                mainpanel.Controls.Remove(oldestBall);
                _toys.Remove(oldestBall);
            }
        }
    }
}

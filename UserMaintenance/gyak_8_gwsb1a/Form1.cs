﻿using gyak_8_gwsb1a.Abstractions;
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

        private Toy _nextToy;
        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set
            {
                _factory = value;
                DisplayNext();
            }
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
            
        }

        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
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

        private void ButtonCar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void ButtonBall_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }

        private void ButtonSzinvalaszto_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = colorPicker.Color;
        }
    }
}

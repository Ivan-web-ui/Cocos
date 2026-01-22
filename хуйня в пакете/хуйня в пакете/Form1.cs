using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace хуйня_в_пакете
{
    public partial class Form1 : Form
    {
        private Player _player;
        public Form1()

        {
            InitializeComponent();

            Location iocation = new Location(1, "домой","это твой дом." );
            location.ID = 1;
            location.Name = "Домой";
            location.Description = "Это твой дом.";
            _player = new Player(20,20,10,0,1);
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblBags.Text = _player.Bags.ToString();
            lblfoodWaseaten.Text = _player.FoodWaseaten.ToString();
            lblLevel.Text = _player.Level.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

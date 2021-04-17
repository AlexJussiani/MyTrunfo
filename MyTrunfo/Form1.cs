using MyTrunfo.Enums;
using MyTrunfo.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyTrunfo
{
    public partial class Form1 : Form
    {
        #region properties
        public List<Car> AllCards { get; set; }
        public List<Car> Player1Cards { get; set; }
        public List<Car> Player2Cards { get; set; }
        public List<Car> TiedCards { get; set; }
        public Boolean Player1IsVisible { get; set; }
        public Boolean Player2IsVisible { get; set; }
        public EPlayer CurrentWinner { get; set; }
        public EPlayer LastWinner { get; set; }
        #endregion

        #region constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region private methods
        private void StartEvironment()
        {
            TiedCards = new List<Car>();
            Player1IsVisible = true;
            Player2IsVisible = true;
        }
        #endregion

        #region events
        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_NameApp_Click(object sender, EventArgs e)
        {

        }

        private void pnl_player_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void lblCountCardsPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion


    }
}

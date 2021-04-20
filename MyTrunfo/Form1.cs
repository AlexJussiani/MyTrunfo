using MyTrunfo.Enums;
using MyTrunfo.Model;
using MyTrunfo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Car Player1 { get; set; }
        public Car Player2 { get; set; }
        public Boolean Player1IsVisible { get; set; }
        public Boolean Player2IsVisible { get; set; }
        public EPlayer CurrentWinner { get; set; }
        public EPlayer LastWinner { get; set; }
        #endregion

        #region constructor
        public Form1()
        {
            InitializeComponent();
            StartEvironment();
        }
        #endregion

        #region private methods
        private void StartEvironment()
        {
            TiedCards = new List<Car>();
            Player1IsVisible = true;
            Player2IsVisible = true;
            ResetPlayer(EPlayer.Player1);
            ResetPlayer(EPlayer.Player2);
            CreateCards();
            DistribuiteCards();
        }

        //Esse metodo verifica o vencedor
        private void Compare(ECategory eCategory, EPlayer player)
        {
            var winner = type(eCategory, player);
            MessageBox.Show("Próxima Rodada!");
            if (winner == EPlayer.Player1)
            {
                Player1Cards.Add(Player2);
                Player2Cards.Remove(Player2);
            }
            if (winner == EPlayer.Player2)
            {
                Player2Cards.Add(Player1);
                Player1Cards.Remove(Player1);
            }
            UpdateCars();
            InitializeGame();
        }

        private void UpdateCars()
        {
            //Player 1
            picThumb1Player1.Visible = Player1Cards.Count >= 1;
            picThumb2Player1.Visible = Player1Cards.Count >= 2;
            picThumb3Player1.Visible = Player1Cards.Count >= 3;
            picThumb4Player1.Visible = Player1Cards.Count >= 4;
            picThumb5Player1.Visible = Player1Cards.Count >= 5;
            picThumb6Player1.Visible = Player1Cards.Count >= 6;
            picThumb7Player1.Visible = Player1Cards.Count >= 7;
            picThumb8Player1.Visible = Player1Cards.Count >= 8;
            picThumb9Player1.Visible = Player1Cards.Count >= 9;
            picThumb10Player1.Visible = Player1Cards.Count >= 10;
            picThumb11Player1.Visible = Player1Cards.Count >= 11;
            picThumb12Player1.Visible = Player1Cards.Count >= 12;
            picThumb13Player1.Visible = Player1Cards.Count >= 13;
            picThumb14Player1.Visible = Player1Cards.Count >= 14;
            picThumb15Player1.Visible = Player1Cards.Count >= 15;
            picThumb16Player1.Visible = Player1Cards.Count >= 16;
            picThumb17Player1.Visible = Player1Cards.Count >= 17;
            picThumb18Player1.Visible = Player1Cards.Count >= 18;
            picThumb19Player1.Visible = Player1Cards.Count >= 19;
            picThumb20Player1.Visible = Player1Cards.Count >= 20;
            picThumb21Player1.Visible = Player1Cards.Count >= 21;
            picThumb22Player1.Visible = Player1Cards.Count >= 22;
            picThumb23Player1.Visible = Player1Cards.Count >= 23;
            picThumb24Player1.Visible = Player1Cards.Count >= 24;
            picThumb25Player1.Visible = Player1Cards.Count >= 25;
            picThumb26Player1.Visible = Player1Cards.Count >= 26;
            picThumb27Player1.Visible = Player1Cards.Count >= 27;
            picThumb28Player1.Visible = Player1Cards.Count >= 28;
            picThumb29Player1.Visible = Player1Cards.Count >= 29;
            picThumb30Player1.Visible = Player1Cards.Count >= 30;
            picThumb31Player1.Visible = Player1Cards.Count >= 31;
            picThumb32Player1.Visible = Player1Cards.Count >= 32;
            picThumb33Player1.Visible = Player1Cards.Count >= 33;
            picThumb34Player1.Visible = Player1Cards.Count >= 34;
            picThumb35Player1.Visible = Player1Cards.Count >= 35;
            picThumb36Player1.Visible = Player1Cards.Count >= 36;
            picThumb37Player1.Visible = Player1Cards.Count >= 37;
            picThumb38Player1.Visible = Player1Cards.Count >= 38;
            picThumb39Player1.Visible = Player1Cards.Count >= 39;
            picThumb40Player1.Visible = Player1Cards.Count >= 40;

            //Player 2
            picThumb1Player2.Visible = Player2Cards.Count >= 1;
            picThumb2Player2.Visible = Player2Cards.Count >= 2;
            picThumb3Player2.Visible = Player2Cards.Count >= 3;
            picThumb4Player2.Visible = Player2Cards.Count >= 4;
            picThumb5Player2.Visible = Player2Cards.Count >= 5;
            picThumb6Player2.Visible = Player2Cards.Count >= 6;
            picThumb7Player2.Visible = Player2Cards.Count >= 7;
            picThumb8Player2.Visible = Player2Cards.Count >= 8;
            picThumb9Player2.Visible = Player2Cards.Count >= 9;
            picThumb10Player2.Visible = Player2Cards.Count >= 10;
            picThumb11Player2.Visible = Player2Cards.Count >= 11;
            picThumb12Player2.Visible = Player2Cards.Count >= 12;
            picThumb13Player2.Visible = Player2Cards.Count >= 13;
            picThumb14Player2.Visible = Player2Cards.Count >= 14;
            picThumb15Player2.Visible = Player2Cards.Count >= 15;
            picThumb16Player2.Visible = Player2Cards.Count >= 16;
            picThumb17Player2.Visible = Player2Cards.Count >= 17;
            picThumb18Player2.Visible = Player2Cards.Count >= 18;
            picThumb19Player2.Visible = Player2Cards.Count >= 19;
            picThumb20Player2.Visible = Player2Cards.Count >= 20;
            picThumb21Player2.Visible = Player2Cards.Count >= 21;
            picThumb22Player2.Visible = Player2Cards.Count >= 22;
            picThumb23Player2.Visible = Player2Cards.Count >= 23;
            picThumb24Player2.Visible = Player2Cards.Count >= 24;
            picThumb25Player2.Visible = Player2Cards.Count >= 25;
            picThumb26Player2.Visible = Player2Cards.Count >= 26;
            picThumb27Player2.Visible = Player2Cards.Count >= 27;
            picThumb28Player2.Visible = Player2Cards.Count >= 28;
            picThumb29Player2.Visible = Player2Cards.Count >= 29;
            picThumb30Player2.Visible = Player2Cards.Count >= 30;
            picThumb31Player2.Visible = Player2Cards.Count >= 31;
            picThumb32Player2.Visible = Player2Cards.Count >= 32;
            picThumb33Player2.Visible = Player2Cards.Count >= 33;
            picThumb34Player2.Visible = Player2Cards.Count >= 34;
            picThumb35Player2.Visible = Player2Cards.Count >= 35;
            picThumb36Player2.Visible = Player2Cards.Count >= 36;
            picThumb37Player2.Visible = Player2Cards.Count >= 37;
            picThumb38Player2.Visible = Player2Cards.Count >= 38;
            picThumb39Player2.Visible = Player2Cards.Count >= 39;
            picThumb40Player2.Visible = Player2Cards.Count >= 40;
        }

        //Esse metodo verifica qual a categoria selecionada e qual jogador foi o vencedor
        private EPlayer type(ECategory eCategory, EPlayer player)
        {
            Boolean player1 = false;
            if (player == EPlayer.Player1)
            {
                if (eCategory == ECategory.Consumption)
                {
                    player1 = (Player1.Consumption > Player2.Consumption);
                    lblConsumptionPlayer2Value.Text = Player2.Displacements.ToString();

                }
                if (eCategory == ECategory.Displacements)
                {
                    player1 = (Player1.Consumption > Player2.Consumption);
                    lbldisplacementsPlayer2Value.Text = Player2.Displacements.ToString();
                }
                if (eCategory == ECategory.HorsePower)
                {
                    player1 = (Player1.HorsePower > Player2.HorsePower);
                    lblPowerPlayer2Value.Text = Player2.HorsePower.ToString();
                }
                if (eCategory == ECategory.Length)
                {
                    player1 = (Player1.Length > Player2.Length);
                    lblWidthPlayer2Value.Text = Player2.Length.ToString();
                }
                if (eCategory == ECategory.MaxSpeed)
                {
                    player1 = (Player1.MaxSpeed > Player2.MaxSpeed);
                    lblSpeedPlayer2Value.Text = Player2.MaxSpeed.ToString();
                }
                if (eCategory == ECategory.Price)
                {
                    player1 = (Player1.Price < Player2.Price);
                    lblPricePlayer2Value.Text = Player2.Price.ToString();
                }
            }
            if (player1)
            {
                MessageBox.Show("Você Venceu! ");
                return EPlayer.Player1;
            }
            else
            {
                MessageBox.Show("Você Perdeu! ");
                return EPlayer.Player2;
            }
        }


        //Esse metodo aplica as cartas de cada jogador a seu card
        private void InitializeGame()
        {
            PopulatePlayer(EPlayer.Player1);
            PopulatePlayer(EPlayer.Player2);
        }

        private void PopulatePlayer(EPlayer player)
        {
            if (player == EPlayer.Player1)
            { 
                Player1 = Player1Cards.FirstOrDefault();
                picCarPlayer1.Image = Player1.Image;
                lblConsumptionPlayer1Value.Text = Player1.Consumption.ToString();
                lbCarBrandPlayer1.Text = Player1.Name;
                lblPowerPlayer1Value.Text = Player1.HorsePower.ToString();
                lblWidthPlayer1Value.Text = Player1.Length.ToString();
                lblSpeedPlayer1Value.Text = Player1.MaxSpeed.ToString();
                lbldisplacementsPlayer1Value.Text = Player1.Displacements.ToString();
                lblPricePlayer1Value.Text = Player1.Price.ToString();
            }
            else if(player == EPlayer.Player2)
            {
                Player2 = Player2Cards.FirstOrDefault();
                picCarPlayer2.Image = Player2.Image;
                lblConsumptionPlayer2Value.Text = Player2.Consumption.ToString();
                lblPowerPlayer2Value.Text = Player2.Name;
                lblWidthPlayer2Value.Text = Player2.HorsePower.ToString();
                lblSpeedPlayer2Value.Text = Player2.Length.ToString();
                lbldisplacementsPlayer2Value.Text = Player2.MaxSpeed.ToString();
                lblPricePlayer2Value.Text = Player2.Price.ToString();
            }
        }



        //Esse metodo distribui igualmente as 40 cartas aleatorimente para cada Jogador.
        private void DistribuiteCards()
        {
            Player1Cards = new List<Car>();
            Player2Cards = new List<Car>(); 
            List<Car> CopyAllCards = AllCards;
            Random random = new Random();
            int index;
            while(CopyAllCards.Count != 0)
            {
                index = random.Next(0, CopyAllCards.Count);
                if (Player1Cards.Count == Player2Cards.Count)
                    Player1Cards.Add(CopyAllCards[index]);
                else
                    Player2Cards.Add(CopyAllCards[index]);                
                CopyAllCards.RemoveAt(index);
            }
        }

        private void ResetPlayer(EPlayer player)
        {
            if (player == EPlayer.Player1)
            {
                picThumb21Player1.Visible =
                picThumb22Player1.Visible =
                picThumb23Player1.Visible =
                picThumb24Player1.Visible =
                picThumb25Player1.Visible =
                picThumb26Player1.Visible =
                picThumb27Player1.Visible =
                picThumb28Player1.Visible =
                picThumb29Player1.Visible =
                picThumb30Player1.Visible =
                picThumb31Player1.Visible =
                picThumb32Player1.Visible =
                picThumb33Player1.Visible =
                picThumb34Player1.Visible =
                picThumb35Player1.Visible =
                picThumb36Player1.Visible =
                picThumb37Player1.Visible =
                picThumb38Player1.Visible =
                picThumb39Player1.Visible =
                picThumb40Player1.Visible =
                false;
            }
            if (player == EPlayer.Player2)
            {
                picThumb21Player2.Visible =
                picThumb22Player2.Visible =
                picThumb23Player2.Visible =
                picThumb24Player2.Visible =
                picThumb25Player2.Visible =
                picThumb26Player2.Visible =
                picThumb27Player2.Visible =
                picThumb28Player2.Visible =
                picThumb29Player2.Visible =
                picThumb30Player2.Visible =
                picThumb31Player2.Visible =
                picThumb32Player2.Visible =
                picThumb33Player2.Visible =
                picThumb34Player2.Visible =
                picThumb35Player2.Visible =
                picThumb36Player2.Visible =
                picThumb37Player2.Visible =
                picThumb38Player2.Visible =
                picThumb39Player2.Visible =
                picThumb40Player2.Visible =
                false;
            }
        }

        private void CreateCards()
        {
            AllCards = new List<Car>();
            AllCards.Add(new Car() { Id = 1, Code = "C2", Name = "Alure 408", Image = Resources.Alure_408, Brand = "Peugeot", Country = ECountry.France, Consumption = 12.8m, HorsePower = 115, Length = 4159, MaxSpeed = 185, Displacements = 1600, Price = 83 });
            AllCards.Add(new Car() { Id = 2, Code = "A6", Name = "Amarok", Image = Resources.Amarok, Brand = "Volkswagen", Country = ECountry.Germany, Consumption = 8.4m, HorsePower = 180, Length = 5254, MaxSpeed = 179, Displacements = 2000, Price = 243 });
            AllCards.Add(new Car() { Id = 3, Code = "A2", Name = "Astra", Image = Resources.Astra, Brand = "Chevrolet", Country = ECountry.USA, Consumption = 10.7m, HorsePower = 128, Length = 4199, MaxSpeed = 201, Displacements = 2000, Price = 29 });
            AllCards.Add(new Car() { Id = 4, Code = "C1", Name = "Bandeirantes", Image = Resources.Bandeirantes, Brand = "Toyota", Country = ECountry.Japan, Consumption = 9m, HorsePower = 96, Length = 5300, MaxSpeed = 125, Displacements = 3661, Price = 40 });
            AllCards.Add(new Car() { Id = 5, Code = "C3", Name = "C3", Image = Resources.C3, Brand = "Citroën", Country = ECountry.France, Consumption = 16.6m, HorsePower = 90, Length = 3944, MaxSpeed = 171, Displacements = 1200, Price = 62 });
            AllCards.Add(new Car() { Id = 6, Code = "B2", Name = "Celta", Image = Resources.Celta, Brand = "Chevrolet", Country = ECountry.USA, Consumption = 12.9m, HorsePower = 78, Length = 3788, MaxSpeed = 161, Displacements = 1000, Price = 28 });
            AllCards.Add(new Car() { Id = 7, Code = "D8", Name = "Classic", Image = Resources.Classic, Brand = "Chevrolet", Country = ECountry.USA, Consumption = 13.6m, HorsePower = 78, Length = 4152, MaxSpeed = 166, Displacements = 1000, Price = 30 });
            AllCards.Add(new Car() { Id = 8, Code = "B4", Name = "Corola", Image = Resources.Corola, Brand = "Toyota", Country = ECountry.Japan, Consumption = 13.9m, HorsePower = 177, Length = 4630, MaxSpeed = 199, Displacements = 2000, Price = 123 });
            AllCards.Add(new Car() { Id = 9, Code = "D3", Name = "Corsa Joy", Image = Resources.Corsa_Joy, Brand = "Chevrolet", Country = ECountry.USA, Consumption = 10.9m, HorsePower = 78, Length = 3822, MaxSpeed = 166, Displacements = 1000, Price = 16 });
            AllCards.Add(new Car() { Id = 10, Code = "B3", Name = "Cruze", Image = Resources.Cruze, Brand = "Chevrolet", Country = ECountry.USA, Consumption = 14m, HorsePower = 153, Length = 4665, MaxSpeed = 214, Displacements = 1400, Price = 120 });
            AllCards.Add(new Car() { Id = 11, Code = "A4", Name = "Ecosport", Image = Resources.Ecosport, Brand = "Ford", Country = ECountry.USA, Consumption = 8.8m, HorsePower = 107, Length = 4240, MaxSpeed = 165, Displacements = 1598, Price = 31 });
            AllCards.Add(new Car() { Id = 12, Code = "C7", Name = "Etios", Image = Resources.Etios, Brand = "Toyota", Country = ECountry.Japan, Consumption = 9.8m, HorsePower = 107, Length = 3884, MaxSpeed = 187, Displacements = 1500, Price = 56 });
            AllCards.Add(new Car() { Id = 13, Code = "B8", Name = "Fiesta", Image = Resources.Fiesta, Brand = "Ford", Country = ECountry.USA, Consumption = 12m, HorsePower = 73, Length = 3930, MaxSpeed = 146, Displacements = 1000, Price = 19 });
            AllCards.Add(new Car() { Id = 14, Code = "A1", Name = "Fox Trend", Image = Resources.Fox_Trend, Brand = "Volkswagen", Country = ECountry.Germany, Consumption = 12.2m, HorsePower = 76, Length = 3823, MaxSpeed = 132, Displacements = 1000, Price = 54 });
            AllCards.Add(new Car() { Id = 15, Code = "A8", Name = "Fusion", Image = Resources.Fusion, Brand = "Ford", Country = ECountry.USA, Consumption = 11.7m, HorsePower = 248, Length = 4871, MaxSpeed = 195, Displacements = 2000, Price = 150 });
            AllCards.Add(new Car() { Id = 16, Code = "B5", Name = "Gol G1", Image = Resources.Gol_G1, Brand = "Volkswagen", Country = ECountry.Germany, Consumption = 7.5m, HorsePower = 96, Length = 3810, MaxSpeed = 170, Displacements = 1781, Price = 8 });
            AllCards.Add(new Car() { Id = 17, Code = "B1", Name = "Gol G4", Image = Resources.Gol_G4, Brand = "Volkswagen", Country = ECountry.Germany, Consumption = 10.8m, HorsePower = 71, Length = 3931, MaxSpeed = 168, Displacements = 1000, Price = 16 });
            AllCards.Add(new Car() { Id = 18, Code = "A3", Name = "Hilux", Image = Resources.Hilux, Brand = "Toyota", Country = ECountry.Japan, Consumption = 9m, HorsePower = 163, Length = 5325, MaxSpeed = 180, Displacements = 2700, Price = 145 });
            AllCards.Add(new Car() { Id = 19, Code = "D5", Name = "Ka", Image = Resources.Ka, Brand = "Ford", Country = ECountry.USA, Consumption = 9.6m, HorsePower = 73, Length = 3836, MaxSpeed = 160, Displacements = 1000, Price = 15 });
            AllCards.Add(new Car() { Id = 20, Code = "A0", Name = "Kombi", Image = Resources.Kombi, Brand = "Volkswagen", Country = ECountry.Germany, Consumption = 8.4m, HorsePower = 80, Length = 4505, MaxSpeed = 130, Displacements = 1390, Price = 27 });
            AllCards.Add(new Car() { Id = 21, Code = "D2", Name = "L200", Image = Resources.L200, Brand = "Mitsubishi", Country = ECountry.Japan, Consumption = 13.2m, HorsePower = 190, Length = 5280, MaxSpeed = 179, Displacements = 2400, Price = 172 });
            AllCards.Add(new Car() { Id = 22, Code = "B9", Name = "Logan", Image = Resources.Logan, Brand = "Renault", Country = ECountry.France, Consumption = 10.2m, HorsePower = 82, Length = 4349, MaxSpeed = 164, Displacements = 1000, Price = 63 });
            AllCards.Add(new Car() { Id = 23, Code = "B6", Name = "Master", Image = Resources.Master, Brand = "Renault", Country = ECountry.France, Consumption = 8.1m, HorsePower = 130, Length = 5642, MaxSpeed = 145, Displacements = 2300, Price = 173 });
            AllCards.Add(new Car() { Id = 24, Code = "A9", Name = "Montana", Image = Resources.Montana, Brand = "Chevrolet", Country = ECountry.USA, Consumption = 12.1m, HorsePower = 99, Length = 4514, MaxSpeed = 170, Displacements = 1400, Price = 75 });
            AllCards.Add(new Car() { Id = 25, Code = "A7", Name = "Omega GLS", Image = Resources.Omega_GLS, Brand = "Chevrolet", Country = ECountry.USA, Consumption = 7.5m, HorsePower = 116, Length = 4738, MaxSpeed = 189, Displacements = 2000, Price = 8 });
            AllCards.Add(new Car() { Id = 26, Code = "C4", Name = "Palio Weekend", Image = Resources.Palio_Weekend, Brand = "Fiat", Country = ECountry.Italy, Consumption = 11.1m, HorsePower = 132, Length = 4310, MaxSpeed = 184, Displacements = 1700, Price = 65 });
            AllCards.Add(new Car() { Id = 27, Code = "D6", Name = "Polo", Image = Resources.Polo, Brand = "Volkswagen", Country = ECountry.Germany, Consumption = 13.9m, HorsePower = 128, Length = 4053, MaxSpeed = 192, Displacements = 1000, Price = 58 });
            AllCards.Add(new Car() { Id = 28, Code = "D9", Name = "Ranger 3.0", Image = Resources.Ranger_3_0, Brand = "Ford", Country = ECountry.USA, Consumption = 10.4m, HorsePower = 163, Length = 5143, MaxSpeed = 170, Displacements = 3000, Price = 167 });
            AllCards.Add(new Car() { Id = 29, Code = "D1", Name = "Renegade", Image = Resources.Renegade, Brand = "Jeep", Country = ECountry.USA, Consumption = 12.2m, HorsePower = 139, Length = 4232, MaxSpeed = 182, Displacements = 1700, Price = 70 });
            AllCards.Add(new Car() { Id = 30, Code = "A5", Name = "S10", Image = Resources.S10, Brand = "Chevrolet", Country = ECountry.USA, Consumption = 8.2m, HorsePower = 206, Length = 5347, MaxSpeed = 163, Displacements = 2500, Price = 68 });
            AllCards.Add(new Car() { Id = 31, Code = "B7", Name = "Saveiro Surf", Image = Resources.Saveiro_Surf, Brand = "Volkswagen", Country = ECountry.Germany, Consumption = 11.3m, HorsePower = 99, Length = 4451, MaxSpeed = 165, Displacements = 1600, Price = 26 });
            AllCards.Add(new Car() { Id = 32, Code = "B0", Name = "Serie 4 428", Image = Resources.Serie_4_428, Brand = "BMW", Country = ECountry.Germany, Consumption = 12.1m, HorsePower = 245, Length = 4638, MaxSpeed = 250, Displacements = 2000, Price = 311 });
            AllCards.Add(new Car() { Id = 33, Code = "C9", Name = "Siena", Image = Resources.Siena, Brand = "Fiat", Country = ECountry.Italy, Consumption = 13.2m, HorsePower = 86, Length = 4115, MaxSpeed = 167, Displacements = 1400, Price = 31 });
            AllCards.Add(new Car() { Id = 34, Code = "D0", Name = "Spacefox", Image = Resources.Spacefox, Brand = "Volkswagen", Country = ECountry.Germany, Consumption = 9.4m, HorsePower = 104, Length = 4204, MaxSpeed = 177, Displacements = 1600, Price = 41 });
            AllCards.Add(new Car() { Id = 35, Code = "C6", Name = "Tiguan", Image = Resources.Tiguan, Brand = "Volkswagen", Country = ECountry.Germany, Consumption = 9.6m, HorsePower = 220, Length = 4705, MaxSpeed = 223, Displacements = 2000, Price = 225 });
            AllCards.Add(new Car() { Id = 36, Code = "D7", Name = "Toro", Image = Resources.Toro, Brand = "Fiat", Country = ECountry.Italy, Consumption = 11.2m, HorsePower = 139, Length = 4915, MaxSpeed = 181, Displacements = 1700, Price = 100 });
            AllCards.Add(new Car() { Id = 37, Code = "C8", Name = "Tucson", Image = Resources.Tucson, Brand = "Hyundai", Country = ECountry.SouthCorea, Consumption = 15.1m, HorsePower = 143, Length = 4325, MaxSpeed = 180, Displacements = 2000, Price = 155 });
            AllCards.Add(new Car() { Id = 38, Code = "C0", Name = "Uno", Image = Resources.Uno, Brand = "Fiat", Country = ECountry.Italy, Consumption = 8.5m, HorsePower = 57, Length = 3644, MaxSpeed = 151, Displacements = 1000, Price = 9 });
            AllCards.Add(new Car() { Id = 39, Code = "C5", Name = "Vectra", Image = Resources.Vectra, Brand = "Chevrolet", Country = ECountry.USA, Consumption = 8.2m, HorsePower = 123, Length = 4495, MaxSpeed = 195, Displacements = 2198, Price = 15 });
            AllCards.Add(new Car() { Id = 40, Code = "D4", Name = "Zafira", Image = Resources.Zafira, Brand = "Chevrolet", Country = ECountry.USA, Consumption = 9.4m, HorsePower = 140, Length = 4334, MaxSpeed = 181, Displacements = 2000, Price = 30 });
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
            Compare(ECategory.HorsePower, EPlayer.Player1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lbNamePlayer1.Text = txt_name.Text;
            InitializeGame();
        }

        private void lblConsumptionPlayer1_Click(object sender, EventArgs e)
        {
            Compare(ECategory.Consumption, EPlayer.Player1);
        }


        #endregion

        private void lblWidthPlayer1_Click(object sender, EventArgs e)
        {
            Compare(ECategory.Length, EPlayer.Player1);
        }

        private void lblSpeedPlayer1_Click(object sender, EventArgs e)
        {
            Compare(ECategory.MaxSpeed, EPlayer.Player1);
        }

        private void lbldisplacementsPlayer1_Click(object sender, EventArgs e)
        {
            Compare(ECategory.Displacements, EPlayer.Player1);
        }

        private void lblPricePlayer1_Click(object sender, EventArgs e)
        {
            Compare(ECategory.Price, EPlayer.Player1);
        }
    }
}

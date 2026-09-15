using System.Diagnostics.CodeAnalysis;

namespace WhileFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)

        {
            int treasure = 1;

            lstScore.Items.Clear();
            while (treasure <= 10)
            {
                lstScore.Items.Add("Treasure " + treasure + " collected!");
                treasure++;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int secret = 7;
            int guess = Convert.ToInt32(txtGuess.Text);
            while (guess != secret)
            {
                lblMessage.Text = "Wrong guess! Try again.";
                return;
            }

            lblMessage.Text = "You Win!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            int coins = 0;
            do
            {
                coins += 10;
            }
            while (coins < 100);
            lblCoins.Text = "Coins: " + coins;
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            int hp = 50;
            string result = "";
            do
            {
                hp -= 10;
                result += "Monster HP: " + hp + "\n";
            }
            while (hp > 0);
            result += "\nMonster Defeated!";
            lblResult.Text = result;
        }

        private void btnFight1_Click(object sender, EventArgs e)
        {
            string weapon = cmbWeapon.Text;

            switch (weapon)
            {
                case "Sword":
                    lblResult1.Text = "⚔️ You attacked with a Sword!";
                    break;

                case "Bow":
                    lblResult1.Text = "🏹 You attacked with a Bow!";
                    break;

                case "Magic":
                    lblResult1.Text = "✨ You cast a Magic Spell!";
                    break;

                default:
                    lblResult1.Text = "Select a weapon first!";
                    break;
            }

        }

        private void lblResult1_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            {
                int door = Convert.ToInt32(txtDoor.Text);

                switch (door)
                {
                    case 1:
                        lblResult.Text = "💰 You found treasure!";
                        break;

                    case 2:
                        lblResult.Text = "👾 A monster appeared!";
                        break;

                    case 3:
                        lblResult.Text = "🧪 You found a magic potion!";
                        break;

                    default:
                        lblResult.Text = "Choose Door 1, 2, or 3.";
                        break;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            for (int health = 0; health <= 100; health += 20)
            {
                progressBar1.Value = health;
                lblHealth.Text = "❤ Health: " + health + "%";

                Application.DoEvents();
                System.Threading.Thread.Sleep(300);
            }

            MessageBox.Show("Full Health!");
        }

        private void btnStars_Click(object sender, EventArgs e)
        {
         
            string stars = "";

            for (int i = 1; i <= 10; i++)
            {
                stars += "⭐ ";
            }

            MessageBox.Show(stars);
        }
    
    }
}

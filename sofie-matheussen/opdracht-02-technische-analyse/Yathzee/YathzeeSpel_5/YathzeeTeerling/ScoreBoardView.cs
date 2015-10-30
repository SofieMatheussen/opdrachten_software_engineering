using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YathzeeTeerling
{
    public partial class ScoreBoardView : UserControl
    {
        //member onthoud controller
        private ScoreBoardController _controller;

        // constructor 
        public ScoreBoardView(ScoreBoardController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ScoreBoardView_Load(object sender, EventArgs e)
        {
            List<TeerlingView> teerlingen = _controller.getTeerlingenView(); //Lijst met alle views
            int teerlingWidth = teerlingen[0].Width; //breedte van 1 teerling voor correct naast elkaar

           /* foreach (TeerlingView teerling in teerlingen)
            {
                TeerlingView huidigeTeerling = teerling;

                int xPos = teerlingen.IndexOf(teerling) * teerlingWidth; //x positie zetten afhankelijk van index en width
                huidigeTeerling.Location = new Point(xPos, 0);

                Controls.Add(huidigeTeerling); //huidige teerling toevoegen aan view

                huidigeTeerling.updateViewTeerling();
            }*/
            
            scoreLabel.Location = new Point(20, teerlingen[0].Height +400);
            highScoreLabel.Location = new Point(20, teerlingen[0].Height + scoreLabel.Height +400);
           
            
        }

        public void updateScores()
        {
            scoreLabel.Text = "Huidige worp: " + _controller.getModel().Score;
            highScoreLabel.Text = "Highscore: " + _controller.getModel().Highscore;
        }
    }
}

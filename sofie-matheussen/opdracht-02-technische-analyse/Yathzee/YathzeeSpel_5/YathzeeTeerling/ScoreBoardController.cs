using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzeeTeerling
{
    public class ScoreBoardController
    {
        //members die view model en controller gaan onthouden
        private ScoreBoardView _view;
        private ScoreBoardController _controller;
        private ScoreBoardModel _model;

        public ScoreBoardController() //constructor
        {
            _view = new ScoreBoardView(this);
            _model = new ScoreBoardModel();
        }

        public ScoreBoardView getView()
        {
            return _view;
        }
        public ScoreBoardModel getModel()
        {
            return _model;
        }

        //
        public List<TeerlingView> getTeerlingenView()
        {
            // Maak een lijst die de views zal opvangen
            List<TeerlingView> teerlingenView = new List<TeerlingView>();

            // Loop over het huidig aantal teerlingen uit het model
            foreach (TeerlingController teerling in getModel().Teerlingen)
            {
                // Haal de view op voor iedere teerling
                TeerlingView teerlingView = teerling.getView();

                // Voeg de teerling toe aan de lijst die de views opvangt
                teerlingenView.Add(teerlingView);
            }

            // Return de lijst met teerlingViews
            return teerlingenView;
        }


        public void changeScore()
        {
            List<TeerlingController> teerlingen = _model.Teerlingen;
            int alleOgen = 0;
            foreach (TeerlingController teerling in teerlingen)
            {
                alleOgen += teerling._model.Aantalogen;
            }
            _model.Score = alleOgen;
            if (alleOgen > _model.Highscore)
            {
                _model.Highscore = alleOgen;
            }
            _view.updateScores();
        }


    }
}

    


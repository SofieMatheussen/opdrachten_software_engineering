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
        //private ScoreBoardController _controller;
        private ScoreBoardModel _model;

        public ScoreBoardController(YahtzeeController yahtzeeController) //constructor
        {
            _view = new ScoreBoardView(this);
            _model = new ScoreBoardModel();
            _model.Teerlingen = yahtzeeController.getTeerlingenView();
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
            List<TeerlingView> teerlingenView = new List<TeerlingView>();
            // Loop over het huidig aantal teerlingen uit het model
            foreach (TeerlingView teerling in getModel().Teerlingen)
            {
                // Voeg de teerling toe aan de lijst die de views opvangt
                teerlingenView.Add(teerling);
            }
            // Return de lijst met teerlingViews
            return teerlingenView;
        }


        public void changeScore()
        {
            List<TeerlingView> teerlingen = _model.Teerlingen;
            int alleOgen = 0;
            foreach (TeerlingView teerling in teerlingen)
            {
                alleOgen += teerling.getController()._model.Aantalogen;
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

    


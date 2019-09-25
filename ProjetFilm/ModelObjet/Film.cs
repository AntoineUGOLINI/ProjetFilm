using System;
using System.Collections.Generic;

namespace ModelObjet
{
    public class Film
    {
        public int NbEntrees { get; set; }
        public string PhotoFilm { get; set; }
        public string TitreFilm { get; set; }
        // public List<Film> LesFilm { get; set; }
        public List<Acteur> LesActeurs { get; set; }
        public Realisateur LeRealisateur { get; set; }
        //public List<Film> lesFilmsComedie { get; set; }
        public void AjouterActeur(Acteur unActeur)
        {
            LesActeurs.Add(unActeur);
        }
    }
}

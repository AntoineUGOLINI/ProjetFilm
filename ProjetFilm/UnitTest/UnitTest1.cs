﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelObjet;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AjouterActeurTest()
        {
            Acteur acteur1 = new Acteur()
            {
                NomActeur = "De Niro",
                PrenomActeur = "Robert",
                PhotoActeur = "Images/De Niro.png"
            };
            Acteur acteur2 = new Acteur()
            {
                NomActeur = "Di Caprio",
                PrenomActeur = "Leonardo",
                PhotoActeur = "Images/Di Caprio.png"
            };
            Acteur acteur3 = new Acteur()
            {
                NomActeur = "Nicholson",
                PrenomActeur = "Jack",
                PhotoActeur = "Images/Nicholson.png"
            };
            Acteur acteur4 = new Acteur()
            {
                NomActeur = "Depp",
                PrenomActeur = "Johnny",
                PhotoActeur = "Images/Depp.png"
            };
            Acteur acteur5 = new Acteur()
            {
                NomActeur = "Pitt",
                PrenomActeur = "Brad",
                PhotoActeur = "Images/Pitt.png"
            };
            Acteur acteur6 = new Acteur()
            {
                NomActeur = "Portman",
                PrenomActeur = "Natalie",
                PhotoActeur = "Images/Portman.png"
            };
            Acteur acteur7 = new Acteur()
            {
                NomActeur = "Lawrence",
                PrenomActeur = "Jennifer",
                PhotoActeur = "Images/Lawrence.png"
            };
            Acteur acteur8 = new Acteur()
            {
                NomActeur = "Jolie",
                PrenomActeur = "Angelina",
                PhotoActeur = "Images/Jolie.png"
            };
            Acteur acteur9 = new Acteur()
            {
                NomActeur = "Kidman",
                PrenomActeur = "Nicole",
                PhotoActeur = "Images/Kidman.png"
            };
            Acteur acteur10 = new Acteur()
            {
                NomActeur = "Stone",
                PrenomActeur = "Emma",
                PhotoActeur = "Images/Stone.png"
            };

            Realisateur real1 = new Realisateur()
            {
                NomRealisateur = "Tarantino",
                PrenomRealisateur = "Quentin",
                PhotoRealisateur = "Images/Tarantino.png"
            };
            Realisateur real2 = new Realisateur()
            {
                NomRealisateur = "Spielberg",
                PrenomRealisateur = "Steven",
                PhotoRealisateur = "Images/Spielberg.png"
            };
            Realisateur real3 = new Realisateur()
            {
                NomRealisateur = "Scorsese",
                PrenomRealisateur = "Martin",
                PhotoRealisateur = "Images/Scorsese.png"
            };

            Film film1 = new Film()
            {
                TitreFilm = "Film n°1",
                NbEntrees = 23000,
                LeRealisateur = real1,
                LesActeurs = new List<Acteur>(),
                PhotoFilm = "Images/Film n°1.png"
            };
            Film film2 = new Film()
            {
                TitreFilm = "Film n°2",
                NbEntrees = 56000,
                LeRealisateur = real2,
                LesActeurs = new List<Acteur>(),
                PhotoFilm = "Images/Film n°2.png"
            };
            Film film3 = new Film()
            {
                TitreFilm = "Film n°3",
                NbEntrees = 21000,
                LeRealisateur = real3,
                LesActeurs = new List<Acteur>(),
                PhotoFilm = "Images/Film n°3.png"
            };

            film1.AjouterActeur(acteur1); film1.AjouterActeur(acteur2); film1.AjouterActeur(acteur3);
            film2.AjouterActeur(acteur1); film2.AjouterActeur(acteur4); film2.AjouterActeur(acteur5);
            film2.AjouterActeur(acteur6); film2.AjouterActeur(acteur7);
            film3.AjouterActeur(acteur8); film3.AjouterActeur(acteur9); film3.AjouterActeur(acteur10);
            film3.AjouterActeur(acteur3); film3.AjouterActeur(acteur5);

            List<Film> lesFilmsComedie = new List<Film>();
            lesFilmsComedie.Add(film1);
            List<Film> lesFilmsAventure = new List<Film>();
            lesFilmsAventure.Add(film2);
            List<Film> lesFilmsScienceFiction = new List<Film>();
            lesFilmsScienceFiction.Add(film3);
            dico.Add("Comédie", lesFilmsComedie);
            dico.Add("Aventure", lesFilmsAventure);
            dico.Add("Science Fiction", lesFilmsScienceFiction);



        }
    }
}

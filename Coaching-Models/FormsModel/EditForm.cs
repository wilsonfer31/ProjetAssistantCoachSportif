﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Coaching_Models
{
    public class EditForm : NamedEntity
    {
        public EditForm(){}
        [Required]
        public string Pseudo { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        public string Adresse { get; set; }
        [Required]
        public string Ville { get; set; }
        public IEnumerable<SelectListItem> Villes { get; set; }

        public EditForm(Utilisateur utilisateur, IEnumerable<SelectListItem> villes)
        {
            Id = utilisateur.Id;
            Pseudo = utilisateur.Pseudo;
            Nom = utilisateur.Nom;
            Prenom = utilisateur.Prenom;
            Tel = utilisateur.Tel;
            Mail = utilisateur.Mail;
            Adresse = utilisateur.Adresse;
            Ville = utilisateur.Ville.Id.ToString();
            Villes = villes;
        }
    }
}

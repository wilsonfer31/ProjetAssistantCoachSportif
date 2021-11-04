﻿using System.Collections.Generic;

namespace Coaching_Models
{
    public class GroupeChat : NamedEntity
    {
        public List<Utilisateur> Membres { get; set; } = new List<Utilisateur>();
        public List<Message> ChatMessages { get; set; } = new List<Message>();
    }
}

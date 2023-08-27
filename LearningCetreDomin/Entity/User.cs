﻿using LearningCetreDomin.Commons;
using LearningCetreDomin.Enums;

namespace LearningCetreDomin.Entity
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

    }
}

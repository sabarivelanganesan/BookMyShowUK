﻿using System.ComponentModel.DataAnnotations;

namespace EMovieTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //RelationShips
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
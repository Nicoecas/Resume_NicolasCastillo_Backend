﻿using System.ComponentModel.DataAnnotations;

namespace Resume_NicolasCastillo_Backend.Dtos
{
    public class WorkExperienceDto
    {
        public string Role { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}

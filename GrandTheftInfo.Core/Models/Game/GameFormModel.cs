﻿using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Game
{
    public class GameFormModel
    {
        [Required]
        [StringLength(GameNameMaxLength, MinimumLength = GameNameMinLength,
            ErrorMessage = GameNameErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(GameDescriptionMaxLength, MinimumLength = GameDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(GameImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = "Date is invalid")]
        public DateTime YearPublished { get; set; }

        [Required]
        public int MissionCount { get; set; }
    }
}
﻿using GrandTheftInfo.Core.Models.Game;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.EasterEgg
{
    public class EasterEggFormModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(EasterEggNameMaxLength, MinimumLength = EasterEggNameMinLength,
            ErrorMessage = EasterEggNameErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(EasterEggDescriptionMaxLength, MinimumLength = EasterEggDescriptionMinLength,
            ErrorMessage = EasterEggDescriptionErrorMessage)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(EasterEggImageOneMaxLength)]
        [Display(Name = "First Image URL")]
        public string ImageUrlOne { get; set; } = null!;

        [StringLength(EasterEggImageTwoMaxLength)]
        [Display(Name = "Second Image URL")]
        public string? ImageUrlTwo { get; set; }

        public int GameId { get; set; }

        public IEnumerable<GameViewModel> Games { get; set; } = new List<GameViewModel>();
    }
}

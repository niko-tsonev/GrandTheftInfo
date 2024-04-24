namespace GrandTheftInfo.Infrastructure.Constants
{
    public class DataConstants
    {
        #region Game
        public const int GameNameMaxLength = 50;
        public const int GameNameMinLength = 5;
        public const string GameNameErrorMessage = "Name must be between {2} and {1} characters long";
        
        public const int GameDescriptionMaxLength = 600;
        public const int GameDescriptionMinLength = 10;
        public const string GameDescriptionErrorMessage = "Description must be between {2} and {1} characters long";

        public const int GameImageUrlMaxLength = 300;
        public const string GameYearPublishedError = "DatePublished field is required!";
        #endregion

        #region Mission
        public const int MissionNameMaxLength = 50;
        public const int MissionNameMinLength = 5;
        public const string MissionNameErrorMessage = "Name must be between {2} and {1} characters long";

        public const int MissionDescriptionMaxLength = 600;
        public const int MissionDescriptionMinLength = 10;
        public const string MissionDescriptionErrorMessage = "Description must be between {2} and {1} characters long";

        public const int MissionPlaytroughUrlMaxLength = 500;
        #endregion

        #region Cheat
        public const int CheatNameMaxLength = 50;
        public const int CheatNameMinLength = 5;
        public const string CheatNameErrorMessage = "Name must be between {2} and {1} characters long";

        public const int CheatCodeMaxLength = 150;
        public const int CheatCodeMinLength = 5;
        public const string CheatCodeErrorMessage = "Cheat Code must be between {2} and {1} characters long";

        public const int CheatPlatformMaxLength = 50;
        #endregion

        #region EasterEgg
        public const int EasterEggNameMaxLength = 50;
        public const int EasterEggNameMinLength = 5;
        public const string EasterEggNameErrorMessage = "Name must be between {2} and {1} characters long";

        public const int EasterEggDescriptionMaxLength = 1000;
        public const int EasterEggDescriptionMinLength = 10;
        public const string EasterEggDescriptionErrorMessage = "Description must be between {2} and {1} characters long";

        public const int EasterEggImageOneMaxLength = 500;
        public const int EasterEggImageTwoMaxLength = 500;
        #endregion

        #region SaveGame
        public const int SaveGameDescriptionMaxLength = 600;
        public const int SaveGameDescriptionMinLength = 10;
        public const string SaveGameDescriptionErrorMessage = "Description must be between {2} and {1} characters long";

        public const int SaveGameFileNameMaxLength = 50;
        public const int SaveGameBlobUriMaxLength = 500;
        #endregion

        #region Song
        public const int SongNameMaxLength = 100;
        public const int SongNameMinLength = 5;
        public const string SongNameErrorMessage = "Name must be between {2} and {1} characters long";

        public const int SongVideoUrlMaxLength = 500;

        public const int SongRadioMaxLength = 100;
        public const int SongRadioMinLength = 5;
        public const string SongRadioErrorMessage = "Radio must be between {2} and {1} characters long";

        public const int SongRadioImageUrlMaxLength = 500;
        #endregion

        #region User
        public const int UserFirstNameMaxLength = 50;
        public const int UserMiddleNameMaxLength = 50;
        public const int UserLastNameMaxLength = 50;
        #endregion
    }
}

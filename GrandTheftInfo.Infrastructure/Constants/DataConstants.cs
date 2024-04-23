namespace GrandTheftInfo.Infrastructure.Constants
{
    public class DataConstants
    {
        //Game
        public const int GameNameMaxLength = 50;
        public const int GameDescriptionMaxLength = 300;
        public const int GameImageUrlMaxLength = 300;
        public const string GameYearPublishedError = "YearPublished field is required!";

        //Mission
        public const int MissionNameMaxLength = 50;
        public const int MissionDescriptionMaxLength = 300;
        public const int MissionPlaytroughUrlMaxLength = 300;

        //Cheat
        public const int CheatNameMaxLength = 50;
        public const int CheatCodeMaxLength = 150;
        public const int CheatPlatformMaxLength = 50;

        //EasterEgg
        public const int EasterEggNameMaxLength = 50;
        public const int EasterEggDescriptionMaxLength = 1000;
        public const int EasterEggImageOneMaxLength = 500;
        public const int EasterEggImageTwoMaxLength = 500;

        //SaveGame
        public const int SaveGameFileNameMaxLength = 50;
        public const int SaveGameDescriptionMaxLength = 500;
        public const int SaveGameBlobUriMaxLength = 500;

        //Song
        public const int SongNameMaxLength = 100;
        public const int SongVideoUrlMaxLength = 500;
        public const int SongRadioMaxLength = 100;
        public const int SongRadioImageUrlMaxLength = 500;

        //User
        public const int UserFirstNameMaxLength = 50;
        public const int UserMiddleNameMaxLength = 50;
        public const int UserLastNameMaxLength = 50;
    }
}

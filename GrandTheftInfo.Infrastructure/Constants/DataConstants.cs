namespace GrandTheftInfo.Infrastructure.Constants
{
    public class DataConstants
    {
        //Game
        public const int GameNameMaxLength = 50;
        public const int GameNameMinLength = 5;
        public const string GameNameErrorMessage = "The name of the game has to be between {2} and {1} characters long";

        public const int GameDescriptionMaxLength = 300;
        public const int GameDescriptionMinLength = 10;

        public const int GameImageUrlMaxLength = 300;

        //Mission
        public const int MissionNameMaxLength = 50;
        public const int MissionDescriptionMaxLength = 300;
        public const int MissionPlaytroughUrlMaxLength = 300;

        //Cheat
        public const int CheatNameMaxLength = 50;
        public const int CheatCodeMaxLength = 150;

        //User
        public const int UserFirstNameMaxLength = 50;
        public const int UserMiddleNameMaxLength = 50;
        public const int UserLastNameMaxLength = 50;
    }
}

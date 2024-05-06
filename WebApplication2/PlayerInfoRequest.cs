namespace WebApplication2
{
    public class PlayerInfoRequest
    {
        //PlayerInfoRequest.cs
            public int Level { get; set; }
            public int Experience { get; set; }
            public int Coins { get; set; }
        }

        // PlayerInfoResponse.cs
        public class PlayerInfoResponse
        {
            public string Message { get; set; }
        }

        // LatestGameResponse.cs
        public class LatestGameResponse
        {
            public int GameId { get; set; }
            public DateTime Timestamp { get; set; }
            public int Score { get; set; }
            public int DurationMinutes { get; set; }
            public string PlayerName { get; set; }
            public int Ranking { get; set; }
        }

        // TopCharactersResponse.cs
        public class TopCharactersResponse
        {
            public string PlayerName { get; set; }
            public int Ranking { get; set; }
            public List<CharacterInfo> TopCharacters { get; set; }
        }

        public class CharacterInfo
        {
            public int CharacterId { get; set; }
            public string CharacterName { get; set; }
            public int PlaytimeHours { get; set; }
        }

}

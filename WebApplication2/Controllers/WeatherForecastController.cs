// PlayerController.cs
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication2;

[Route("api/player")]
[ApiController]
public class PlayerController : ControllerBase
{
    [HttpGet("{player_id}")]
    public ActionResult<PlayerInfoResponse> GetPlayerInfo(int player_id)
    {
        var playerInfo = new PlayerInfoResponse
        {
            Message = "Player info retrieved successfully"
        };
        return Ok(playerInfo);
    }

    [HttpPut("{player_id}")]
    public ActionResult<PlayerInfoResponse> UpdatePlayerInfo(int player_id, PlayerInfoRequest request)
    {
        var response = new PlayerInfoResponse
        {
            Message = "Player information updated successfully"
        };
        return Ok(response);
    }

    [HttpDelete("{player_id}")]
    public ActionResult<PlayerInfoResponse> DeletePlayer(int player_id)
    {
        var response = new PlayerInfoResponse
        {
            Message = "Player deleted successfully"
        };
        return Ok(response);
    }

    [HttpGet("{player_id}/latest_game")]
    public ActionResult<LatestGameResponse> GetLatestGame(int player_id)
    {
        var latestGame = new LatestGameResponse
        {
            GameId = 1,
            Timestamp = DateTime.UtcNow,
            Score = 100,
            DurationMinutes = 10,
            PlayerName = "PlayerName",
            Ranking = 1
        };
        return Ok(latestGame);
    }

    [HttpGet("{player_id}/top_characters")]
    public ActionResult<TopCharactersResponse> GetTopCharacters(int player_id)
    {
        var topCharacters = new List<CharacterInfo>
        {
            new CharacterInfo { CharacterId = 1, CharacterName = "Character1", PlaytimeHours = 20 },
            new CharacterInfo { CharacterId = 2, CharacterName = "Character2", PlaytimeHours = 15 },
            new CharacterInfo { CharacterId = 3, CharacterName = "Character3", PlaytimeHours = 10 },
            new CharacterInfo { CharacterId = 4, CharacterName = "Character4", PlaytimeHours = 5 },
            new CharacterInfo { CharacterId = 5, CharacterName = "Character5", PlaytimeHours = 3 }
        };
        var topCharactersResponse = new TopCharactersResponse
        {
            PlayerName = "PlayerName",
            Ranking = 1,
            TopCharacters = topCharacters
        };
        return Ok(topCharactersResponse);
    }
}

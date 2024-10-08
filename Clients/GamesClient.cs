﻿using GameStore.Models;

namespace GameStore.Clients;


public class GamesClient
{
    private readonly List<GameSummary> games =
    [
        new(){
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateOnly(1991, 7, 15)
        },
        new(){
            Id = 2,
            Name = "Final Fantasy",
            Genre = "Roleplaying",
            Price = 59.99M,
            ReleaseDate = new DateOnly(2010, 9, 30)
        },
        new(){
            Id = 3,
            Name = "FIFA 23",
            Genre = "Sports",
            Price = 69.99M,
            ReleaseDate = new DateOnly(1922, 9, 27)
        },
    ];

    private readonly Genre[] genres = new GenresClient().GetGenres();

    public GameSummary[] GetGames() => [.. games];

    public void AddGame(GameDetails game)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);
        var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));

        var GameSummary = new GameSummary
        {
            Id = games.Count + 1,
            Name = game.Name,
            Genre = genre.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };

        games.Add(GameSummary);
    }

    public GameDetails GetGame(int id)
    {
        GameSummary? game = games.Find(game => game.Id == id);
        ArgumentNullException.ThrowIfNull(game);

        var genre = genres.Single(genre => string.Equals(
            genre.Name, 
            game.Genre, 
            StringComparison.OrdinalIgnoreCase));

        return new GameDetails
        {
            Id = game.Id,
            Name = game.Name,
            GenreId = genre.Id.ToString(),
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }
}

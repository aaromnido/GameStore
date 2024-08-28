using GameStore.Models;

namespace GameStore.Clients;

public class GenresClient
{
    private readonly Genre[] genres =
    [
        new (){
            Id = 1,
            Name = "Fighting"
        },
        new (){
            Id = 2,
            Name = "Kids and Family"
        },
        new (){
            Id = 3,
            Name = "Racing"
        },
        new (){
            Id = 4,
            Name = "Roleplaying"
        },
        new (){
            Id = 5,
            Name = "Simulation"
        },
        new (){
            Id = 6,
            Name = "Sports"
        },
        new (){
            Id = 7,
            Name = "Strategy"
        },

    ];

    public Genre[] GetGenres() => genres;
}

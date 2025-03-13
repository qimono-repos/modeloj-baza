using System;
using System.Collections.Generic;
using HotChocolate.Types;
using Core.Models;

namespace Core.Types;

public class MovieType//: ObjectType<Movie>

{

    public Guid Id { get; set; }

    public string? Title { get; set; }

    public string? Synopsis { get; set; }

    public string? PosterUrl { get; set; }

    public string? TrailerUrl { get; set; }
    
    public DateTime ReleaseDate { get; set; }

    public Genre Genre { get; set; }


    public required IEnumerable<ActorType> Actors { get; set; }  

    public required DirectorType Director { get; set; }

}

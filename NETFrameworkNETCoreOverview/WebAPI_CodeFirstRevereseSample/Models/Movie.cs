using System;
using System.Collections.Generic;

namespace WebAPI_CodeFirstRevereseSample.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public int Type { get; set; }

    public int ImdbRating { get; set; }

    public int ReleaseYear { get; set; }
}

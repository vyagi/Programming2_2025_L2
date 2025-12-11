using System;
using System.Collections.Generic;

namespace DatabaseTutorial;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Pages { get; set; }

    public string Isbn { get; set; } = null!;

    public bool Hardcover { get; set; }

    public int ReleaseYear { get; set; }

    public int AuthorId { get; set; }

    public virtual Author Author { get; set; } = null!;
}

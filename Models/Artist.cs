using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace oneToMany.Models
{
  public class Artist
  {
    [Key]
    public int ArtistId { get; set; }
    public string Name { get; set; }
    public string Genre { get; set; }

    // navigation property
    public List<Song> Discography { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace oneToMany.Models
{
  public class Artist
  {
    [Key]
    public int ArtistId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Genre { get; set; }

    // navigation property
    public List<Song> Discography { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}
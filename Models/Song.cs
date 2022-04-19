using System;
using System.ComponentModel.DataAnnotations;

namespace oneToMany.Models
{
  public class Song
  {
    [Key]
    public int SongId { get; set; }
    public string Title { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public int ArtistId { get; set; }

    // navigation property
    public Artist Performer { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}
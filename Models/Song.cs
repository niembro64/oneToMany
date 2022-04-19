using System;
using System.ComponentModel.DataAnnotations;

namespace oneToMany.Models
{
  public class Song
  {
    [Key]
    public int SongId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    [Range(0,59)]
    public int Minutes { get; set; }
    [Required]
       [Range(0,59)]
    public int Seconds { get; set; }
    [Required]
    public int ArtistId { get; set; }

    // navigation property
    public Artist Performer { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}
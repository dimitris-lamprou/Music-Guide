using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Music_Guide.Models;

[Table("songs")]
public partial class Song
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("title")]
    [StringLength(50)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [Column("artist")]
    [StringLength(50)]
    [Unicode(false)]
    public string Artist { get; set; } = null!;

    [Column("released")]
    public short Released { get; set; }

    [Column("genre_id")]
    public Guid GenreId { get; set; }

    [Column("mood")]
    [StringLength(255)]
    [Unicode(false)]
    public string Mood { get; set; } = null!;

    [Column("url")]
    [StringLength(255)]
    [Unicode(false)]
    public string Url { get; set; } = null!;

    [ForeignKey("GenreId")]
    [InverseProperty("Songs")]
    public virtual Genre Genre { get; set; } = null!;

    [InverseProperty("Song")]
    public virtual ICollection<UserSongInterface> UserSongInterfaces { get; set; } = new List<UserSongInterface>();
}

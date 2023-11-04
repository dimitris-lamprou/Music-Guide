using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Music_Guide.Models;

[PrimaryKey("UserId", "SongId")]
[Table("user_song_interface")]
public partial class UserSongInterface
{
    [Key]
    [Column("user_id")]
    public Guid UserId { get; set; }

    [Key]
    [Column("song_id")]
    public Guid SongId { get; set; }

    [Column("listened_count")]
    public short ListenedCount { get; set; }

    [Column("is_liked")]
    public bool IsLiked { get; set; }

    [ForeignKey("SongId")]
    [InverseProperty("UserSongInterfaces")]
    public virtual Song Song { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserSongInterfaces")]
    public virtual User User { get; set; } = null!;
}

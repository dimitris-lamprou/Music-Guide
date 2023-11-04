using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Music_Guide.Models;

[PrimaryKey("UserId", "GenreId")]
[Table("user_genre_interface")]
public partial class UserGenreInterface
{
    [Key]
    [Column("user_id")]
    public Guid UserId { get; set; }

    [Key]
    [Column("genre_id")]
    public Guid GenreId { get; set; }

    [Column("is_liked")]
    public bool IsLiked { get; set; }

    [ForeignKey("GenreId")]
    [InverseProperty("UserGenreInterfaces")]
    public virtual Genre Genre { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserGenreInterfaces")]
    public virtual User User { get; set; } = null!;
}

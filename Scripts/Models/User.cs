using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Music_Guide.Models;

[Table("users")]
public partial class User
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("name")]
    [StringLength(30)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("password")]
    [StringLength(20)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Required]
    [Column("new_user")]
    public bool? NewUser { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<UserGenreInterface> UserGenreInterfaces { get; set; } = new List<UserGenreInterface>();

    [InverseProperty("User")]
    public virtual ICollection<UserSongInterface> UserSongInterfaces { get; set; } = new List<UserSongInterface>();
}

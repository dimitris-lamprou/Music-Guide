using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Music_Guide.Models;

[Table("genres")]
public partial class Genre
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("genre")]
    [StringLength(10)]
    [Unicode(false)]
    public string Genre1 { get; set; } = null!;

    [InverseProperty("Genre")]
    public virtual ICollection<Song> Songs { get; set; } = new List<Song>();

    [InverseProperty("Genre")]
    public virtual ICollection<UserGenreInterface> UserGenreInterfaces { get; set; } = new List<UserGenreInterface>();
}

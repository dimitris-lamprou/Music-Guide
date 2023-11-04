using Microsoft.EntityFrameworkCore;
using Music_Guide.Models;

namespace Music_Guide.Data;

public partial class MusicGuideContext : DbContext
{
    public MusicGuideContext()
    {
    }

    public MusicGuideContext(DbContextOptions<MusicGuideContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Song> Songs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserGenreInterface> UserGenreInterfaces { get; set; }

    public virtual DbSet<UserSongInterface> UserSongInterfaces { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=\"Music Guide\";Integrated Security=True;Encrypt=False");
#pragma warning restore CS1030 // #warning directive

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Genre1).IsFixedLength();
        });

        modelBuilder.Entity<Song>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_songs_test");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Artist).IsFixedLength();
            entity.Property(e => e.Mood).IsFixedLength();
            entity.Property(e => e.Title).IsFixedLength();
            entity.Property(e => e.Url).IsFixedLength();

            entity.HasOne(d => d.Genre).WithMany(p => p.Songs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_songs_test_genres");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Users");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).IsFixedLength();
            entity.Property(e => e.NewUser).HasDefaultValueSql("((1))");
            entity.Property(e => e.Password).IsFixedLength();
        });

        modelBuilder.Entity<UserGenreInterface>(entity =>
        {
            entity.HasOne(d => d.Genre).WithMany(p => p.UserGenreInterfaces)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_genre_interface_genres");

            entity.HasOne(d => d.User).WithMany(p => p.UserGenreInterfaces)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_genre_interface_users");
        });

        modelBuilder.Entity<UserSongInterface>(entity =>
        {
            entity.HasOne(d => d.Song).WithMany(p => p.UserSongInterfaces)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_song_interface_Songs");

            entity.HasOne(d => d.User).WithMany(p => p.UserSongInterfaces)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_song_interface_Users");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

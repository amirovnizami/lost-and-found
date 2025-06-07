using Lost_And_Found.Core.ContributorAggregate;
using LostAndFound.Project.Core.LostItemAggregate;
using LostAndFound.Project.Core.MatchAggregate;
using LostAndFound.Project.Core.NotificationAggregate;
using LostAndFound.Project.Core.ReportAggregate;
using LostAndFound.Project.Core.UserAggregate;

namespace Lost_And_Found.Infrastructure.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options,
  IDomainEventDispatcher? dispatcher) : DbContext(options)
{
  private readonly IDomainEventDispatcher? _dispatcher = dispatcher;

  public DbSet<Contributor> Contributors => Set<Contributor>();
  public DbSet<LostItem> LostItems => Set<LostItem>();
  public DbSet<User> Users => Set<User>();
  public DbSet<FoundItem> FoundItems => Set<FoundItem>();
  public DbSet<Notification> Notification => Set<Notification>();
  public DbSet<Report> Reports => Set<Report>();
  //public DbSet<Match> Matches = Set<Match>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<LostItem>()
    .HasOne(li => li.User)
    .WithMany(u => u.LostItems)
    .HasForeignKey(li => li.UserId)
    .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<FoundItem>()
    .HasOne(fi => fi.User)
    .WithMany(u => u.FoundItems)
    .HasForeignKey(fi => fi.UserId)
    .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Notification>()
    .HasOne(n => n.User)
    .WithMany(u => u.Notifications)
    .HasForeignKey(n => n.UserId)
    .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Match>()
    .HasOne(m => m.LostItem)
    .WithMany(li => li.Matches)
    .HasForeignKey(m => m.LostItemId)
    .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Match>()
    .HasOne(m => m.FoundItem)
    .WithMany(fi => fi.Matches)
    .HasForeignKey(m => m.FoundItemId)
    .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Report>()
    .HasOne(r => r.User)
    .WithMany(u => u.Reports)
    .HasForeignKey(r => r.UserId)
    .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Report>()
    .HasOne(r => r.LostItem)
    .WithMany(li => li.Reports)
    .HasForeignKey(r => r.LostItemId)
    .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Report>()
        .HasOne(r => r.FoundItem)
        .WithMany(fi => fi.Reports)
        .HasForeignKey(r => r.FoundItemId)
        .OnDelete(DeleteBehavior.Restrict);


    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {
    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    // ignore events if no dispatcher provided
    if (_dispatcher == null) return result;

    // dispatch events only if save was successful
    var entitiesWithEvents = ChangeTracker.Entries<HasDomainEventsBase>()
        .Select(e => e.Entity)
        .Where(e => e.DomainEvents.Any())
        .ToArray();

    await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges() =>
        SaveChangesAsync().GetAwaiter().GetResult();
}

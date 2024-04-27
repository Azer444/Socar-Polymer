using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class PolymerContext : IdentityDbContext
    {
        public PolymerContext(DbContextOptions<PolymerContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    Name = "Manager",
                    NormalizedName = "Manager".ToUpper()
                });

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                });

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                    Name = "Standart",
                    NormalizedName = "Standart".ToUpper()
                });

            var hasher = new PasswordHasher<User>();

            builder.Entity<User>().HasData(
                new User
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UserName = "polymer_manager",
                    NormalizedUserName = "polymer_manager".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "polymermanager321"),
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );
        }

        public DbSet<CertificateComponent> CertificateComponents { get; set; }
        public DbSet<CertificateComponentFile> CertificateComponentFiles { get; set; }
        public DbSet<ContactFormComponent> ContactFormComponent { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<ContactTextComponent> ContactTextComponent { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<HomeBannerComponent> HomeBannerComponent { get; set; }
        public DbSet<HomeSliderComponent> HomeSliderComponents { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MarketComponent> MarketComponents { get; set; }
        public DbSet<MarketComponentFile> MarketComponentFiles { get; set; }
        public DbSet<MarketSubComponent> MarketSubComponents { get; set; }
        public DbSet<MarketSubComponentFile> MarketSubComponentFiles { get; set; }
        public DbSet<MarketTitleComponent> MarketTitleComponents { get; set; }
        public DbSet<MarketTitleComponentFile> MarketTitleComponentFiles { get; set; }
        public DbSet<NavComponent> NavComponents { get; set; }
        public DbSet<NavTitleComponent> NavTitleComponents { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsFile> NewsFiles { get; set; }
        public DbSet<PageAccessComponent> PageAccessComponents { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrochure> ProductBrochures { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductCategoryProperty> ProductCategoryProperties { get; set; }
        public DbSet<ProductField> ProductFields { get; set; }
        public DbSet<ProductTitleCategory> ProductTitleCategories { get; set; }
        public DbSet<ProductContactMessage> ProductContactMessages { get; set; }
    }
}

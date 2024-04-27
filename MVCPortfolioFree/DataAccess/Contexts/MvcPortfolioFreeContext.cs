using Microsoft.EntityFrameworkCore;
using MVCPortfolioFree.DataAccess.Entities;

namespace MVCPortfolioFree.DataAccess.Contexts;

public class MvcPortfolioFreeContext : DbContext
{
	public MvcPortfolioFreeContext(DbContextOptions<MvcPortfolioFreeContext> options) : base(options)
	{
		
	}
	

	public DbSet<About> Abouts { get; set; }
	public DbSet<Contact> Contacts { get; set; }
	public DbSet<Experience> Experiences { get; set; }
	public DbSet<Feature> Features { get; set; }
	public DbSet<Message> Messages { get; set; }
	public DbSet<Portfolio> Portfolios { get; set; }
	public DbSet<Skill> Skills { get; set; }
	public DbSet<SocialPlatform> SocialPlatforms { get; set; }
	public DbSet<Testimonial> Testimonials { get; set; }
}

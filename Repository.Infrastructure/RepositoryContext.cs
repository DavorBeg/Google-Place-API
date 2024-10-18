using Entities.Domain.Auth;
using Entities.Domain.Google;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure
{
	public class RepositoryContext : IdentityDbContext<User>
	{
		public DbSet<Place>? Places { get; set; }

        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			#region Place_Fluent_Config
			builder.Entity<Place>()
				.HasMany(x => x.AddressComponents)
				.WithOne()
				.HasForeignKey("AddressComponentsId")
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.PlusCode)
				.WithOne()
				.HasForeignKey<Place>(x => x.Id);

			builder.Entity<Place>()
				.HasOne(x => x.Location)
				.WithOne()
				.HasForeignKey<Place>(x => x.Id)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.Viewport)
				.WithOne()
				.HasForeignKey<Place>(x => x.Id)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.RegularOpeningHours)
				.WithOne()
				.HasForeignKey<Place>("RegularOpeningHoursId")
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.DisplayName)
				.WithOne()
				.HasForeignKey<Place>("DisplayNameId")
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.PrimaryTypeDisplayName)
				.WithOne()
				.HasForeignKey<Place>("PrimaryTypeDisplayNameId")
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.CurrentOpeningHours)
				.WithOne()
				.HasForeignKey<Place>("CurrentOpeningHoursId")
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.EditorialSummary)
				.WithOne()
				.HasForeignKey<Place>("EditorialSummaryId")
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasMany(x => x.Reviews)
				.WithOne()
				.HasForeignKey(x => x.PlaceId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasMany(x => x.Photos)
				.WithOne()
				.HasForeignKey(x => x.PlaceId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.PaymentOptions)
				.WithOne()
				.HasForeignKey<Place>(x => x.Id)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.ParkingOptions)
				.WithOne()
				.HasForeignKey<Place>(x => x.Id)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.AccessibilityOptions)
				.WithOne()
				.HasForeignKey<Place>(x => x.Id)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.GenerativeSummary)
				.WithOne()
				.HasForeignKey<Place>(x => x.Id)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.AddressDescriptor)
				.WithOne()
				.HasForeignKey<Place>(x => x.Id)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasMany(x => x.CurrentSecondaryOpeningHours)
				.WithOne()
				.HasForeignKey("CurrentSecondaryOpeningHoursId")
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasMany(x => x.RegularSecondaryOpeningHours)
				.WithOne()
				.HasForeignKey("RegularSecondaryOpeningHoursId")
				.OnDelete(DeleteBehavior.Restrict);
			#endregion

			#region AddressDescriptor_Fluent_Config

			builder.Entity<AddressDescriptor>()
				.HasMany(x => x.Landmarks)
				.WithOne()
				.HasForeignKey("AddressDescriptorId")
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<AddressDescriptor>()
				.HasMany(x => x.Areas)
				.WithOne()
				.HasForeignKey("AddressDescriptorId")
				.OnDelete(DeleteBehavior.Restrict);
			#endregion

			#region Area_Fluent_Config

			builder.Entity<Area>()
				.HasOne(x => x.DisplayName)
				.WithOne()
				.HasForeignKey<Area>(x => x.Id)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			builder.ApplyConfiguration(new RoleConfiguration());

			base.OnModelCreating(builder);
		}
	}
}


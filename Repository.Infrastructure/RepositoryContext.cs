using Entities.Domain.Auth;
using Entities.Domain.Favorite;
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
		public DbSet<Place> Places { get; set; }
		public DbSet<FavoritePlace> FavoritePlaces { get; set; }

        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			#region Place_Fluent_Config
			builder.Entity<Place>()
				.HasMany(x => x.AddressComponents)
				.WithOne()
				.HasForeignKey(x => x.PlaceId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.PlusCode)
				.WithOne()
				.HasForeignKey<PlusCode>(x => x.PlaceId);

			builder.Entity<Place>()
				.HasOne(x => x.Location)
				.WithOne()
				.HasForeignKey<Location>(x => x.PlaceId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.Viewport)
				.WithOne()
				.HasForeignKey<Viewport>(x => x.PlaceId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.RegularOpeningHours)
				.WithOne()
				.HasForeignKey<Place>(x => x.RegularOpeningHoursId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.DisplayName)
				.WithOne()
				.HasForeignKey<Place>(x => x.DisplayNameId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.PrimaryTypeDisplayName)
				.WithOne()
				.HasForeignKey<Place>(x => x.PrimaryTypeDisplayNameId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.CurrentOpeningHours)
				.WithOne()
				.HasForeignKey<Place>(x => x.CurrentOpeningHoursId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.EditorialSummary)
				.WithOne()
				.HasForeignKey<Place>(x => x.EditorialSummaryId)
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
				.HasForeignKey<PaymentOptions>(x => x.PlaceId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.ParkingOptions)
				.WithOne()
				.HasForeignKey<ParkingOptions>(x => x.PlaceId) 
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.AccessibilityOptions)
				.WithOne()
				.HasForeignKey<AccessibilityOptions>(x => x.PlaceId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.GenerativeSummary)
				.WithOne()
				.HasForeignKey<GenerativeSummary>(x => x.PlaceId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasOne(x => x.AddressDescriptor)
				.WithOne()
				.HasForeignKey<AddressDescriptor>(x => x.PlaceId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasMany(x => x.CurrentSecondaryOpeningHours)
				.WithOne()
				.HasForeignKey(x => x.PlaceCurrentSecondaryOpeningHoursId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Place>()
				.HasMany(x => x.RegularSecondaryOpeningHours)
				.WithOne()
				.HasForeignKey(x => x.PlaceRegularSecondaryOpeningHoursId)
				.OnDelete(DeleteBehavior.Restrict);
			#endregion

			#region AddressDescriptor_Fluent_Config

			builder.Entity<AddressDescriptor>()
				.HasMany(x => x.Landmarks)
				.WithOne()
				.HasForeignKey(x => x.AddressDescriptorId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<AddressDescriptor>()
				.HasMany(x => x.Areas)
				.WithOne()
				.HasForeignKey(x => x.AddressDescriptorId)
				.OnDelete(DeleteBehavior.Restrict);
			#endregion

			#region Area_Fluent_Config

			builder.Entity<Area>()
				.HasOne(x => x.DisplayName)
				.WithOne()
				.HasForeignKey<Area>(x => x.DisplayNameId)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			#region Circle_Fluent_Config

			builder.Entity<Circle>()
				.HasOne(x => x.Center)
				.WithOne()
				.HasForeignKey<Circle>(x => x.CenterId)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			#region CurrentOpeningHours_Fluent_Config

			builder.Entity<CurrentOpeningHours>()
				.HasMany(x => x.Periods)
				.WithOne()
				.HasForeignKey(x => x.CurrentOpeningHoursId)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			#region GenerativeSummary_Fluent_Config

			builder.Entity<GenerativeSummary>()
				.HasOne(x => x.Overview)
				.WithOne()
				.HasForeignKey<GenerativeSummary>(x => x.OverviewId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<GenerativeSummary>()
				.HasOne(x => x.Description)
				.WithOne()
				.HasForeignKey<GenerativeSummary>(x => x.DescriptionId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<GenerativeSummary>()
				.HasOne(x => x.References)
				.WithMany()
				.HasForeignKey(x => x.ReferencesId)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			#region LandMark_Fluent_Config

			builder.Entity<Landmark>()
				.HasOne(x => x.DisplayName)
				.WithOne()
				.HasForeignKey<Landmark>(x => x.DisplayNameId)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			#region Period_Fluent_Config

			builder.Entity<Period>()
				.HasOne(x => x.Close)
				.WithOne()
				.HasForeignKey<Period>(x => x.CloseId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Period>()
				.HasOne(x => x.Open)
				.WithOne()
				.HasForeignKey<Period>(x => x.OpenId)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			#region Photo_Fluent_Config

			builder.Entity<Photo>()
				.HasMany(x => x.AuthorAttributions)
				.WithOne()
				.HasForeignKey(x => x.PhotoId)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			#region References_FLuent_Config

			builder.Entity<References>()
				.HasMany(x => x.Reviews)
				.WithOne()
				.HasForeignKey(x => x.ReferencesId)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			#region Review_Fluent_Config

			builder.Entity<Review>()
				.HasOne(x => x.Text)
				.WithOne()
				.HasForeignKey<Review>(x => x.TextId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Review>()
				.HasOne(x => x.OriginalText)
				.WithOne()
				.HasForeignKey<Review>(x => x.OriginalTextId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Review>()
				.HasOne(x => x.AuthorAttribution)
				.WithOne()
				.HasForeignKey<Review>(x => x.AuthorAttributionId)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			#region Viewport_Fluent_Config

			builder.Entity<Viewport>()
				.HasOne(x => x.Low)
				.WithOne()
				.HasForeignKey<Viewport>(x => x.LowId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Viewport>()
				.HasOne(x => x.High)
				.WithOne()
				.HasForeignKey<Viewport>(x => x.HighId)
				.OnDelete(DeleteBehavior.Restrict);

			#endregion

			#region Close_Fluent_Config
			builder.Entity<Close>()
				.HasOne(x => x.Date)
				.WithOne()
				.HasForeignKey<Date>(x => x.CloseId)
				.OnDelete(DeleteBehavior.Restrict);
			#endregion

			builder.ApplyConfiguration(new RoleConfiguration());

			base.OnModelCreating(builder);
		}
	}
}


using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	// Documentation page:
	// https://developers.google.com/maps/documentation/places/web-service/reference/rest/v1/places
	public class Place
	{
		/// <summary>
		/// The unique identifier of a place.
		/// </summary>
		public string Id { get; set; } = null!;

		/// <summary>
		/// This Place's resource name, in places/{placeId} format. Can be used to look up the Place.
		/// </summary>
		public string Name { get; set; } = null!;

		/// <summary>
		/// The localized name of the place, suitable as a short human-readable description. 
		/// For example, "Google Sydney", "Starbucks", "Pyrmont", etc.
		/// </summary>
		public LocalizedText DisplayName { get; set; } = null!;

		/// <summary>
		/// A set of type tags for this result. For example, "political" and "locality". 
		/// For the complete list of possible values, see Table A and Table B at https://developers.google.com/maps/documentation/places/web-service/place-types
		/// </summary>
		public List<string> Types { get; set; } = new List<string>();

		/// <summary>
		/// The display name of the primary type, localized to the request language if applicable. 
		/// For the complete list of possible values, see Table A and Table B at https://developers.google.com/maps/documentation/places/web-service/place-types
		/// </summary>
		public string PrimaryType { get; set; } = string.Empty;

		/// <summary>
		/// A human-readable phone number for the place, in national format.
		/// </summary>
		public LocalizedText PrimaryTypeDisplayName { get; set; } = new LocalizedText();

		/// <summary>
		/// A human-readable phone number for the place, in international format.
		/// </summary>
		public string NationalPhoneNumber { get; set; } = string.Empty;

		/// <summary>
		/// A human-readable phone number for the place, in international format.
		/// </summary>
		public string InternationalPhoneNumber { get; set; } = string.Empty;

		/// <summary>
		/// A full, human-readable address for this place.
		/// </summary>
		public string FormattedAddress { get; set; } = string.Empty;

		/// <summary>
		/// A short, human-readable address for this place.
		/// </summary>
		public string ShortFormattedAddress { get; set; } = string.Empty;

		/// <summary>
		/// Repeated components for each locality level. 
		/// Note the following facts about the addressComponents[] array: - The array of address components may contain more components than the formattedAddress. 
		/// - The array does not necessarily include all the political entities that contain an address, apart from those included in the formattedAddress. 
		/// To retrieve all the political entities that contain a specific address, you should use reverse geocoding, passing the latitude/longitude of the address as a parameter to the request.
		/// - The format of the response is not guaranteed to remain the same between requests. 
		/// In particular, the number of addressComponents varies based on the address requested and can change over time for the same address.
		/// A component can change position in the array. The type of the component can change. A particular component may be missing in a later response.
		/// </summary>
		public IEnumerable<AddressComponent> AddressComponents { get; set; } = Enumerable.Empty<AddressComponent>();

		/// <summary>
		/// Plus code of the place location lat/long.
		/// </summary>
		public PlusCode PlusCode { get; set; } = new PlusCode();

		/// <summary>
		/// The position of this place.
		/// </summary>
		public LatLng Location { get; set; } = new LatLng();

		/// <summary>
		/// A viewport suitable for displaying the place on an average-sized map.
		/// </summary>
		public Viewport Viewport { get; set; } = new Viewport();

		/// <summary>
		/// A rating between 1.0 and 5.0, based on user reviews of this place.
		/// </summary>
		public double? Rating { get; set; }

		/// <summary>
		/// A URL providing more information about this place.
		/// </summary>
		public string GoogleMapsUri { get; set; } = string.Empty;

		/// <summary>
		/// The authoritative website for this place, e.g. a business' homepage.
		/// Note that for places that are part of a chain (e.g. an IKEA store), this will usually be the website for the individual store, not the overall chain.
		/// </summary>
		public string WebsiteUri { get; set; } = string.Empty;

		/// <summary>
		/// List of reviews about this place, sorted by relevance. A maximum of 5 reviews can be returned.
		/// </summary>
		public IEnumerable<Review> Reviews { get; set; } = Enumerable.Empty<Review>();

		/// <summary>
		/// The regular hours of operation.
		/// </summary>
		public OpeningHours RegularOpeningHours { get; set; } = new OpeningHours();

		/// <summary>
		/// Information (including references) about photos of this place. A maximum of 10 photos can be returned.
		/// </summary>
		public List<Photo> Photos { get; set; } = new List<Photo>();

		/// <summary>
		/// The place's address in adr microformat: http://microformats.org/wiki/adr.
		/// </summary>
		public string AdrFormatAddress { get; set; } = string.Empty;

		/// <summary>
		/// The business status for the place.
		/// </summary>
		public BusinessStatus? BusinessStatus { get; set; }

		/// <summary>
		/// Price level of the place.
		/// </summary>
		public PriceLevel? PriceLevel { get; set; }

		/// <summary>
		/// A set of data provider that must be shown with this result.
		/// </summary>
		public IEnumerable<Attribution> Attributions { get; set; } = new List<Attribution>();

		/// <summary>
		/// A truncated URL to an icon mask. User can access different icon type by appending type suffix to the end (eg, ".svg" or ".png").
		/// </summary>
		public string IconMaskBaseUri { get; set; } = string.Empty;

		/// <summary>
		/// Background color for icon_mask in hex format, e.g. #909CE1.
		/// </summary>
		public string IconBackgroundColor { get; set; } = string.Empty;

		/// <summary>
		/// The hours of operation for the next seven days (including today). 
		/// The time period starts at midnight on the date of the request and ends at 11:59 pm six days later. 
		/// This field includes the specialDays subfield of all hours, set for dates that have exceptional hours.
		/// </summary>
		public OpeningHours CurrentOpeningHours { get; set; } = new OpeningHours();

		/// <summary>
		/// Contains an array of entries for the next seven days including information about secondary hours of a business. 
		/// Secondary hours are different from a business's main hours.
		/// For example, a restaurant can specify drive through hours or delivery hours as its secondary hours. 
		/// This field populates the type subfield, which draws from a predefined list of opening hours types 
		/// (such as DRIVE_THROUGH, PICKUP, or TAKEOUT) based on the types of the place. 
		/// This field includes the specialDays subfield of all hours, set for dates that have exceptional hours.
		/// </summary>
		public IEnumerable<OpeningHours> CurrentSecondaryOpeningHours { get; set; } = Enumerable.Empty<OpeningHours>();

		/// <summary>
		/// Contains an array of entries for information about regular secondary hours of a business. 
		/// Secondary hours are different from a business's main hours. 
		/// For example, a restaurant can specify drive through hours or delivery hours as its secondary hours. 
		/// This field populates the type subfield, which draws from a predefined 
		/// list of opening hours types (such as DRIVE_THROUGH, PICKUP, or TAKEOUT) based on the types of the place.
		/// </summary>
		public IEnumerable<OpeningHours> RegularSecondaryOpeningHours { get; set; } = Enumerable.Empty<OpeningHours>();

		/// <summary>
		/// Contains a summary of the place. A summary is comprised of a textual overview, and also includes the language code for these if applicable. 
		/// Summary text must be presented as-is and can not be modified or altered.
		/// </summary>
		public LocalizedText EditorialSummary { get; set; } = new LocalizedText();

		/// <summary>
		/// Payment options the place accepts. If a payment option data is not available, the payment option field will be unset.
		/// </summary>
		public PaymentOptions PaymentOptions { get; set; } = new PaymentOptions();

		/// <summary>
		/// Options of parking provided by the place.
		/// </summary>
		public ParkingOptions ParkingOptions { get; set; } = new ParkingOptions();

		/// <summary>
		/// A list of sub destinations related to the place.
		/// </summary>
		public IEnumerable<SubDestination> SubDestinations { get; set; } = Enumerable.Empty<SubDestination>();

		/// <summary>
		/// The most recent information about fuel options in a gas station. This information is updated regularly.
		/// </summary>
		public FuelOptions? FuelOptions { get; set; } = new FuelOptions();

		/// <summary>
		/// Information of ev charging options.
		/// </summary>
		public EVChargeOptions? EvChargeOptions { get; set; }

		/// <summary>
		/// Experimental: See https://developers.google.com/maps/documentation/places/web-service/experimental/places-generative for more details.
		/// AI-generated summary of the place.
		/// </summary>
		public GenerativeSummary? GenerativeSummary { get; set; }

		/// <summary>
		/// Experimental: See https://developers.google.com/maps/documentation/places/web-service/experimental/places-generative for more details. 
		/// AI-generated summary of the area that the place is in.
		/// </summary>
		public AreaSummary? AreaSummary { get; set; }

		/// <summary>
		/// The address descriptor of the place. 
		/// Address descriptors include additional information that help describe a location using landmarks and areas. 
		/// See address descriptor regional coverage in https://developers.google.com/maps/documentation/geocoding/address-descriptors/coverage.
		/// </summary>
		public AddressDescriptor? AddressDescriptor { get; set; }

		/// <summary>
		/// Information about the accessibility options a place offers.
		/// </summary>
		public AccessibilityOptions? AccessibilityOptions { get; set; }

		/// <summary>
		/// Number of minutes this place's timezone is currently offset from UTC. 
		/// This is expressed in minutes to support timezones that are offset by fractions of an hour, e.g. X hours and 15 minutes.
		/// </summary>
		public int UtcOffsetMinutes { get; set; }

		/// <summary>
		/// The total number of reviews (with or without text) for this place.
		/// </summary>
		public int UserRatingCount { get; set; }

		/// <summary>
		/// Specifies if the business supports takeout.
		/// </summary>
		public bool? Takeout { get; set; }

		/// <summary>
		/// Specifies if the business supports delivery.
		/// </summary>
		public bool? Delivery { get; set; }

		/// <summary>
		/// Specifies if the business supports indoor or outdoor seating options.
		/// </summary>
		public bool? DineIn { get; set; }

		/// <summary>
		/// Specifies if the business supports curbside pickup.
		/// </summary>
		public bool? CurbsidePickup { get; set; }

		/// <summary>
		/// Specifies if the place supports reservations.
		/// </summary>
		public bool? Reservable { get; set; }

		/// <summary>
		/// Specifies if the place serves breakfast.
		/// </summary>
		public bool? ServesBreakfast { get; set; }

		/// <summary>
		/// Specifies if the place serves lunch.
		/// </summary>
		public bool? ServesLunch { get; set; }

		/// <summary>
		/// Specifies if the place serves dinner.
		/// </summary>
		public bool? ServesDinner { get; set; }

		/// <summary>
		/// Specifies if the place serves beer.
		/// </summary>
		public bool? ServesBeer { get; set; }

		/// <summary>
		/// Specifies if the place serves wine.
		/// </summary>
		public bool? ServesWine { get; set; }

		/// <summary>
		/// Specifies if the place serves brunch.
		/// </summary>
		public bool? ServesBrunch { get; set; }

		/// <summary>
		/// Specifies if the place serves vegetarian food.
		/// </summary>
		public bool? ServesVegetarianFood { get; set; }

		/// <summary>
		/// Place provides outdoor seating.
		/// </summary>
		public bool? OutdoorSeating { get; set; }

		/// <summary>
		/// Place provides live music.
		/// </summary>
		public bool? LiveMusic { get; set; }

		/// <summary>
		/// Place has a children's menu.
		/// </summary>
		public bool? MenuForChildren { get; set; }

		/// <summary>
		/// Place serves cocktails.
		/// </summary>
		public bool? ServesCocktails { get; set; }

		/// <summary>
		/// Place serves dessert.
		/// </summary>
		public bool? ServesDessert { get; set; }

		/// <summary>
		/// Place serves coffee.
		/// </summary>
		public bool? ServesCoffee { get; set; }

		/// <summary>
		/// Place is good for children.
		/// </summary>
		public bool? GoodForChildren { get; set; }

		/// <summary>
		/// Place allows dogs.
		/// </summary>
		public bool? AllowsDogs { get; set; }

		/// <summary>
		/// Place has restroom.
		/// </summary>
		public bool? Restroom { get; set; }

		/// <summary>
		/// Place accommodates groups.
		/// </summary>
		public bool? GoodForGroups { get; set; }

		/// <summary>
		/// Place is suitable for watching sports.
		/// </summary>
		public bool? GoodForWatchingSports { get; set; }
	}
}

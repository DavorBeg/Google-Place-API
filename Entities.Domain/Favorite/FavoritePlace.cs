using Entities.Domain.Google;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Favorite
{
	public class FavoritePlace
	{
		[Key]
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid UserId { get; set; } 
		public List<string>? Types { get; set; } = null;
		public DateTime CreatedAt { get; set; } = DateTime.Now;

		public Guid? PlaceId { get; set; }

		[ForeignKey(nameof(PlaceId))]
		public virtual Place? Place { get; set; }




	}
}

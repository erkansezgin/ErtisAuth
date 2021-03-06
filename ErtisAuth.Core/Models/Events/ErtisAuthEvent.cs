using System;
using ErtisAuth.Core.Models.Applications;
using ErtisAuth.Core.Models.Users;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ErtisAuth.Core.Models.Events
{
	public class ErtisAuthEvent : ResourceBase, IHasMembership
	{
		#region Properties

		[JsonProperty("event_type")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ErtisAuthEventType EventType { get; set; }
		
		[JsonProperty("utilizer_id")]
		public string UtilizerId { get; set; }
		
		[JsonProperty("membership_id")]
		public string MembershipId { get; set; }

		[JsonProperty("document")]
		public dynamic Document { get; set; }
		
		[JsonProperty("prior")]
		public dynamic Prior { get; set; }
		
		[JsonProperty("event_time")]
		public DateTime EventTime { get; set; }
		
		#endregion
		
		#region Constructors

		/// <summary>
		/// Default Constructor
		/// </summary>
		public ErtisAuthEvent()
		{
			
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type"></param>
		/// <param name="user"></param>
		/// <param name="document"></param>
		/// <param name="prior"></param>
		public ErtisAuthEvent(ErtisAuthEventType type, User user, dynamic document = null, dynamic prior = null)
		{
			this.EventType = type;
			this.UtilizerId = user.Id;
			this.MembershipId = user.MembershipId;
			this.Document = document;
			this.Prior = prior;
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type"></param>
		/// <param name="application"></param>
		/// <param name="document"></param>
		/// <param name="prior"></param>
		public ErtisAuthEvent(ErtisAuthEventType type, Application application, dynamic document = null, dynamic prior = null)
		{
			this.EventType = type;
			this.UtilizerId = application.Id;
			this.MembershipId = application.MembershipId;
			this.Document = document;
			this.Prior = prior;
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type"></param>
		/// <param name="utilizerId"></param>
		/// <param name="membershipId"></param>
		/// <param name="document"></param>
		/// <param name="prior"></param>
		public ErtisAuthEvent(ErtisAuthEventType type, string utilizerId, string membershipId, dynamic document = null, dynamic prior = null)
		{
			this.EventType = type;
			this.UtilizerId = utilizerId;
			this.MembershipId = membershipId;
			this.Document = document;
			this.Prior = prior;
		}

		#endregion
	}
}
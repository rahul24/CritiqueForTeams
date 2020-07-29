using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBot.Common.Entity
{
    public class JoinCallBody
    {
        /// <summary>
        /// Gets or sets the meeting identifier.
        /// </summary>
        public string MeetingId { get; set; }

        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the Teams meeting join URL.
        /// </summary>
        public string JoinURL { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// Teams client does not allow changing of ones own display name.
        /// If display name is specified, we join as anonymous (guest) user
        /// with the specified display name.  This will put bot into lobby
        /// unless lobby bypass is disabled.
        /// </summary>
        public string DisplayName { get; set; }
    }
}

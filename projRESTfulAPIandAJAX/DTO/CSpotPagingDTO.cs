using projRESTfulAPIandAJAX.Models;
using System.Collections;

namespace projAJAX.DTO
{
    public class CSpotPagingDTO
    {
        public IQueryable<SpotImagesSpot>? spotsResult { get; set; }
        public int totalPages { get; set; }
        public int totalCount { get; set; }
    }
}

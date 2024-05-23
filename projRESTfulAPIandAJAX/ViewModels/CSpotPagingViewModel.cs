using projRESTfulAPIandAJAX.Models;
using System.Collections;

namespace projRESTfulAPIandAJAX.ViewModels
{
    public class CSpotPagingViewModel
    {
        public IQueryable<SpotImagesSpot>? spotsResult { get; set; }
        public int totalPages {  get; set; }
        public int totalCount { get; set; }
    }
}

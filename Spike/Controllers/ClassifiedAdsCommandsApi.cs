using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Spike.Api
{
    [Route("/ad")]
    public class ClassifiedAdsCommandsApi : Controller
    {
        private readonly ClassifiedAdsApplicationService _applicationService;
        public ClassifiedAdsCommandsApi(ClassifiedAdsApplicationService applicationService) => _applicationService = applicationService;
        [HttpPost]
        public async Task<IActionResult> Post(ClassifiedAds.V1.Create request)
        {
            await _applicationService.Handle(request);
            return Ok();
        }
        [Route("name")] [HttpPut] public async Task<IActionResult> Put(ClassifiedAds.V1.SetTitle request) { await _applicationService.Handle(request); return Ok(); }
        [Route("text")] [HttpPut] public async Task<IActionResult> Put(ClassifiedAds.V1.UpdateText request) { await _applicationService.Handle(request); return Ok(); }
        [Route("price")] [HttpPut] public async Task<IActionResult> Put(ClassifiedAds.V1.UpdatePrice request) { await _applicationService.Handle(request); return Ok(); }
        [Route("publish")] [HttpPut] public async Task<IActionResult> Put(ClassifiedAds.V1.RequestToPublish request) { await _applicationService.Handle(request); return Ok(); }
    }
}

using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediatrEventWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMediator _mediator;
        public IndexModel(ILogger<IndexModel> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator=mediator;
        }

        public void OnGet()
        {

        } 
        public  async Task<IActionResult> OnPost(int orderId, string userName)
        {
            await _mediator.Publish(new Events.OrderCreated.OrderCreatedNotification() { OrderId=orderId, UserName=userName });
            return Content("Notification Sent!!");
        }
    }
}
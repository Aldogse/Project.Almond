using Microsoft.AspNetCore.Mvc;
using Property_and_Supply_Management.Database;
using Property_and_Supply_Management.Interface;

namespace Property_and_Supply_Management.Controllers
{
	[ApiController]
	[Route("DisposedItems/v1/")]
	public class DisposedItemController : ControllerBase
	{
		private readonly PAS_DBContext _pAS_DBContext;
		private readonly IDisposedItemRepository _disposedItemRepository;

		public DisposedItemController(PAS_DBContext pAS_DBContext, IDisposedItemRepository disposedItemRepository)
		{
			_pAS_DBContext = pAS_DBContext;
			_disposedItemRepository = disposedItemRepository;
		}

		[HttpGet("get-all-disposed-items")]
		public async Task<IActionResult> GetAll()
		{
			try
			{
				var DisposedItems = await _disposedItemRepository.GetDisposedItemsAsync();

				if(DisposedItems == null)
				{
					return Ok("No Disposed Item listed");
				}

				return Ok(DisposedItems);
			}
			catch (Exception ex)
			{
				return StatusCode(500,$"Server error: {ex.Message}");
			}
		}
    }
}

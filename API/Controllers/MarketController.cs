using BAL.interfaces;
using DataAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarketController : ControllerBase
    {
        private readonly IStockRepository _stockRepository;

        public MarketController(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Stock>> GetStocks()
        {
            var stocks = _stockRepository.GetAllBind();
            return Ok(stocks);
        }
    }
}
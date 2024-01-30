using Microsoft.AspNetCore.SignalR;
using DataAccessLayer.Concrete;
using BusinessLayer.Abstract;
using System.Runtime.CompilerServices;

namespace Api.Hubs
{
	public class SignalRHub: Hub
	{
		private readonly ICategoryService _categoryService;

		private readonly IProductService _productService;

        private readonly IOrderService _orderService;

        private readonly ICashDeskService _cashDeskService;

        private readonly IRestTableService _restTableService;

        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, ICashDeskService cashDeskService, IRestTableService restTableService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _cashDeskService = cashDeskService;
            _restTableService = restTableService;
        }

        public async Task SendStatistics()
		{
			var value = _categoryService.TCategoryCount();
			await Clients.All.SendAsync("ReceiveCategoryCount", value);

			var value2 = _productService.TProductCount();
			await Clients.All.SendAsync("ReceiveProductCount", value2);

			var value3 = _categoryService.TActiveCategoryCount();
			await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

			var value4 = _categoryService.TPassiveCategoryCount();
			await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

			var value5 = _productService.TProductCountByCategoryNameHamburger();
			await Clients.All.SendAsync("ReceiveHamburgerCount", value5);


            var value6 = _productService.TProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveDrinkCount", value5);

            var value7 = _productService.TProductPriceAvg();
			await Clients.All.SendAsync("ReceivePriceAvg", value7.ToString("0.00") + "₺");

            var value8 = _productService.TProductNameByMaxPrice();
            await Clients.All.SendAsync("ReceiveMaxPrice", value8);

            var value9 = _productService.TProductNameByMinPrice();
            await Clients.All.SendAsync("ReceiveMinPrice", value9);

            var value10 = _productService.TAvgHamburgerPrice();
            await Clients.All.SendAsync("ReceiveAvgHamburger", value10.ToString("0.00") + "₺");

            var value11 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrder", value11);

            var value12 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrder", value12);

            var value13 = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrder", value13.ToString("0.00") + "₺");

            var value14 = _cashDeskService.TTotalCashDeskAmount();
            await Clients.All.SendAsync("ReceiveTotalAmount", value14.ToString("0.00") + "₺");


            var value16= _restTableService.TRestTableCount();
            await Clients.All.SendAsync("ReceiveTableCount", value16);


        }

        public async Task SendProgress()
        {
            var value = _cashDeskService.TTotalCashDeskAmount();
            await Clients.All.SendAsync("ReceiveCashDeskAmount", value.ToString("0.00") + "₺");

            var value2 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value2);

            var value3 = _restTableService.TRestTableCount();
            await Clients.All.SendAsync("ReceiveTableCount", value3);

        }



    }
}

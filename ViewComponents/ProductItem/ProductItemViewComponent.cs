using Microsoft.AspNetCore.Mvc;

namespace MvcEticaret.Component.ProductItem
{
    public class ProductItemViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(string title, int startCount, decimal oldPrice, decimal price, string imageUrl, bool isSale)
        {
            var model = new Models.ProductsItem
            {
                Title = title,
                StartCount = startCount,
                OldPrice = oldPrice,
                Price = price,
                ImageUrl = imageUrl,
                IsSale = isSale
            };

            return View(model); // 
        }
}    }

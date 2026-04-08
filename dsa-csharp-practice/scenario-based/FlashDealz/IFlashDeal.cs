using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.FlashDealz
{
    public interface IFlashDeal
    {
        void AddProduct(string name, double discount);
        void SortProducts();
        void DisplayDeals();
    }
}

using System.Collections.Generic;

namespace PromotionEngine_Mearsk
{
    public interface IProductServices
    {
        int GetTotalPrice(List<Products> products);
    }
}

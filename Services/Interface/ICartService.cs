using Repositories.Data.DTOs.CartProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICartService
    {
        Task<List<CartProductDTO>> GetCartProductsByUserIdAsync(string userId);
    }
}

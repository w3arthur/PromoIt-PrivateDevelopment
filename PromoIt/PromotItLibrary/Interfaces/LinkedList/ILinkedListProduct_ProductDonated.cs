﻿
using PromotItLibrary.Classes;
using PromotItLibrary.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PromotItLibrary.Interfaces.LinkedList
{
    public interface ILinkedListProduct_ProductDonated
    {
        Task<List<ProductDonated>> GetDonatedProductForShipping_ListAsync(Modes mode = null);
    }
}
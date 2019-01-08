﻿using ItemsReview.Models;
using Shared.Core.Utilities.Models;

namespace ItemsReview.Interfaces
{
    public interface IItemsReviewsManager
    {
        ResultMessage GetAll(int pageNo, int pageSize);
        ResultMessage Insert(ItemReviewDto item);
        ResultMessage GetById(int id);
        ResultMessage Update(ItemReviewDto item, int id);
        ResultMessage Delete(int id);
    }
}

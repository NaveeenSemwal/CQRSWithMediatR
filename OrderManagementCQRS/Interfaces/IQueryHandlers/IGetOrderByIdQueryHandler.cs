using OrderManagementCQRS.RequestModels.QueryRequestModels;
using OrderManagementCQRS.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagementCQRS.Interfaces.IQueryHandlers
{
    public interface IGetOrderByIdQueryHandler
    {
        GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel orderByIdRequestModel);
    }
}

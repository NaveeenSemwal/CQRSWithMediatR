using MediatR;
using OrderManagementCQRS.Interfaces.IQueryHandlers;
using OrderManagementCQRS.RequestModels.QueryRequestModels;
using OrderManagementCQRS.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderManagementCQRS.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequestModel, GetOrderByIdResponseModel>
    {
        public Task<GetOrderByIdResponseModel> Handle(GetOrderByIdRequestModel request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetOrderByIdResponseModel());
        }
    }
}

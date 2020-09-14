using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderManagementCQRS.Interfaces.ICommandHandlers;
using OrderManagementCQRS.RequestModels.CommandRequestModels;
using OrderManagementCQRS.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderManagementCQRS.Handlers.CommandHandlers
{
    public class MakeOrderCommandHandler : IRequestHandler<MakeOrderRequestModel, MakeOrderResponseModel>
    {
        public Task<MakeOrderResponseModel> Handle(MakeOrderRequestModel request, CancellationToken cancellationToken)
        {
            var response = new MakeOrderResponseModel { IsSuccess = true, OrderId = Guid.NewGuid() };

            return Task.FromResult(response);
        }


    }
}

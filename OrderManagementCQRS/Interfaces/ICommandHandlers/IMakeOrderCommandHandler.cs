using OrderManagementCQRS.RequestModels.CommandRequestModels;
using OrderManagementCQRS.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagementCQRS.Interfaces.ICommandHandlers
{
    public interface IMakeOrderCommandHandler
    {
        MakeOrderResponseModel MakeOrder(MakeOrderRequestModel orderRequestModel);
    }
}

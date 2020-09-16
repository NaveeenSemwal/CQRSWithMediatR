using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderManagementCQRS.Interfaces.ICommandHandlers;
using OrderManagementCQRS.Interfaces.IQueryHandlers;
using OrderManagementCQRS.RequestModels.CommandRequestModels;
using OrderManagementCQRS.RequestModels.QueryRequestModels;

namespace OrderManagementCQRS.Controllers
{
    /// <summary>
    /// https://medium.com/@letienthanh0212/cqrs-and-mediator-in-net-core-project-c0b477eab6e9
    /// 
    /// https://dev.azure.com/dotnetwindowsapp/CQRSWithMediatR/_git/CQRSWithMediatR
    /// </summary>


    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        //private readonly IMakeOrderCommandHandler _orderCommandHandler;
        //private readonly IGetOrderByIdQueryHandler _orderByIdQueryHandler;

        //public OrderController(IMakeOrderCommandHandler orderCommandHandler, IGetOrderByIdQueryHandler orderByIdQueryHandler)
        //{
        //    _orderCommandHandler = orderCommandHandler;
        //    _orderByIdQueryHandler = orderByIdQueryHandler;
        //}

        /// <summary>
        /// MediatR will maintain all the dependecies
        /// </summary>
        /// <param name="mediator"></param>
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("makeorder")]
        public IActionResult MakeOrder([FromBody] MakeOrderRequestModel orderRequestModel)
        {
            var response = _mediator.Send(orderRequestModel);
            return Ok(response);
        }

        [HttpGet("order")]
        public IActionResult OrderDetails([FromBody] GetOrderByIdRequestModel orderByIdRequestModel)
        {
            var response = _mediator.Send(orderByIdRequestModel);
            return Ok(response);
        }

    }
}

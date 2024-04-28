﻿using Basket.Application.Commands;
using Basket.Core.Interfaces;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.Handlers
{
    public class DeleteBasketByUserNameHandler : IRequestHandler<DeleteBasketByUserNameCommand>
    {


        private readonly IBasketRepository _basketRepository;

        public DeleteBasketByUserNameHandler(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        public async Task<Unit> Handle(DeleteBasketByUserNameCommand request, CancellationToken cancellationToken)
        {
            await _basketRepository.DeleteBasket(request.UserName);

            return Unit.Value;
        }
    }
}

﻿using AutoMapper;
using CasgemMicroService.Services.Order.Core.Application.Dtos.OrderDetailDto;
using CasgemMicroService.Services.Order.Core.Application.Features.CQRS.Commands;
using CasgemMicroService.Services.Order.Core.Application.Interfaces;
using CasgemMicroService.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommandRequest>
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly IMapper _mapper;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        public Task Handle(CreateOrderDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new OrderDetail
            {
                ProductID = request.ProductID,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductAmount = request.ProductAmount,
                OrderingID = request.OrderingID,
            };
            return _repository.CreateAsync(values);
        }
    }
}
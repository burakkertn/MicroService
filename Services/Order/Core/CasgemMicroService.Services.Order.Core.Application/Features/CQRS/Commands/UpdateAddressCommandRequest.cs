﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroService.Services.Order.Core.Application.Features.CQRS.Commands
{

    //MURAT YÜCEDAĞ YAZDI
    public class UpdateAddressCommandRequest : IRequest
    {
        public int AddressID { get; set; }

        public string UserID { get; set; }


        public string District { get; set; }

        public string City { get; set; }

        public string Detail { get; set; }
    }
}
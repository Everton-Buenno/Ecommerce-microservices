﻿using Amazon.Runtime.Internal;
using Catalog.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Queries
{
    public class GetProductByIdQuery(string id) : IRequest<ProductResponse>
    {
        public string Id { get; set; } = id;
    }
}

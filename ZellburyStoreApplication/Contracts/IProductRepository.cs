﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZellburyStoreApplication.Data;

namespace ZellburyStoreApplication.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
    }
}

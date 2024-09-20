using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZellburyStoreApplication.Data;
using ZellburyStoreApplication.Models;

namespace ZellburyStoreApplication.Mappings
{
    public class Maps : Profile
    {

        public Maps()
        {

            CreateMap<Customer, CustomerVM>().ReverseMap();
            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<PurchaseRecord, PurchaseRecordVM>().ReverseMap();

        }

    }
}

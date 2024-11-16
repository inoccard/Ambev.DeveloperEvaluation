﻿using Ambev.DeveloperEvaluation.Application.SaleAggregate;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

public class CreateSaleProfile : Profile
{
    public CreateSaleProfile()
    {
        CreateMap<CreateSaleRequest, CreateSaleCommand>().ReverseMap();
        CreateMap<CreateSaleResult, CreateSaleResponse>().ReverseMap();
    }
}
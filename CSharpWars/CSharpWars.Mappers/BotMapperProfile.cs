﻿using AutoMapper;
using CSharpWars.Orleans.Contracts.Bot;
using CSharpWars.WebApi.Contracts;

namespace CSharpWars.Mappers;

public class BotMapperProfile : Profile
{
    public BotMapperProfile()
    {
        CreateMap<CreateBotRequest, BotToCreateDto>();
        CreateMap<BotDto, CreateBotResponse>();
        CreateMap<List<BotDto>, GetAllActiveBotsResponse>()
            .ForMember(dest => dest.Bots, o => o.MapFrom(src => src));
        CreateMap<BotDto, Bot>();
    }
}
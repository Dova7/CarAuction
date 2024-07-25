using AutoMapper;
using CarAuctionApplication.Models.Main.Dtos.Auction;
using CarAuctionApplication.Models.Main.Dtos.AuctionItem;
using CarAuctionApplication.Models.Main.Dtos.AuctionItemAdditionalProperties;
using CarAuctionApplication.Models.Main.Dtos.AuctionItemImage;
using CarAuctionApplication.Models.Main.Dtos.CarAuction;
using CarAuctionApplication.Models.Main.Dtos.CarAuctionItem;
using CarAuctionApplication.Models.Main.Dtos.CarAuctionItemAdditionalProperties;
using CarAuctionApplication.Models.Main.Dtos.CarAuctionItemImage;
using CarAuctionDomain.Entities;
using CarAuctionEntities.Entities;

namespace CarAuctionApplication.Service.Mapper
{
    public class MappingProfile
    {
        public IMapper InitilizeAuction()
        {
            MapperConfiguration configuration = new(c =>
            {
                c.CreateMap<Auction, AuctionForGettingDtoAll>()               
                .ForMember(d => d.Make, o => o.MapFrom(s => s.AuctionItem.Make))
                .ForMember(d => d.Model, o => o.MapFrom(s => s.AuctionItem.Model))
                .ForMember(d => d.Year, o => o.MapFrom(s => s.AuctionItem.Year))
                .ForMember(d => d.MainImageUrl, o => o.MapFrom(s => s.AuctionItem.MainImageUrl))
                .ReverseMap();

                c.CreateMap<AuctionItemImage, AuctionItemImageForGettingDtoSingle>()
                .ReverseMap();

                c.CreateMap<AuctionItemAdditionalProperties, AuctionAddPropertiesForGettingDtoSingle>()
                .ReverseMap();

                c.CreateMap<AuctionItem, AuctioinItemForGettingDtoSingle>()
                .ForMember(d => d.Images, o => o.MapFrom(s => s.Images))
                .ForMember(d => d.AdditionalProperties, o => o.MapFrom(s => s.AdditionalProperties))
                .ReverseMap();

                c.CreateMap<Auction, AuctionForGettingDtoSingle>()
                .ForMember(d => d.AuctionItem, o => o.MapFrom(s => s.AuctionItem))
                .ReverseMap();


                c.CreateMap<Auction, AuctionForCreatingDto>()
                .ReverseMap();

                c.CreateMap<AuctionItem, AuctionItemForCreatingDto>()
                .ReverseMap();

                c.CreateMap<AuctionItemImage, AuctionItemImageForCreatingDto>()
                .ReverseMap();

                c.CreateMap<AuctionItemAdditionalProperties, AuctionItemPropertiesForCreatingDto>()
                .ReverseMap();

                c.CreateMap<Auction, AuctionForUpdatingDtoSeller>()
                .ReverseMap();

                c.CreateMap<AuctionItem, AuctionItemForUpdatingDto>()
                .ReverseMap();

                c.CreateMap<AuctionItemImage, AuctionItemImageForUpdatingDto>()
                .ReverseMap();

                c.CreateMap<AuctionItemAdditionalProperties, AuctionItemPropertiesForUpdatingDto>()
                .ReverseMap();
            });
            return configuration.CreateMapper();
        }
    }
}

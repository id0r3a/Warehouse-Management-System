using AutoMapper;
using Warehouse_Management_System.DTOs;
using Warehouse_Management_System.Models;

namespace Warehouse_Management_System.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mappar mellan Item och ItemDTO (båda håll)
            CreateMap<Item, ItemDTO>().ReverseMap();
        }
    }
}

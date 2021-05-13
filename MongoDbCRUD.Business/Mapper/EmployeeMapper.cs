using AutoMapper;
using MongoDbCRUD.Common.DomainModel;
using MongoDbCRUD.Common.RequestModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbCRUD.Business.Mapper
{
    public class EmployeeMapper : Profile
    {
        public EmployeeMapper()
        {
            CreateMap<EmployeeDto, Employee>().ForMember(desc => desc.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<AddressDto, Address>();
        }
    }
}

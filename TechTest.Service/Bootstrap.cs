using System.Linq;
using AutoMapper;
using Ninject;
using Ninject.Web.Common;
using TechTest.Domain.Dtos;
using TechTest.Domain.Entities;
using TechTest.Service.Contracts;
using TechTest.Service.Entities;

namespace TechTest.Service
{
    public static class Bootstrap
    {
        public static void Load(IKernel kernel)
        {
            kernel.Bind<IPersonService>().To<PersonService>().InRequestScope();
            kernel.Bind<IColourService>().To<ColourService>().InRequestScope();

            LoadAutoMapppings();

            Data.Bootstrap.Load(kernel);
        }

        public static void LoadAutoMapppings()
        {
            Mapper
                .CreateMap<Person, PersonDto>()
                .ForMember(p => p.Colours, x => x.MapFrom(p => p.Colours.OrderBy(c => c.Name)));

            Mapper.CreateMap<Colour, ColourDto>();
        }
    }
}

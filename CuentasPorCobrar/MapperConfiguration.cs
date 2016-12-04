using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasPorCobrar
{
    class MapperConfiguration
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Transaccion, TransacccionDTO>()
                .ForMember(dest => dest.Cliente, opt => opt.MapFrom(src => src.Cliente.Nombre))
                .ForMember(dest => dest.TipoDocumento, opt => opt.MapFrom(src => src.TipoDocumento.Descripcion))
                .ForMember(dest => dest.TipoMovimiento, opt => opt.MapFrom(src => src.TipoMovimiento.Descripcion));
            });

        }
    }
}

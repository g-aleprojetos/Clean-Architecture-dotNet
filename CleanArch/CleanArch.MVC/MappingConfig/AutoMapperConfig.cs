using CleanArch.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace CleanArch.MVC.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile),
                typeof(ViewModelToDomainMappingProfile));
        }
    }
}

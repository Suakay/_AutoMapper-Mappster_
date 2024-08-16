using _AutoMapper__.Models;
using AutoMapper;

namespace _AutoMapper__
{
    public class StudentProfile:Profile
    {
        public StudentProfile() => CreateMap<Student, StudentVM>()
            .ForMember(dest => dest.Yas, opt => opt.MapFrom(src => src.Age))
        .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Sinif.Name.ToLower()));

        //Formember üyeyi temsil eder.

    }
}

//Profile automapperın kendi klası.
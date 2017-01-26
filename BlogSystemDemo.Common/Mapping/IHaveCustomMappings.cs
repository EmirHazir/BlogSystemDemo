namespace BlogSystemDemo.Common.Mapping
{
    using AutoMapper;

    public interface IHaveCustomMappings
    {
        void CreateMappings(MapperConfiguration configuration);
    }
}

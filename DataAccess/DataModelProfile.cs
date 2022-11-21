using AutoMapper;
using DataAccess.Models;

namespace DataAccess
{
    public class DataModelProfile: Profile
    {
        public DataModelProfile()
        {
            CreateMap<DataModel, DataViewModel>()
                .ReverseMap();
            CreateMap<History, HistoryViewModel>()
                .ReverseMap();
        }
    }
}

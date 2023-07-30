using Web_API.Models;
using Web_API.Models.Dto;

namespace Web_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> 
        {
             new VillaDTO{Id=1,Name="Akshay"},
             new VillaDTO{Id=2,Name="Sanket"}
        };
    }
}

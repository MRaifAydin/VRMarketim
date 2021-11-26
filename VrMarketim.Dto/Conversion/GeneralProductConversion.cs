using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMarketim.Dto.Dto;
using VrMarketim.Entities;

namespace VrMarketim.Dto.Conversion
{
    public class GeneralProductConversion
    {
        public static GeneralProduct ToEntity(GeneralProductDto generalProduct)
        {
            return new GeneralProduct
            {
                Id = generalProduct.Id,
                Name = generalProduct.Name,
                Volume = generalProduct.Volume,
                Pcs = generalProduct.Pcs,
                Description = generalProduct.Description,
            };
        }

        public static GeneralProductDto ToApi(GeneralProduct generalProduct)
        {
            return new GeneralProductDto
            {
                Id = generalProduct.Id,
                Name = generalProduct.Name,
                Volume = generalProduct.Volume,
                Pcs = generalProduct.Pcs,
                Description = generalProduct.Description,
            };
        }
    }
}

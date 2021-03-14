using System;
using Forgebase.Masterdata.Core.Entities.Material;

namespace Forgebase.Masterdata.Core.Interfaces.Material
{
    public interface IColorCodeRepository: IAsyncRepository<ColorCode, int>
    {
    }
}

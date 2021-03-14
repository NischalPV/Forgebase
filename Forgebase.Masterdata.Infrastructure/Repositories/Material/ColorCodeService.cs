using System;
using Forgebase.Masterdata.Core.Entities.Material;
using Forgebase.Masterdata.Core.Interfaces.Material;
using Forgebase.Masterdata.Infrastructure.Data;
using Microsoft.Extensions.Logging;

namespace Forgebase.Masterdata.Infrastructure.Repositories.Material
{
    public class ColorCodeService: EfRepository<ColorCode, int>, IColorCodeRepository
    {
        private readonly ForgebaseMasterdataDbContext _context;
        private readonly ILogger<ColorCodeService> _logger;

        public ColorCodeService(ForgebaseMasterdataDbContext dbContext, ILogger<ColorCodeService> logger): base(dbContext, logger)
        {
            _context = dbContext;
            _logger = logger;
        }
    }
}

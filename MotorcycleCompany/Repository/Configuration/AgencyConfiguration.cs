using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class AgencyConfiguration : IEntityTypeConfiguration<Agency>
    {
        public void Configure(EntityTypeBuilder<Agency> builder)
        {
            builder.HasData(
                new Agency
                {
                    AgencyId = Guid.NewGuid(),
                    Name = "Agencia01",
                    Address = "Calle del recuerdo",
                    Population = "Santa Barbara"
                    
                },
                new Agency
                {
                    AgencyId = Guid.NewGuid(),
                    Name = "Agencia02",
                    Address = "Calle del futuro",
                    Population = "Santa Ana"
                });
        }
    }
}

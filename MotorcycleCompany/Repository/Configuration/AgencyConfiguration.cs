using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Repository.Configuration
{
    public class AgencyConfiguration : IEntityTypeConfiguration<Agency>
    {
        public void Configure(EntityTypeBuilder<Agency> builder)
        {
            builder.HasData(new Agency
            {
                AgencyId = 1,
                Name = "Agenciao1",
                Address = "calle del recuerdo",
                Population = "Santa barbara"
            },
            new Agency
            {

                AgencyId = 2,
                Name = "Agenciao2",
                Address = "calle del suicidio",
                Population = "Santana"
            });
        }
    }
}

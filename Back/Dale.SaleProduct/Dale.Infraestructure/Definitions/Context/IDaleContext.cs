using System;
using System.Collections.Generic;
using System.Text;
using Dale.Domain;
using Microsoft.EntityFrameworkCore;

namespace Dale.Infraestructure.Definitions.Context
{
    public interface IDaleContext 
    {
        DbSet<Client> Clients { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Bill> Bills { get; set; }
        DbSet<BillDetail> BillDetails { get; set; }
    }
}

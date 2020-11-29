using DigitalMarketing.Model.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalMarketing.Model
{
    public class DatabaseRepository
    {
        public async Task<Tenant> GetTenantAsync(string label)
        {
            Tenant tenant=null;

            using (DigitalMarketingContext dataContext = new DigitalMarketingContext())
            {
                tenant = dataContext.Tenant.Include(t => t.TenantConfiguration)
                                               .ThenInclude(tc => tc.File)
                                               .ToList().FirstOrDefault(t => t.Label.Equals(label));
            }
            return tenant;
        }

        public async Task SaveCustomer(Customer customer)
        {
            using DigitalMarketingContext dataContext = new DigitalMarketingContext();

            var customerDb = dataContext.Customer.Where(c => c.Email.Equals(customer.Email) &&
                                                             c.TenantId.Equals(customer.TenantId)).FirstOrDefault();

            if (customerDb == null)
            {
                customer.Id = Guid.NewGuid();
                dataContext.Customer.Add(customer);
                await dataContext.SaveChangesAsync();
            }
            else
            {
                customer.Id = customerDb.Id;
            }
        }

        public async Task SaveTouchpoint(Touchpoint newEvent)
        {
            using DigitalMarketingContext dataContext = new DigitalMarketingContext();
            newEvent.Date = DateTime.UtcNow;
            dataContext.Touchpoint.Add(newEvent);
            await dataContext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetProductsAsync(Guid tenantId)
        {
            using DigitalMarketingContext dataContext = new DigitalMarketingContext();
            return await dataContext.Product.Where(p => p.TenantId.Equals(tenantId)).ToListAsync();
        }
    }
}

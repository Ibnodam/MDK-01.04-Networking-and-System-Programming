using Microsoft.EntityFrameworkCore;

namespace Rest_Api.Models
{
    public static class DataSeeder
    {
        public static void SeedData(OrdersContext context)
        {
            context.Database.Migrate();
            if (context.Products.Count() == 0 && context.Orders.Count() == 0)
            { 
                
            
            
            
            }

        }


    }
}

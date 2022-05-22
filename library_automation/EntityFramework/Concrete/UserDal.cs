using library_automation.Entities.Concrete;
using library_automation.EntityFramework.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace library_automation.EntityFramework.Concrete
{
    public class UserDal : IEntityRepository<User>
    {
        public void Add(User Entity)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                //context.Products.Add(product);
                var entity = context.Entry(Entity);
                entity.State = EntityState.Added;
                context.SaveChanges(); // we say to db write
            }
        }

        public void Delete(User Entity)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                var entity = context.Entry(Entity);
                entity.State = EntityState.Deleted;
                context.SaveChanges(); // we say to db write
            }
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                return context.Set<User>().SingleOrDefault(filter);
            }
        }

        public List<User> GetList(Expression<Func<User, bool>> filter = null)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                return filter == null ? context.Users.ToList() : context.Users.Where(filter).ToList();
            }
        }

        public void Update(User Entity)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                var entity = context.Entry(Entity);
                entity.State = EntityState.Modified;
                context.SaveChanges(); // we say to db write
            }
        }
    }
}

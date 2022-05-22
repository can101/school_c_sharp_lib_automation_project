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
    public class DepositDal : IEntityRepository<Deposit>
    {
        public void Add(Deposit Entity)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                var entity = context.Entry(Entity);
                entity.State = EntityState.Added;
                context.SaveChanges(); // we say to db write
            }
        }

        public void Delete(Deposit Entity)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                var entity = context.Entry(Entity);
                entity.State = EntityState.Deleted;
                context.SaveChanges(); // we say to db write
            }
        }

        public Deposit Get(Expression<Func<Deposit, bool>> filter)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                return context.Set<Deposit>().SingleOrDefault(filter);
            }
        }

        public List<Deposit> GetList(Expression<Func<Deposit, bool>> filter = null)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                return filter == null ? context.Deposits.ToList() : context.Deposits.Where(filter).ToList();
            }
        }

        public void Update(Deposit Entity)
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

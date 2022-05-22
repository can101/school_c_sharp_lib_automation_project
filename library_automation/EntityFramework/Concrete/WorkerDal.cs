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
    public class WorkerDal : IEntityRepository<Worker>
    {
        public void Add(Worker Entity)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                var entity = context.Entry(Entity);
                entity.State = EntityState.Added;
                context.SaveChanges(); // we say to db write
            }
        }

        public void Delete(Worker Entity)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                var entity = context.Entry(Entity);
                entity.State = EntityState.Deleted;
                context.SaveChanges(); // we say to db write
            }
        }

        public Worker Get(Expression<Func<Worker, bool>> filter)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                return context.Set<Worker>().SingleOrDefault(filter);
            }
        }

        public List<Worker> GetList(Expression<Func<Worker, bool>> filter = null)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                return filter==null?context.Workers.ToList(): context.Workers.Where(filter).ToList();
            }
        }

            public void Update(Worker Entity)
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

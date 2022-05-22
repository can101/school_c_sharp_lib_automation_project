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
    public class BookDal : IEntityRepository<Book>
    {
        public void Add(Book Entity)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                var entity = context.Entry(Entity);
                entity.State = EntityState.Added;
                context.SaveChanges(); // we say to db write
            }
        }

        public void Delete(Book Entity)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                var entity = context.Entry(Entity);
                entity.State = EntityState.Deleted;
                context.SaveChanges(); // we say to db write
            }
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                return context.Set<Book>().SingleOrDefault(filter);
            }
        }

        public List<Book> GetList(Expression<Func<Book, bool>> filter = null)
        {
            using (LibraryAutomationContext context = new LibraryAutomationContext())//ETradeContext very expensive thing
            {
                return filter == null ? context.Books.ToList() : context.Books.Where(filter).ToList();
            }
        }

        public void Update(Book Entity)
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

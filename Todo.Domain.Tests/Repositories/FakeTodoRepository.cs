using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Enttities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {            
        }

        public TodoItem GetById(Guid id, string email)
        {
            return new TodoItem("titulo aqui", DateTime.Now, "Vitor Paholsky");
        }

        public void Update(TodoItem todo)
        {            
        }
    }
}

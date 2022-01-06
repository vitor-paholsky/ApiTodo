using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Enttities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueriesTests
    {
        private List<TodoItem> _items;

        public TodoQueriesTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "usuarioB"));
            _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "Vitor"));
            _items.Add(new TodoItem("Tarefa 4", DateTime.Now, "usuarioD"));
            _items.Add(new TodoItem("Tarefa 5", DateTime.Now, "Vitor"));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_VitorPaholsky()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("Vitor"));
            Assert.AreEqual(2, result.Count());
        }
    }
}

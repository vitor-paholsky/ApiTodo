using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Commands;
using Todo.Domain.Enttities;
using Todo.Domain.Handlers;
using Todo.Domain.Repositories;

namespace Todo.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<TodoItem> GetAll(
            [FromServices]ITodoRepository repository
        )
        {
            return repository.GetAll("VitorPaholsky");
        }

        [Route("done")]
        [HttpGet]
        public IEnumerable<TodoItem> GetAllDone(
            [FromServices]ITodoRepository repository
            )
        {           
            return repository.GetAllDone("VitorPaholsky");
        }

        [Route("undone")]
        [HttpGet]
        public IEnumerable<TodoItem> GetAllUndone(
           [FromServices] ITodoRepository repository
           )
        {
            return repository.GetByPeriod(
                "VitorPaholsky",
                DateTime.Now.Date,
                false
             );
        }

        [Route("done/today")]
        [HttpGet]
        public IEnumerable<TodoItem> GetDoneForToday(
           [FromServices] ITodoRepository repository
           )
        {
            return repository.GetByPeriod(
                "VitorPaholsky",
                DateTime.Now.Date,
                true
             );
        }

        [Route("done/tomorrow")]
        [HttpGet]
        public IEnumerable<TodoItem> GetDoneForTomorrow(
          [FromServices] ITodoRepository repository
          )
        {
            return repository.GetByPeriod(
                "VitorPaholsky",
                DateTime.Now.Date.AddDays(1),
                true
             );
        }

        [Route("undone/tomorrow")]
        [HttpGet]
        public IEnumerable<TodoItem> GetUndoneForTomorrow(
          [FromServices] ITodoRepository repository
          )
        {
            return repository.GetByPeriod(
                "VitorPaholsky",
                DateTime.Now.Date.AddDays(1),
                false
             );
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody]CreateTodoCommand command,
            [FromServices]TodoHandler handler
            )
        {
            command.User = "VitorPaholsky";
            handler.Handle(command);
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("")]
        [HttpPut]
        public GenericCommandResult Update(
           [FromBody] UpdateTodoCommand command,
           [FromServices] TodoHandler handler
           )
        {
            command.User = "VitorPaholsky";
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("mark-as-done")]
        [HttpPut]
        public GenericCommandResult MarkAsDone(
           [FromBody] MarkTodoAsDoneCommand command,
           [FromServices] TodoHandler handler
           )
        {
            command.User = "VitorPaholsky";
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("mark-as-undone")]
        [HttpPut]
        public GenericCommandResult MarkAsUndone(
          [FromBody] MarkTodoAsUndoneCommand command,
          [FromServices] TodoHandler handler
          )
        {
            command.User = "VitorPaholsky";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests;

[TestClass]
    public class MarkTodoAsDoneCommandTests
    {    
        private readonly MarkTodoAsDoneCommand _invalidCommand = new MarkTodoAsDoneCommand(default(Guid), "vitor paholsky");

        public MarkTodoAsDoneCommandTests()
        {
            _invalidCommand.Validate();
        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_invalidCommand.Valid, true);
        }
}

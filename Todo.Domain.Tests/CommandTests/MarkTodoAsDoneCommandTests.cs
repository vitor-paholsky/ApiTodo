using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests;

[TestClass]
    public class MarkTodoAsDoneCommandTests
    {    
        private readonly MarkTodoAsDoneCommand _validCommand = new MarkTodoAsDoneCommand(default(Guid), "vitor paholsky");
        private readonly MarkTodoAsDoneCommand _invalidCommand = new MarkTodoAsDoneCommand(default(Guid), "");

    public MarkTodoAsDoneCommandTests()
        {
            _invalidCommand.Validate();
        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }
}

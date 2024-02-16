using ToDoListClassLibrary;
namespace ToDoListUnitTests
{
    [TestClass]
    public class ToDoListUnitTest
    {
        ToDoItem? toDoItem;

        [TestInitialize]
        public void TestInitialize()
        {
            toDoItem =new ToDoListClassLibrary.ToDoItem();
        }


        [TestMethod]
        public void ToDoItem_Initialization_Success()
        {

            Assert.IsNotNull(toDoItem);
        }

        [TestMethod]
        public void ToDoItem_SetDueDate_Success()
        {
            var dueDate = DateTime.Now.AddDays(7);

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            toDoItem.DueDate = dueDate;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            Assert.AreEqual(dueDate, toDoItem.DueDate);
        }

        [TestMethod]
        public void ToDoItem_SetCompletedDate_Success()
        {
            var completedDate = DateTime.Now;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            toDoItem.CompletedDate = completedDate;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            Assert.AreEqual(completedDate, toDoItem.CompletedDate);
        }

        [TestMethod]
        public void ToDoItem_SetDescription_Success()
        {
            var description = "Sample description";

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            toDoItem.Description = description;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            Assert.AreEqual(description, toDoItem.Description);
        }
    }
}

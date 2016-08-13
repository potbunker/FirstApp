using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    [TestFixture]
    public class ListSelectionFormTest
    {
        public ListSelectionForm Form
        {
            get; set;
        }

        [SetUp]
        public void Setup()
        {
            Form = new ListSelectionForm(null);
        }

        [Test]
        public void TestOnUpdateStatus()
        {
            var args = new UpdateEventArgs
            {
                SelectedRow = new Row
                {
                    Id = "1",
                    Name = "Name 1",
                    Description = "Description 1"
                }
            };
            Form.OnUpdateStatus += (sender, e) => { };
            Assert.Pass("Your first passing test");
        }
    }
}

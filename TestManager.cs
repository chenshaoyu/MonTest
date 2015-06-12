using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonTest
{
    public class TestManager
    {
        bool isInTest = false;

        private LinkedList<BaseTest> testList = new LinkedList<BaseTest>();
        private LinkedListNode<BaseTest> currentTest = null;

        public void AddTest(BaseTest t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("Cannot add an empty test!");
            }

            testList.AddLast(t);
        }

        public void Initialize()
        {
            testList.Clear();
        }

        public void StartTest()
        {
            if (!isInTest && testList.Count > 0)
            {
                currentTest = testList.First;
                RenderTest();
            }
        }

        public void NextTest()
        {
            if (currentTest.Next == null)
            {
                currentTest = testList.First;
            }
            else
            {
                currentTest = currentTest.Next;
            }
        }

        public void RenderTest()
        {
            if (currentTest != null)
            {
                currentTest.Value.RenderTest();
            }
        }
    }
}

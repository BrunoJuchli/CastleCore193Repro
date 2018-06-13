using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test641
    {
        private readonly Mock<IClass641> aClass;

        public Test641()
        {
            this.aClass = new Mock<IClass641>();
        }

        public void DoSomething()
        {
            try
            {
                this.aClass.Setup(x => x.DoSomething()).Returns(true);
                bool result = this.aClass.Object.DoSomething();
            }
            catch (BadImageFormatException)
            {
                Debugger.Launch();
            }
        }
    }
}

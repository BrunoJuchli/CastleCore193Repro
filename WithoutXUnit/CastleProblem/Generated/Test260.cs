using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test260
    {
        private readonly Mock<IClass260> aClass;

        public Test260()
        {
            this.aClass = new Mock<IClass260>();
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

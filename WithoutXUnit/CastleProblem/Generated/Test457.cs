using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test457
    {
        private readonly Mock<IClass457> aClass;

        public Test457()
        {
            this.aClass = new Mock<IClass457>();
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

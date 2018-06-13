using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test422
    {
        private readonly Mock<IClass422> aClass;

        public Test422()
        {
            this.aClass = new Mock<IClass422>();
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

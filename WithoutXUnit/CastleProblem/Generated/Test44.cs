using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test44
    {
        private readonly Mock<IClass44> aClass;

        public Test44()
        {
            this.aClass = new Mock<IClass44>();
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

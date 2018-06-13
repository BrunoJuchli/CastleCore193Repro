using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test1000
    {
        private readonly Mock<IClass1000> aClass;

        public Test1000()
        {
            this.aClass = new Mock<IClass1000>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test12
    {
        private readonly Mock<IClass12> aClass;

        public Test12()
        {
            this.aClass = new Mock<IClass12>();
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

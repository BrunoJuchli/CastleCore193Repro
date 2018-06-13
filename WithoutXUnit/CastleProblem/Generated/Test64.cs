using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test64
    {
        private readonly Mock<IClass64> aClass;

        public Test64()
        {
            this.aClass = new Mock<IClass64>();
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

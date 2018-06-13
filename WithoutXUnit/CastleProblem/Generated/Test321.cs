using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test321
    {
        private readonly Mock<IClass321> aClass;

        public Test321()
        {
            this.aClass = new Mock<IClass321>();
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

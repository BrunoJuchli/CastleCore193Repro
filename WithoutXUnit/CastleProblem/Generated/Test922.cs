using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test922
    {
        private readonly Mock<IClass922> aClass;

        public Test922()
        {
            this.aClass = new Mock<IClass922>();
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

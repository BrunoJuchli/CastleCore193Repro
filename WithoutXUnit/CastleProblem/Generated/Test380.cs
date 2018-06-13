using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test380
    {
        private readonly Mock<IClass380> aClass;

        public Test380()
        {
            this.aClass = new Mock<IClass380>();
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

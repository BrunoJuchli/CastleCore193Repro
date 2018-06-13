using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test725
    {
        private readonly Mock<IClass725> aClass;

        public Test725()
        {
            this.aClass = new Mock<IClass725>();
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

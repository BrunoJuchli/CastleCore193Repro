using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test222
    {
        private readonly Mock<IClass222> aClass;

        public Test222()
        {
            this.aClass = new Mock<IClass222>();
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

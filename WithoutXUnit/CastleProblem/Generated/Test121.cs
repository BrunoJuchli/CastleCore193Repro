using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test121
    {
        private readonly Mock<IClass121> aClass;

        public Test121()
        {
            this.aClass = new Mock<IClass121>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test404
    {
        private readonly Mock<IClass404> aClass;

        public Test404()
        {
            this.aClass = new Mock<IClass404>();
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

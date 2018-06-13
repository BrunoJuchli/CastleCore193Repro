using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test477
    {
        private readonly Mock<IClass477> aClass;

        public Test477()
        {
            this.aClass = new Mock<IClass477>();
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

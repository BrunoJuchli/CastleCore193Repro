using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test867
    {
        private readonly Mock<IClass867> aClass;

        public Test867()
        {
            this.aClass = new Mock<IClass867>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test320
    {
        private readonly Mock<IClass320> aClass;

        public Test320()
        {
            this.aClass = new Mock<IClass320>();
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

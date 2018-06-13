using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test588
    {
        private readonly Mock<IClass588> aClass;

        public Test588()
        {
            this.aClass = new Mock<IClass588>();
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

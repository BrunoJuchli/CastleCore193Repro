using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test328
    {
        private readonly Mock<IClass328> aClass;

        public Test328()
        {
            this.aClass = new Mock<IClass328>();
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

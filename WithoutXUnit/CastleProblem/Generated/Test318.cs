using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test318
    {
        private readonly Mock<IClass318> aClass;

        public Test318()
        {
            this.aClass = new Mock<IClass318>();
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

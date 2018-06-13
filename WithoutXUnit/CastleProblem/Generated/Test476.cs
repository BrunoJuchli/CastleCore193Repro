using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test476
    {
        private readonly Mock<IClass476> aClass;

        public Test476()
        {
            this.aClass = new Mock<IClass476>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test705
    {
        private readonly Mock<IClass705> aClass;

        public Test705()
        {
            this.aClass = new Mock<IClass705>();
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

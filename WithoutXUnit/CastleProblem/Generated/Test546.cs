using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test546
    {
        private readonly Mock<IClass546> aClass;

        public Test546()
        {
            this.aClass = new Mock<IClass546>();
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

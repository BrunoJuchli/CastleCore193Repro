using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test308
    {
        private readonly Mock<IClass308> aClass;

        public Test308()
        {
            this.aClass = new Mock<IClass308>();
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

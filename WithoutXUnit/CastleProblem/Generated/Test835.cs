using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test835
    {
        private readonly Mock<IClass835> aClass;

        public Test835()
        {
            this.aClass = new Mock<IClass835>();
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

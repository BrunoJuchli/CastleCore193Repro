using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test235
    {
        private readonly Mock<IClass235> aClass;

        public Test235()
        {
            this.aClass = new Mock<IClass235>();
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

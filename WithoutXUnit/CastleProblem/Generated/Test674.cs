using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test674
    {
        private readonly Mock<IClass674> aClass;

        public Test674()
        {
            this.aClass = new Mock<IClass674>();
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

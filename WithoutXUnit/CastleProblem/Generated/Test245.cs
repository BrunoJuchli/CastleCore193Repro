using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test245
    {
        private readonly Mock<IClass245> aClass;

        public Test245()
        {
            this.aClass = new Mock<IClass245>();
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

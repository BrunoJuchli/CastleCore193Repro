using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test33
    {
        private readonly Mock<IClass33> aClass;

        public Test33()
        {
            this.aClass = new Mock<IClass33>();
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

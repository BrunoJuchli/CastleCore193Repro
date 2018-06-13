using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test990
    {
        private readonly Mock<IClass990> aClass;

        public Test990()
        {
            this.aClass = new Mock<IClass990>();
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

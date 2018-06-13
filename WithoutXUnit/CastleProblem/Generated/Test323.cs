using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test323
    {
        private readonly Mock<IClass323> aClass;

        public Test323()
        {
            this.aClass = new Mock<IClass323>();
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

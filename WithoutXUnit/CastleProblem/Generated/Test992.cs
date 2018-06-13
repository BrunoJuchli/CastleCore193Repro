using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test992
    {
        private readonly Mock<IClass992> aClass;

        public Test992()
        {
            this.aClass = new Mock<IClass992>();
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

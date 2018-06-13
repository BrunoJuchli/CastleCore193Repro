using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test16
    {
        private readonly Mock<IClass16> aClass;

        public Test16()
        {
            this.aClass = new Mock<IClass16>();
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

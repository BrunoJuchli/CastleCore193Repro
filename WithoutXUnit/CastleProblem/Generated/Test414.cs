using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test414
    {
        private readonly Mock<IClass414> aClass;

        public Test414()
        {
            this.aClass = new Mock<IClass414>();
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

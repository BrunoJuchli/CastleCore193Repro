using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test944
    {
        private readonly Mock<IClass944> aClass;

        public Test944()
        {
            this.aClass = new Mock<IClass944>();
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

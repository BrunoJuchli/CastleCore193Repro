using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test826
    {
        private readonly Mock<IClass826> aClass;

        public Test826()
        {
            this.aClass = new Mock<IClass826>();
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

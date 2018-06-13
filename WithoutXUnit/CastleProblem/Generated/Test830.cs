using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test830
    {
        private readonly Mock<IClass830> aClass;

        public Test830()
        {
            this.aClass = new Mock<IClass830>();
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

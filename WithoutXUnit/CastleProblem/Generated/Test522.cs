using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test522
    {
        private readonly Mock<IClass522> aClass;

        public Test522()
        {
            this.aClass = new Mock<IClass522>();
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

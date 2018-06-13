using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test29
    {
        private readonly Mock<IClass29> aClass;

        public Test29()
        {
            this.aClass = new Mock<IClass29>();
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

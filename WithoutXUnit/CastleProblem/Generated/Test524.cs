using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test524
    {
        private readonly Mock<IClass524> aClass;

        public Test524()
        {
            this.aClass = new Mock<IClass524>();
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

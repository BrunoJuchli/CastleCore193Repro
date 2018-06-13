using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test54
    {
        private readonly Mock<IClass54> aClass;

        public Test54()
        {
            this.aClass = new Mock<IClass54>();
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

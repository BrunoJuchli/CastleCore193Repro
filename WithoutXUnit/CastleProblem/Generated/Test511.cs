using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test511
    {
        private readonly Mock<IClass511> aClass;

        public Test511()
        {
            this.aClass = new Mock<IClass511>();
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

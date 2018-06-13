using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test418
    {
        private readonly Mock<IClass418> aClass;

        public Test418()
        {
            this.aClass = new Mock<IClass418>();
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

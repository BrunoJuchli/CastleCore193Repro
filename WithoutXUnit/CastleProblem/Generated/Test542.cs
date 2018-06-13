using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test542
    {
        private readonly Mock<IClass542> aClass;

        public Test542()
        {
            this.aClass = new Mock<IClass542>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test496
    {
        private readonly Mock<IClass496> aClass;

        public Test496()
        {
            this.aClass = new Mock<IClass496>();
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

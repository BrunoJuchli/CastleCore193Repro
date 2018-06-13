using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test894
    {
        private readonly Mock<IClass894> aClass;

        public Test894()
        {
            this.aClass = new Mock<IClass894>();
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

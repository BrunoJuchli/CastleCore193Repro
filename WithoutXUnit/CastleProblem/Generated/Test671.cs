using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test671
    {
        private readonly Mock<IClass671> aClass;

        public Test671()
        {
            this.aClass = new Mock<IClass671>();
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

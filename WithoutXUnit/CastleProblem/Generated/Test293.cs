using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test293
    {
        private readonly Mock<IClass293> aClass;

        public Test293()
        {
            this.aClass = new Mock<IClass293>();
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

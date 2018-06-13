using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test842
    {
        private readonly Mock<IClass842> aClass;

        public Test842()
        {
            this.aClass = new Mock<IClass842>();
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

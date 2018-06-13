using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test364
    {
        private readonly Mock<IClass364> aClass;

        public Test364()
        {
            this.aClass = new Mock<IClass364>();
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

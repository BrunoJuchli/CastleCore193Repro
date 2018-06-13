using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test836
    {
        private readonly Mock<IClass836> aClass;

        public Test836()
        {
            this.aClass = new Mock<IClass836>();
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

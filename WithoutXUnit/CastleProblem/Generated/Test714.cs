using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test714
    {
        private readonly Mock<IClass714> aClass;

        public Test714()
        {
            this.aClass = new Mock<IClass714>();
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

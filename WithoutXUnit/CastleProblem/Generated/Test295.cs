using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test295
    {
        private readonly Mock<IClass295> aClass;

        public Test295()
        {
            this.aClass = new Mock<IClass295>();
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

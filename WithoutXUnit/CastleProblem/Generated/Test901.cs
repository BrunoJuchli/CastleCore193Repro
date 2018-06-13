using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test901
    {
        private readonly Mock<IClass901> aClass;

        public Test901()
        {
            this.aClass = new Mock<IClass901>();
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

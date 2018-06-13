using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test448
    {
        private readonly Mock<IClass448> aClass;

        public Test448()
        {
            this.aClass = new Mock<IClass448>();
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

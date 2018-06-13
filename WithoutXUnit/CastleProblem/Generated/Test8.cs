using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test8
    {
        private readonly Mock<IClass8> aClass;

        public Test8()
        {
            this.aClass = new Mock<IClass8>();
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

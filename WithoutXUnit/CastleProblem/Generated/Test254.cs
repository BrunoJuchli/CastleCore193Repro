using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test254
    {
        private readonly Mock<IClass254> aClass;

        public Test254()
        {
            this.aClass = new Mock<IClass254>();
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

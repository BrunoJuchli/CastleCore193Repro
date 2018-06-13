using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test468
    {
        private readonly Mock<IClass468> aClass;

        public Test468()
        {
            this.aClass = new Mock<IClass468>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test502
    {
        private readonly Mock<IClass502> aClass;

        public Test502()
        {
            this.aClass = new Mock<IClass502>();
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

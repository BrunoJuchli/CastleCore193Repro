using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test855
    {
        private readonly Mock<IClass855> aClass;

        public Test855()
        {
            this.aClass = new Mock<IClass855>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test281
    {
        private readonly Mock<IClass281> aClass;

        public Test281()
        {
            this.aClass = new Mock<IClass281>();
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

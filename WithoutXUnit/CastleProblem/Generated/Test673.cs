using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test673
    {
        private readonly Mock<IClass673> aClass;

        public Test673()
        {
            this.aClass = new Mock<IClass673>();
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

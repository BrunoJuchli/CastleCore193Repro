using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test798
    {
        private readonly Mock<IClass798> aClass;

        public Test798()
        {
            this.aClass = new Mock<IClass798>();
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

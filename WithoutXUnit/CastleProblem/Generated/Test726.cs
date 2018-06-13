using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test726
    {
        private readonly Mock<IClass726> aClass;

        public Test726()
        {
            this.aClass = new Mock<IClass726>();
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

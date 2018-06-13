using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test561
    {
        private readonly Mock<IClass561> aClass;

        public Test561()
        {
            this.aClass = new Mock<IClass561>();
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

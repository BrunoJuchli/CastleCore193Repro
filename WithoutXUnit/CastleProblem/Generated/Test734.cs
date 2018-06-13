using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test734
    {
        private readonly Mock<IClass734> aClass;

        public Test734()
        {
            this.aClass = new Mock<IClass734>();
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

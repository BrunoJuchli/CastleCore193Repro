using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test114
    {
        private readonly Mock<IClass114> aClass;

        public Test114()
        {
            this.aClass = new Mock<IClass114>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test75
    {
        private readonly Mock<IClass75> aClass;

        public Test75()
        {
            this.aClass = new Mock<IClass75>();
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

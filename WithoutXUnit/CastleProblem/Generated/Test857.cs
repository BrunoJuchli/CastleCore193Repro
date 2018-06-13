using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test857
    {
        private readonly Mock<IClass857> aClass;

        public Test857()
        {
            this.aClass = new Mock<IClass857>();
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

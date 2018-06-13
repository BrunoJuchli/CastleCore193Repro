using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test82
    {
        private readonly Mock<IClass82> aClass;

        public Test82()
        {
            this.aClass = new Mock<IClass82>();
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

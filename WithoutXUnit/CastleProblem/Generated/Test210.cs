using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test210
    {
        private readonly Mock<IClass210> aClass;

        public Test210()
        {
            this.aClass = new Mock<IClass210>();
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

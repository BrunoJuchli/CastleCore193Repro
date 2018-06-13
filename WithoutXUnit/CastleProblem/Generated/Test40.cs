using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test40
    {
        private readonly Mock<IClass40> aClass;

        public Test40()
        {
            this.aClass = new Mock<IClass40>();
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

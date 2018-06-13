using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test689
    {
        private readonly Mock<IClass689> aClass;

        public Test689()
        {
            this.aClass = new Mock<IClass689>();
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

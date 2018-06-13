using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test39
    {
        private readonly Mock<IClass39> aClass;

        public Test39()
        {
            this.aClass = new Mock<IClass39>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test238
    {
        private readonly Mock<IClass238> aClass;

        public Test238()
        {
            this.aClass = new Mock<IClass238>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test878
    {
        private readonly Mock<IClass878> aClass;

        public Test878()
        {
            this.aClass = new Mock<IClass878>();
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

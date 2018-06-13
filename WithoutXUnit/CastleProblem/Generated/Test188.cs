using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test188
    {
        private readonly Mock<IClass188> aClass;

        public Test188()
        {
            this.aClass = new Mock<IClass188>();
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

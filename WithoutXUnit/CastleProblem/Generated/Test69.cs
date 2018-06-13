using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test69
    {
        private readonly Mock<IClass69> aClass;

        public Test69()
        {
            this.aClass = new Mock<IClass69>();
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

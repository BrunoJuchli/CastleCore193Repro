using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test603
    {
        private readonly Mock<IClass603> aClass;

        public Test603()
        {
            this.aClass = new Mock<IClass603>();
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

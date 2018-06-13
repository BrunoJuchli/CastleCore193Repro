using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test344
    {
        private readonly Mock<IClass344> aClass;

        public Test344()
        {
            this.aClass = new Mock<IClass344>();
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

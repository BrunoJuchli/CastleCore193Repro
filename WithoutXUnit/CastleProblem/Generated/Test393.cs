using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test393
    {
        private readonly Mock<IClass393> aClass;

        public Test393()
        {
            this.aClass = new Mock<IClass393>();
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

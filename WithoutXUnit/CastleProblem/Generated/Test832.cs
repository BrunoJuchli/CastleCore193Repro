using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test832
    {
        private readonly Mock<IClass832> aClass;

        public Test832()
        {
            this.aClass = new Mock<IClass832>();
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

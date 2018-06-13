using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test509
    {
        private readonly Mock<IClass509> aClass;

        public Test509()
        {
            this.aClass = new Mock<IClass509>();
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

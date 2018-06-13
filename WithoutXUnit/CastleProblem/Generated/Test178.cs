using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test178
    {
        private readonly Mock<IClass178> aClass;

        public Test178()
        {
            this.aClass = new Mock<IClass178>();
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

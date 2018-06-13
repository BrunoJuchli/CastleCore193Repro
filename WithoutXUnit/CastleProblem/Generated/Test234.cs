using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test234
    {
        private readonly Mock<IClass234> aClass;

        public Test234()
        {
            this.aClass = new Mock<IClass234>();
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

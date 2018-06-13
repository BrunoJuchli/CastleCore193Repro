using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test785
    {
        private readonly Mock<IClass785> aClass;

        public Test785()
        {
            this.aClass = new Mock<IClass785>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test999
    {
        private readonly Mock<IClass999> aClass;

        public Test999()
        {
            this.aClass = new Mock<IClass999>();
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

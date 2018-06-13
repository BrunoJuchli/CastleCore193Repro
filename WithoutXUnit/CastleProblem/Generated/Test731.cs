using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test731
    {
        private readonly Mock<IClass731> aClass;

        public Test731()
        {
            this.aClass = new Mock<IClass731>();
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

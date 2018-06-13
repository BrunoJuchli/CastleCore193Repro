using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test909
    {
        private readonly Mock<IClass909> aClass;

        public Test909()
        {
            this.aClass = new Mock<IClass909>();
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

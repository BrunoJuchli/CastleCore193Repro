using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test918
    {
        private readonly Mock<IClass918> aClass;

        public Test918()
        {
            this.aClass = new Mock<IClass918>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test710
    {
        private readonly Mock<IClass710> aClass;

        public Test710()
        {
            this.aClass = new Mock<IClass710>();
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

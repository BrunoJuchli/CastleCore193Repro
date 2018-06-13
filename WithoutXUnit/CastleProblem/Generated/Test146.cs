using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test146
    {
        private readonly Mock<IClass146> aClass;

        public Test146()
        {
            this.aClass = new Mock<IClass146>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test50
    {
        private readonly Mock<IClass50> aClass;

        public Test50()
        {
            this.aClass = new Mock<IClass50>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test391
    {
        private readonly Mock<IClass391> aClass;

        public Test391()
        {
            this.aClass = new Mock<IClass391>();
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

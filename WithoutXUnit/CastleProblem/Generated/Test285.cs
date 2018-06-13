using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test285
    {
        private readonly Mock<IClass285> aClass;

        public Test285()
        {
            this.aClass = new Mock<IClass285>();
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

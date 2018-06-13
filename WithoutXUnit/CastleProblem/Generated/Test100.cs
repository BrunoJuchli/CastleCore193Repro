using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test100
    {
        private readonly Mock<IClass100> aClass;

        public Test100()
        {
            this.aClass = new Mock<IClass100>();
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

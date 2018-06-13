using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test530
    {
        private readonly Mock<IClass530> aClass;

        public Test530()
        {
            this.aClass = new Mock<IClass530>();
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

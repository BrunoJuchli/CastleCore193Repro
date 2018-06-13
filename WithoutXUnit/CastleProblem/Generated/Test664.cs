using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test664
    {
        private readonly Mock<IClass664> aClass;

        public Test664()
        {
            this.aClass = new Mock<IClass664>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test940
    {
        private readonly Mock<IClass940> aClass;

        public Test940()
        {
            this.aClass = new Mock<IClass940>();
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

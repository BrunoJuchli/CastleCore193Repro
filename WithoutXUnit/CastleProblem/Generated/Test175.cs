using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test175
    {
        private readonly Mock<IClass175> aClass;

        public Test175()
        {
            this.aClass = new Mock<IClass175>();
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

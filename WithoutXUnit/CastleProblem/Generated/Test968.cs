using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test968
    {
        private readonly Mock<IClass968> aClass;

        public Test968()
        {
            this.aClass = new Mock<IClass968>();
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

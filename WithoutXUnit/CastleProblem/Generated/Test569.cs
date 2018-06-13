using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test569
    {
        private readonly Mock<IClass569> aClass;

        public Test569()
        {
            this.aClass = new Mock<IClass569>();
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

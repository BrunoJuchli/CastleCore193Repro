using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test204
    {
        private readonly Mock<IClass204> aClass;

        public Test204()
        {
            this.aClass = new Mock<IClass204>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test540
    {
        private readonly Mock<IClass540> aClass;

        public Test540()
        {
            this.aClass = new Mock<IClass540>();
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

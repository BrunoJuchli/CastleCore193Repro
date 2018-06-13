using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test276
    {
        private readonly Mock<IClass276> aClass;

        public Test276()
        {
            this.aClass = new Mock<IClass276>();
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

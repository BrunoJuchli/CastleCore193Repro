using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test148
    {
        private readonly Mock<IClass148> aClass;

        public Test148()
        {
            this.aClass = new Mock<IClass148>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test176
    {
        private readonly Mock<IClass176> aClass;

        public Test176()
        {
            this.aClass = new Mock<IClass176>();
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

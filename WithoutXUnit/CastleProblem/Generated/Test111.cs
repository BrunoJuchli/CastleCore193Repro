using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test111
    {
        private readonly Mock<IClass111> aClass;

        public Test111()
        {
            this.aClass = new Mock<IClass111>();
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

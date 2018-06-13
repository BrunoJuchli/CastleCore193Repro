using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test267
    {
        private readonly Mock<IClass267> aClass;

        public Test267()
        {
            this.aClass = new Mock<IClass267>();
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

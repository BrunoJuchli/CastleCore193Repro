using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test736
    {
        private readonly Mock<IClass736> aClass;

        public Test736()
        {
            this.aClass = new Mock<IClass736>();
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

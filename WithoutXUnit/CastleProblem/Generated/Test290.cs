using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test290
    {
        private readonly Mock<IClass290> aClass;

        public Test290()
        {
            this.aClass = new Mock<IClass290>();
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

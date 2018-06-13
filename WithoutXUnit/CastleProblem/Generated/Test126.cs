using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test126
    {
        private readonly Mock<IClass126> aClass;

        public Test126()
        {
            this.aClass = new Mock<IClass126>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test853
    {
        private readonly Mock<IClass853> aClass;

        public Test853()
        {
            this.aClass = new Mock<IClass853>();
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

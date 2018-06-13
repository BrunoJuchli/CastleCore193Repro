using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test646
    {
        private readonly Mock<IClass646> aClass;

        public Test646()
        {
            this.aClass = new Mock<IClass646>();
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

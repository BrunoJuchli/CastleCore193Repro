using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test106
    {
        private readonly Mock<IClass106> aClass;

        public Test106()
        {
            this.aClass = new Mock<IClass106>();
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

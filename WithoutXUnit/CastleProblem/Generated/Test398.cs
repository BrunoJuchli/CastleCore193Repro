using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test398
    {
        private readonly Mock<IClass398> aClass;

        public Test398()
        {
            this.aClass = new Mock<IClass398>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test799
    {
        private readonly Mock<IClass799> aClass;

        public Test799()
        {
            this.aClass = new Mock<IClass799>();
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

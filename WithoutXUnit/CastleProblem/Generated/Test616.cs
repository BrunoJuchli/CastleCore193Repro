using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test616
    {
        private readonly Mock<IClass616> aClass;

        public Test616()
        {
            this.aClass = new Mock<IClass616>();
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

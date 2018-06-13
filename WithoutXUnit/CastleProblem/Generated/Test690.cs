using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test690
    {
        private readonly Mock<IClass690> aClass;

        public Test690()
        {
            this.aClass = new Mock<IClass690>();
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

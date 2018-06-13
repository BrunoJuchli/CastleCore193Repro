using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test768
    {
        private readonly Mock<IClass768> aClass;

        public Test768()
        {
            this.aClass = new Mock<IClass768>();
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

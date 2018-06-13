using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test868
    {
        private readonly Mock<IClass868> aClass;

        public Test868()
        {
            this.aClass = new Mock<IClass868>();
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

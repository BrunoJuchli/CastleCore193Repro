using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test879
    {
        private readonly Mock<IClass879> aClass;

        public Test879()
        {
            this.aClass = new Mock<IClass879>();
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

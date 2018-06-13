using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test941
    {
        private readonly Mock<IClass941> aClass;

        public Test941()
        {
            this.aClass = new Mock<IClass941>();
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

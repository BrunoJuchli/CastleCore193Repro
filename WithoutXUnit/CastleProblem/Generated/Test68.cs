using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test68
    {
        private readonly Mock<IClass68> aClass;

        public Test68()
        {
            this.aClass = new Mock<IClass68>();
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

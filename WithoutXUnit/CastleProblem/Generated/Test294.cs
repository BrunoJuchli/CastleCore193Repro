using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test294
    {
        private readonly Mock<IClass294> aClass;

        public Test294()
        {
            this.aClass = new Mock<IClass294>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test841
    {
        private readonly Mock<IClass841> aClass;

        public Test841()
        {
            this.aClass = new Mock<IClass841>();
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

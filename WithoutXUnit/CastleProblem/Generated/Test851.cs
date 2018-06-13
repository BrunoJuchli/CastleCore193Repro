using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test851
    {
        private readonly Mock<IClass851> aClass;

        public Test851()
        {
            this.aClass = new Mock<IClass851>();
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

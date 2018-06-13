using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test550
    {
        private readonly Mock<IClass550> aClass;

        public Test550()
        {
            this.aClass = new Mock<IClass550>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test87
    {
        private readonly Mock<IClass87> aClass;

        public Test87()
        {
            this.aClass = new Mock<IClass87>();
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

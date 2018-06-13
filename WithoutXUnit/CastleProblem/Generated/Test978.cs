using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test978
    {
        private readonly Mock<IClass978> aClass;

        public Test978()
        {
            this.aClass = new Mock<IClass978>();
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

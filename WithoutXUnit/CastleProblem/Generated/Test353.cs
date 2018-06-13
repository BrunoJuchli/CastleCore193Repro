using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test353
    {
        private readonly Mock<IClass353> aClass;

        public Test353()
        {
            this.aClass = new Mock<IClass353>();
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

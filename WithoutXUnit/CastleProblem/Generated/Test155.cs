using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test155
    {
        private readonly Mock<IClass155> aClass;

        public Test155()
        {
            this.aClass = new Mock<IClass155>();
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

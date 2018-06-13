using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test
    {
        private readonly Mock<IClass> aClass;

        public Test()
        {
            this.aClass = new Mock<IClass>();
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
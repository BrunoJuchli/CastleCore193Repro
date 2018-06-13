using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test147
    {
        private readonly Mock<IClass147> aClass;

        public Test147()
        {
            this.aClass = new Mock<IClass147>();
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

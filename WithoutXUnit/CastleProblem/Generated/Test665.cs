using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test665
    {
        private readonly Mock<IClass665> aClass;

        public Test665()
        {
            this.aClass = new Mock<IClass665>();
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

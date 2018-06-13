using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test993
    {
        private readonly Mock<IClass993> aClass;

        public Test993()
        {
            this.aClass = new Mock<IClass993>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test263
    {
        private readonly Mock<IClass263> aClass;

        public Test263()
        {
            this.aClass = new Mock<IClass263>();
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

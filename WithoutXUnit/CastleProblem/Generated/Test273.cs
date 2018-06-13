using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test273
    {
        private readonly Mock<IClass273> aClass;

        public Test273()
        {
            this.aClass = new Mock<IClass273>();
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

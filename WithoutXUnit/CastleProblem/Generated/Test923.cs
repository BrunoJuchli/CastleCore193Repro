using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test923
    {
        private readonly Mock<IClass923> aClass;

        public Test923()
        {
            this.aClass = new Mock<IClass923>();
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

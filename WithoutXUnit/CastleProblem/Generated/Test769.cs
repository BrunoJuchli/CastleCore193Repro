using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test769
    {
        private readonly Mock<IClass769> aClass;

        public Test769()
        {
            this.aClass = new Mock<IClass769>();
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

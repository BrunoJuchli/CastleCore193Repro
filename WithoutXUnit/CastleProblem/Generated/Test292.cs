using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test292
    {
        private readonly Mock<IClass292> aClass;

        public Test292()
        {
            this.aClass = new Mock<IClass292>();
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

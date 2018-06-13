using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test767
    {
        private readonly Mock<IClass767> aClass;

        public Test767()
        {
            this.aClass = new Mock<IClass767>();
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

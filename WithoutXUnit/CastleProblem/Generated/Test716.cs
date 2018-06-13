using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test716
    {
        private readonly Mock<IClass716> aClass;

        public Test716()
        {
            this.aClass = new Mock<IClass716>();
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

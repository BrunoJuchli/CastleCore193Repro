using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test803
    {
        private readonly Mock<IClass803> aClass;

        public Test803()
        {
            this.aClass = new Mock<IClass803>();
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

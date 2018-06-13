using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test609
    {
        private readonly Mock<IClass609> aClass;

        public Test609()
        {
            this.aClass = new Mock<IClass609>();
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

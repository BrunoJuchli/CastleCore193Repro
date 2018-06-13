using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test698
    {
        private readonly Mock<IClass698> aClass;

        public Test698()
        {
            this.aClass = new Mock<IClass698>();
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

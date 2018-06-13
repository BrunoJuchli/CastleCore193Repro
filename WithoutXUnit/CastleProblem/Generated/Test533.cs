using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test533
    {
        private readonly Mock<IClass533> aClass;

        public Test533()
        {
            this.aClass = new Mock<IClass533>();
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

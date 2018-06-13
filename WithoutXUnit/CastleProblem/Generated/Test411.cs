using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test411
    {
        private readonly Mock<IClass411> aClass;

        public Test411()
        {
            this.aClass = new Mock<IClass411>();
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

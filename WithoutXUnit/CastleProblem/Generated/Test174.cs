using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test174
    {
        private readonly Mock<IClass174> aClass;

        public Test174()
        {
            this.aClass = new Mock<IClass174>();
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

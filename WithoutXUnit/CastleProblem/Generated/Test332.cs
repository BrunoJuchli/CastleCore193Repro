using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test332
    {
        private readonly Mock<IClass332> aClass;

        public Test332()
        {
            this.aClass = new Mock<IClass332>();
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

using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test259
    {
        private readonly Mock<IClass259> aClass;

        public Test259()
        {
            this.aClass = new Mock<IClass259>();
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

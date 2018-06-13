using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test346
    {
        private readonly Mock<IClass346> aClass;

        public Test346()
        {
            this.aClass = new Mock<IClass346>();
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

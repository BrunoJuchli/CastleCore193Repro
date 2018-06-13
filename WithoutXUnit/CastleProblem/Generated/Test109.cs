using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test109
    {
        private readonly Mock<IClass109> aClass;

        public Test109()
        {
            this.aClass = new Mock<IClass109>();
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

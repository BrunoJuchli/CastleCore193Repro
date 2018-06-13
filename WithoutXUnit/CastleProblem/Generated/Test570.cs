using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test570
    {
        private readonly Mock<IClass570> aClass;

        public Test570()
        {
            this.aClass = new Mock<IClass570>();
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

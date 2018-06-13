using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test372
    {
        private readonly Mock<IClass372> aClass;

        public Test372()
        {
            this.aClass = new Mock<IClass372>();
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

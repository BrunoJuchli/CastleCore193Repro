using System;
using System.Diagnostics;
using Moq;

namespace NetCoreRepro.ToDuplicate
{
    public class Test980
    {
        private readonly Mock<IClass980> aClass;

        public Test980()
        {
            this.aClass = new Mock<IClass980>();
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

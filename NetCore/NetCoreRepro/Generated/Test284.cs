using System;
using System.Diagnostics;
using Moq;

namespace NetCoreRepro.ToDuplicate
{
    public class Test284
    {
        private readonly Mock<IClass284> aClass;

        public Test284()
        {
            this.aClass = new Mock<IClass284>();
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

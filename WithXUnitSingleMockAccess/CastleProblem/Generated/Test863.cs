using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test863
    {
        private readonly Mock<IClass863> aClass;

        public Test863()
        {
            this.aClass = new Mock<IClass863>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}

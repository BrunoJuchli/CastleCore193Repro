using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test632
    {
        private readonly Mock<IClass632> aClass;

        public Test632()
        {
            this.aClass = new Mock<IClass632>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}

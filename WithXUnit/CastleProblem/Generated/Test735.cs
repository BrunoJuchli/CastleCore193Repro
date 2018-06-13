using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test735
    {
        private readonly Mock<IClass735> aClass;

        public Test735()
        {
            this.aClass = new Mock<IClass735>();
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

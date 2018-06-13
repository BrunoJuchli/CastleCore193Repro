using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test880
    {
        private readonly Mock<IClass880> aClass;

        public Test880()
        {
            this.aClass = new Mock<IClass880>();
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

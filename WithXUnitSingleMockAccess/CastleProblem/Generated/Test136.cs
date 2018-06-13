using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test136
    {
        private readonly Mock<IClass136> aClass;

        public Test136()
        {
            this.aClass = new Mock<IClass136>();
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

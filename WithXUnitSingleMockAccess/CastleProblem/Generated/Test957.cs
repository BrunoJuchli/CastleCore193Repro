using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test957
    {
        private readonly Mock<IClass957> aClass;

        public Test957()
        {
            this.aClass = new Mock<IClass957>();
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

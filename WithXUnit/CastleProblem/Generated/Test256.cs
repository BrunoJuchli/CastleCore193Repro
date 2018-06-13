using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test256
    {
        private readonly Mock<IClass256> aClass;

        public Test256()
        {
            this.aClass = new Mock<IClass256>();
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

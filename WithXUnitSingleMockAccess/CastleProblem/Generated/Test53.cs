using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test53
    {
        private readonly Mock<IClass53> aClass;

        public Test53()
        {
            this.aClass = new Mock<IClass53>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test954
    {
        private readonly Mock<IClass954> aClass;

        public Test954()
        {
            this.aClass = new Mock<IClass954>();
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

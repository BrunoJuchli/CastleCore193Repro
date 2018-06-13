using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test935
    {
        private readonly Mock<IClass935> aClass;

        public Test935()
        {
            this.aClass = new Mock<IClass935>();
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

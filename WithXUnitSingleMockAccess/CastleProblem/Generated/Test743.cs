using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test743
    {
        private readonly Mock<IClass743> aClass;

        public Test743()
        {
            this.aClass = new Mock<IClass743>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test871
    {
        private readonly Mock<IClass871> aClass;

        public Test871()
        {
            this.aClass = new Mock<IClass871>();
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

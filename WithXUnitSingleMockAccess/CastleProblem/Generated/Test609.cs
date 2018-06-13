using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test609
    {
        private readonly Mock<IClass609> aClass;

        public Test609()
        {
            this.aClass = new Mock<IClass609>();
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

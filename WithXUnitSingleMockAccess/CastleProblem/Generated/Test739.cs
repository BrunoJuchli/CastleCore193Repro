using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test739
    {
        private readonly Mock<IClass739> aClass;

        public Test739()
        {
            this.aClass = new Mock<IClass739>();
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

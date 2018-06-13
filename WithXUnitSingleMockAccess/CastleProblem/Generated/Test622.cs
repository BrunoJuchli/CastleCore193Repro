using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test622
    {
        private readonly Mock<IClass622> aClass;

        public Test622()
        {
            this.aClass = new Mock<IClass622>();
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

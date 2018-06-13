using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test829
    {
        private readonly Mock<IClass829> aClass;

        public Test829()
        {
            this.aClass = new Mock<IClass829>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test348
    {
        private readonly Mock<IClass348> aClass;

        public Test348()
        {
            this.aClass = new Mock<IClass348>();
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

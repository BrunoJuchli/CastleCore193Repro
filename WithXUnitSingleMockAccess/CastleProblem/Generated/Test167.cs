using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test167
    {
        private readonly Mock<IClass167> aClass;

        public Test167()
        {
            this.aClass = new Mock<IClass167>();
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

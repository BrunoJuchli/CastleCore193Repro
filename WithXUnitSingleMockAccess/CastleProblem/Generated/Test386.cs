using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test386
    {
        private readonly Mock<IClass386> aClass;

        public Test386()
        {
            this.aClass = new Mock<IClass386>();
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

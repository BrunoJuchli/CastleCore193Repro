using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test790
    {
        private readonly Mock<IClass790> aClass;

        public Test790()
        {
            this.aClass = new Mock<IClass790>();
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

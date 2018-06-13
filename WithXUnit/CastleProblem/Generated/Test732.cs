using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test732
    {
        private readonly Mock<IClass732> aClass;

        public Test732()
        {
            this.aClass = new Mock<IClass732>();
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

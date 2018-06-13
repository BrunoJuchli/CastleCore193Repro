using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test977
    {
        private readonly Mock<IClass977> aClass;

        public Test977()
        {
            this.aClass = new Mock<IClass977>();
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

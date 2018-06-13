using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test665
    {
        private readonly Mock<IClass665> aClass;

        public Test665()
        {
            this.aClass = new Mock<IClass665>();
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

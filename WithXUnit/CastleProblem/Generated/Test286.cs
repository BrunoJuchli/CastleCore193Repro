using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test286
    {
        private readonly Mock<IClass286> aClass;

        public Test286()
        {
            this.aClass = new Mock<IClass286>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test569
    {
        private readonly Mock<IClass569> aClass;

        public Test569()
        {
            this.aClass = new Mock<IClass569>();
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

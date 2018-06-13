using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test204
    {
        private readonly Mock<IClass204> aClass;

        public Test204()
        {
            this.aClass = new Mock<IClass204>();
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

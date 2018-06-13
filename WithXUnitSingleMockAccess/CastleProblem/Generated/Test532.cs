using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test532
    {
        private readonly Mock<IClass532> aClass;

        public Test532()
        {
            this.aClass = new Mock<IClass532>();
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

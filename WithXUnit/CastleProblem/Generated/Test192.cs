using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test192
    {
        private readonly Mock<IClass192> aClass;

        public Test192()
        {
            this.aClass = new Mock<IClass192>();
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

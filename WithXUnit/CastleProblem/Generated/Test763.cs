using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test763
    {
        private readonly Mock<IClass763> aClass;

        public Test763()
        {
            this.aClass = new Mock<IClass763>();
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

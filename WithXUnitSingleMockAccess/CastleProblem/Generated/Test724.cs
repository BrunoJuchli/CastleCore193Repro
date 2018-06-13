using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test724
    {
        private readonly Mock<IClass724> aClass;

        public Test724()
        {
            this.aClass = new Mock<IClass724>();
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

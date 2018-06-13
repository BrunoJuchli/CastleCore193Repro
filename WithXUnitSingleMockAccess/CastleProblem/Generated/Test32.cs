using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test32
    {
        private readonly Mock<IClass32> aClass;

        public Test32()
        {
            this.aClass = new Mock<IClass32>();
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

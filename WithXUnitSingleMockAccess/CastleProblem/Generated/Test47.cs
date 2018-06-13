using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test47
    {
        private readonly Mock<IClass47> aClass;

        public Test47()
        {
            this.aClass = new Mock<IClass47>();
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

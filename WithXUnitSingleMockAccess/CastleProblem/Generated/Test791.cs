using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test791
    {
        private readonly Mock<IClass791> aClass;

        public Test791()
        {
            this.aClass = new Mock<IClass791>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test832
    {
        private readonly Mock<IClass832> aClass;

        public Test832()
        {
            this.aClass = new Mock<IClass832>();
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

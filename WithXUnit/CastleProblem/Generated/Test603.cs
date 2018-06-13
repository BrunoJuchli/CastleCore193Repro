using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test603
    {
        private readonly Mock<IClass603> aClass;

        public Test603()
        {
            this.aClass = new Mock<IClass603>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test787
    {
        private readonly Mock<IClass787> aClass;

        public Test787()
        {
            this.aClass = new Mock<IClass787>();
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

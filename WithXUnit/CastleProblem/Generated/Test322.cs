using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test322
    {
        private readonly Mock<IClass322> aClass;

        public Test322()
        {
            this.aClass = new Mock<IClass322>();
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

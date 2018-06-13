using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test310
    {
        private readonly Mock<IClass310> aClass;

        public Test310()
        {
            this.aClass = new Mock<IClass310>();
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

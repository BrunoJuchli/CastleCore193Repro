using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test741
    {
        private readonly Mock<IClass741> aClass;

        public Test741()
        {
            this.aClass = new Mock<IClass741>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test260
    {
        private readonly Mock<IClass260> aClass;

        public Test260()
        {
            this.aClass = new Mock<IClass260>();
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

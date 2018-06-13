using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test993
    {
        private readonly Mock<IClass993> aClass;

        public Test993()
        {
            this.aClass = new Mock<IClass993>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test879
    {
        private readonly Mock<IClass879> aClass;

        public Test879()
        {
            this.aClass = new Mock<IClass879>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test849
    {
        private readonly Mock<IClass849> aClass;

        public Test849()
        {
            this.aClass = new Mock<IClass849>();
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

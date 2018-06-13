using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test783
    {
        private readonly Mock<IClass783> aClass;

        public Test783()
        {
            this.aClass = new Mock<IClass783>();
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

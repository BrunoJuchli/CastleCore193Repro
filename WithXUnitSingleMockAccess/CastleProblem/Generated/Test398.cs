using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test398
    {
        private readonly Mock<IClass398> aClass;

        public Test398()
        {
            this.aClass = new Mock<IClass398>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test106
    {
        private readonly Mock<IClass106> aClass;

        public Test106()
        {
            this.aClass = new Mock<IClass106>();
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

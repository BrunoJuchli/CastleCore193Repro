using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test920
    {
        private readonly Mock<IClass920> aClass;

        public Test920()
        {
            this.aClass = new Mock<IClass920>();
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

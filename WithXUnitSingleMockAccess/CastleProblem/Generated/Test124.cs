using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test124
    {
        private readonly Mock<IClass124> aClass;

        public Test124()
        {
            this.aClass = new Mock<IClass124>();
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

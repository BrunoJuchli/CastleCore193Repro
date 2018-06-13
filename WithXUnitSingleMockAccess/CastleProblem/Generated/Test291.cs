using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test291
    {
        private readonly Mock<IClass291> aClass;

        public Test291()
        {
            this.aClass = new Mock<IClass291>();
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

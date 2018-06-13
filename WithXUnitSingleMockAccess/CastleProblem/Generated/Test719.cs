using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test719
    {
        private readonly Mock<IClass719> aClass;

        public Test719()
        {
            this.aClass = new Mock<IClass719>();
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

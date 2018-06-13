using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test255
    {
        private readonly Mock<IClass255> aClass;

        public Test255()
        {
            this.aClass = new Mock<IClass255>();
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

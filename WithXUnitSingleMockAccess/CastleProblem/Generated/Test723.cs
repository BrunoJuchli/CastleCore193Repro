using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test723
    {
        private readonly Mock<IClass723> aClass;

        public Test723()
        {
            this.aClass = new Mock<IClass723>();
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

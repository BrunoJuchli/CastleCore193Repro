using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test68
    {
        private readonly Mock<IClass68> aClass;

        public Test68()
        {
            this.aClass = new Mock<IClass68>();
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

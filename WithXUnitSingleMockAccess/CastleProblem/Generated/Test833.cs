using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test833
    {
        private readonly Mock<IClass833> aClass;

        public Test833()
        {
            this.aClass = new Mock<IClass833>();
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

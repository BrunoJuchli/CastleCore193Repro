using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test792
    {
        private readonly Mock<IClass792> aClass;

        public Test792()
        {
            this.aClass = new Mock<IClass792>();
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

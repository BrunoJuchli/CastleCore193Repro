using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test456
    {
        private readonly Mock<IClass456> aClass;

        public Test456()
        {
            this.aClass = new Mock<IClass456>();
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

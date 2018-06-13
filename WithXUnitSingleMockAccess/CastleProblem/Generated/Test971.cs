using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test971
    {
        private readonly Mock<IClass971> aClass;

        public Test971()
        {
            this.aClass = new Mock<IClass971>();
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

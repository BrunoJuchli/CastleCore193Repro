using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test353
    {
        private readonly Mock<IClass353> aClass;

        public Test353()
        {
            this.aClass = new Mock<IClass353>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test113
    {
        private readonly Mock<IClass113> aClass;

        public Test113()
        {
            this.aClass = new Mock<IClass113>();
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

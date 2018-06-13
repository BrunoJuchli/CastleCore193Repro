using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test109
    {
        private readonly Mock<IClass109> aClass;

        public Test109()
        {
            this.aClass = new Mock<IClass109>();
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

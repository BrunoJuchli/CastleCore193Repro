using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test811
    {
        private readonly Mock<IClass811> aClass;

        public Test811()
        {
            this.aClass = new Mock<IClass811>();
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

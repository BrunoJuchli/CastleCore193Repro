using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test923
    {
        private readonly Mock<IClass923> aClass;

        public Test923()
        {
            this.aClass = new Mock<IClass923>();
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

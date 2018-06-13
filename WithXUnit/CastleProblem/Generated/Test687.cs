using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test687
    {
        private readonly Mock<IClass687> aClass;

        public Test687()
        {
            this.aClass = new Mock<IClass687>();
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

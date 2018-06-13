using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test201
    {
        private readonly Mock<IClass201> aClass;

        public Test201()
        {
            this.aClass = new Mock<IClass201>();
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

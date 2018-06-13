using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test799
    {
        private readonly Mock<IClass799> aClass;

        public Test799()
        {
            this.aClass = new Mock<IClass799>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test983
    {
        private readonly Mock<IClass983> aClass;

        public Test983()
        {
            this.aClass = new Mock<IClass983>();
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

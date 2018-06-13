using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test667
    {
        private readonly Mock<IClass667> aClass;

        public Test667()
        {
            this.aClass = new Mock<IClass667>();
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

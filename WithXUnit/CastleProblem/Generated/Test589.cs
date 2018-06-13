using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test589
    {
        private readonly Mock<IClass589> aClass;

        public Test589()
        {
            this.aClass = new Mock<IClass589>();
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

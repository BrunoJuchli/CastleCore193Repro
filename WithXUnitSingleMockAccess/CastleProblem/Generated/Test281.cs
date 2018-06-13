using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test281
    {
        private readonly Mock<IClass281> aClass;

        public Test281()
        {
            this.aClass = new Mock<IClass281>();
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

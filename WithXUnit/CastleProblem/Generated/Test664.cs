using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test664
    {
        private readonly Mock<IClass664> aClass;

        public Test664()
        {
            this.aClass = new Mock<IClass664>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test352
    {
        private readonly Mock<IClass352> aClass;

        public Test352()
        {
            this.aClass = new Mock<IClass352>();
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

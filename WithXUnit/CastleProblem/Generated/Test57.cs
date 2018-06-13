using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test57
    {
        private readonly Mock<IClass57> aClass;

        public Test57()
        {
            this.aClass = new Mock<IClass57>();
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

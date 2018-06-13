using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test649
    {
        private readonly Mock<IClass649> aClass;

        public Test649()
        {
            this.aClass = new Mock<IClass649>();
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

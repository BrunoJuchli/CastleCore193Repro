using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test838
    {
        private readonly Mock<IClass838> aClass;

        public Test838()
        {
            this.aClass = new Mock<IClass838>();
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

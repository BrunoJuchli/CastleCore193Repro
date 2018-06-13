using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test163
    {
        private readonly Mock<IClass163> aClass;

        public Test163()
        {
            this.aClass = new Mock<IClass163>();
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

using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test93
    {
        private readonly Mock<IClass93> aClass;

        public Test93()
        {
            this.aClass = new Mock<IClass93>();
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

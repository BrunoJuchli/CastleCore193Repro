using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test962
    {
        private readonly Mock<IClass962> aClass;

        public Test962()
        {
            this.aClass = new Mock<IClass962>();
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

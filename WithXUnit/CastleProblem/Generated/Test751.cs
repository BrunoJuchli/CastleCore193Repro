using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test751
    {
        private readonly Mock<IClass751> aClass;

        public Test751()
        {
            this.aClass = new Mock<IClass751>();
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

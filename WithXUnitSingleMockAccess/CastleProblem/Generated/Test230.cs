using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test230
    {
        private readonly Mock<IClass230> aClass;

        public Test230()
        {
            this.aClass = new Mock<IClass230>();
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

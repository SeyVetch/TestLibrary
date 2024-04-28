namespace Test
{
    public class CircleAreaTest
    {
        [Fact]
        public void CircleArea_Radius1_PI()
        {
            double testValue = Shape.circleArea(1);

            double correctValue = Math.PI;

            Assert.Equal(correctValue, testValue);
        }
        [Fact]
        public void CircleArea_Radius2_4PI()
        {
            double testValue = Shape.circleArea(2);

            double correctValue = Math.PI * 4;

            Assert.Equal(correctValue, testValue);
        }
        [Fact]
        public void CircleArea_Radius0_0()
        {
            double testValue = Shape.circleArea(0);

            double correctValue = 0;

            Assert.Equal(correctValue, testValue);
        }
        [Fact]
        public void CircleArea_RadiusNegative1_Negative1()
        {
            double testValue = Shape.circleArea(-1);

            double correctValue = -1;

            Assert.Equal(correctValue, testValue);
        }
    }
    public class TriangleAreaTest
    {
        [Fact]
        public void TriangleArea_A3B4C5_6()
        {
            double a = 3, b = 4, c = 5;
            double testValue = Shape.triangleArea(a, b, c);

            double correctValue = 6;

            Assert.Equal(correctValue, testValue);
        }
        [Fact]
        public void TriangleArea_A1B1C1_0Point433()
        {
            double a = 1, b = 1, c = 1;
            double testValue = Math.Round(Shape.triangleArea(a, b, c), 3);

            double correctValue = 0.433;

            Assert.Equal(correctValue, testValue);
        }
        [Fact]
        public void TriangleArea_A1B1C2_Negative1()
        {
            double a = 1, b = 1, c = 2;
            double testValue = Shape.triangleArea(a, b, c);

            double correctValue = -1;

            Assert.Equal(correctValue, testValue);
        }
        [Fact]
        public void TriangleArea_A1B1CNegative1_Negative1()
        {
            double a = 1, b = 1, c = -1;
            double testValue = Shape.triangleArea(a, b, c);

            double correctValue = -1;

            Assert.Equal(correctValue, testValue);
        }
    }
    public class IsTriangleRightTest
    {
        [Fact]
        public void isTriangleRight_A3B4C5_True()
        {
            double a = 3, b = 4, c = 5;
            bool testValue = Shape.isTriangleRight(a, b, c);

            Assert.True(testValue);
        }
        [Fact]
        public void isTriangleRight_A1B1C1_False()
        {
            double a = 1, b = 1, c = 1;
            bool testValue = Shape.isTriangleRight(a, b, c);

            Assert.False(testValue);
        }
    }
}
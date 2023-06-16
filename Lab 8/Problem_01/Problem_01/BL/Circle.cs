namespace Problem_01.BL
{
    public class Circle
    {
        protected double radius = 1.0;
        protected string colour = "Red";

        public Circle()
        {
            this.radius = 1.0;
            this.colour = "Red";
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string colour)
        {
            this.radius = radius;
            this.colour = colour;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public string getColour()
        {
            return this.colour;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public void setColour(string colour)
        {
            this.colour = colour;
        }
        public double getArea()
        {
            return (Math.Pow(radius, 2) * 3.14);
        }

        public virtual string toString()
        {
            return "Circle[radius = " + radius + ", color = " + colour + "]";
        }

    }
}

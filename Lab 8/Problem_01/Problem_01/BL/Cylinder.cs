namespace Problem_01.BL
{
    internal class Cylinder : Circle
    {
        private double height = 1.0;
        public Cylinder()
        {
            this.height = 1.0;
        }
        public Cylinder(double radius) : base(radius)
        {
            this.radius = radius;
        }
        public Cylinder(double radius, double height) : base(radius)
        {
            this.radius = radius;
            this.height = height;
        }
        public Cylinder(double radius, double height, string colour) : base(radius, colour)
        {
            this.radius = radius;
            this.height = height;
            this.colour = colour;
        }

        public double getHeight()
        {
            return this.height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            return (getArea() * height);
        }
        public override string toString()
        {
            return ("Cylinder [" + base.toString() + "] ");
        }
    }
}

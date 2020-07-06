namespace Rectangle {
    public class Rectangle {
        double width, height;

        public Rectangle (double width, double height) {
            this.width = width;
            this.height = height;
        }
        public double GetArea () => this.width * this.height;
        public double GetPerimeter () => (this.width + this.height) / 2;
        public string Display () => $"Rectangle width = {this.width}, height = {this.height}";
    }
}
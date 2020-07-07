using System;
namespace Circle {
    public class Circle {
        private int _radius = 1;
        private string _color = "red";

        public Circle () { }
        public Circle (int radius, string color) {
            this._radius = radius;
            this._color = color;
        }
        public int Radius {
            get => this._radius;
            set => this._radius = value;
        }
        public string Color {
            get => this._color;
            set => this._color = value;
        }
        public void Show () {
            Console.WriteLine ($"radius: {this._radius}, color: {this._color}");
        }
    }
}
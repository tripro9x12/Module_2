namespace Fan {
    public class Fan {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        private int Speed;
        public void setSpeed (int speed) {
            Speed = speed;
        }
        public int getSpeed () {
            if (Speed == 2) {
                return MEDIUM;
            } else if (Speed == 3) {
                return FAST;
            } else {
                return SLOW;
            }
        }
        private bool on;
        public bool ON {
            get => on;
            set => on = value;
        }

        private double Radius;
        public double RADIUS {
            get {
                if (Radius < 5) {
                    return 5;
                } else {
                    return Radius;
                }
            }
            set => Radius = value;
        }

        private string Color;
        public string COLOR {
            get {
                if (Color == "") {
                    return "Blue";
                } else return Color;
            }
            set => Color = value;
        }

        public string toString_s () {
            if (this.ON == true) {
                return $"speed = {this.getSpeed()}, color = {this.COLOR},radius = {this.RADIUS}, fan is on";
            } else if (this.ON == false) {
                return $"color = {this.COLOR},radius = {this.RADIUS}, fan is off";
            } else return "";

        }

    }
}
namespace Car {
    public class Car {

        private string name;
        private string engine;
        public static int numberOfCars = 0;
        public Car (string name, string engine) {
            this.name = name;
            this.engine = engine;
            numberOfCars++;
        }

    }
}
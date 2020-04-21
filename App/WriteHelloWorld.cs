namespace App {
    public class WriteHelloWorld :IWriteHelloWorld
    {
        private string name {get; set;}
        private string time {get; set;}
        private string fullString {get; set;}

        public WriteHelloWorld(string name){
            this.name = name;
            this.time = new DateTimeProvider().toTimeOfTheDay();
            this.fullString = "Good " + time + " " + name ;
        }

        private void writeFullHelloWorl(){
            Console.WriteLine(this.fullString);
        }
    }
}
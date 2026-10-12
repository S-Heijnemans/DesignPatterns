using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            Light garageLight = new Light("Garage Light");
            CeilingFan ceilingfan = new CeilingFan("house");
            GarageDoor garageDoor = new GarageDoor(garageLight);
            Stereo stereo = new Stereo();
            // Define and instantiate an Off and On command for each Vendor class
            CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(ceilingfan);
            CeilingFanMediumCommand ceilingFanMediumCommand = new CeilingFanMediumCommand(ceilingfan);
            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingfan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingfan);

            GarageDoorUpCommand garageDoorUpCommand = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDownCommand = new GarageDoorDownCommand(garageDoor);

            LightOffCommand lightOffCommandKitchen = new LightOffCommand(kitchenLight);
            LightOnCommand lightOnCommandKitchen = new LightOnCommand(kitchenLight);
            LightOffCommand lightOffCommandLivingroom = new LightOffCommand(livingRoomLight);
            LightOnCommand lightOnCommandLivingroom = new LightOnCommand(livingRoomLight);

            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);
            StereoOnWithCdCommand stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
            StereoOnWithDvdCommand stereoOnWithDvdCommand = new StereoOnWithDvdCommand(stereo);
            StereoOnWithRadioCommand stereoOnWithRadioCommand = new StereoOnWithRadioCommand(stereo);
            



            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */
            

            Console.WriteLine(remoteControl);

            // Test the pressing of Buttons here. Don't forget to test the Undo button


        }
    }
}
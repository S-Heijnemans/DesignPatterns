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
            remoteControl.SetCommand(1, lightOnCommandLivingroom, lightOffCommandLivingroom);
            remoteControl.SetCommand(2, lightOnCommandKitchen, lightOffCommandKitchen);
            remoteControl.SetCommand(3, ceilingFanHighCommand, ceilingFanOffCommand);
            remoteControl.SetCommand(4, garageDoorUpCommand, garageDoorDownCommand);
            remoteControl.SetCommand(5, stereoOnWithCdCommand, stereoOffCommand);

            Console.WriteLine(remoteControl);

            // Test the pressing of Buttons here. Don't forget to test the Undo button
            Console.WriteLine(" TEST 1: Living Room Light");

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);

            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine(" TEST 2: Kitchen Light");

            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);

            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();


            Console.WriteLine(" TEST 3: Ceiling Fan");

            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);

            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine(" TEST 4: Ceiling Fan Speeds ");

            ceilingFanLowCommand.Execute();
            ceilingFanMediumCommand.Execute();
            ceilingFanHighCommand.Execute();

            Console.WriteLine(" Undo High ");
            ceilingFanHighCommand.Undo();

            Console.WriteLine(" Undo Medium ");
            ceilingFanMediumCommand.Undo();

            Console.WriteLine(" Undo Low ");
            ceilingFanLowCommand.Undo();

            Console.WriteLine(" TEST 5: Garage Door");

            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);

            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine(" TEST 6: Stereo ");

            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);

            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine(" TEST 7: Stereo Modes ");

            stereoOnWithCdCommand.Execute();
            stereoOnWithDvdCommand.Execute();
            stereoOnWithRadioCommand.Execute();
            stereoOffCommand.Execute();
        }
    }
}
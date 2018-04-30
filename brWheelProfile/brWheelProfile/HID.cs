using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HIDInterface;



public struct USB_ConfigReport
{
    public byte ReportId;
    public UInt16 Rotation;
    public byte GeneralGain;
    public byte ConstantGain;
    public byte DamperGain;
    public byte FrictionGain;
    public byte SineGain;
    public byte SpringGain;
    public byte InertiaGain;
    public byte CenterGain;
    public byte StopGain;
    public UInt16 MaxForce;
    public UInt16 MinForce;
    public byte Centralize;
    public byte Calibrate;
    public byte Info;       // 0=Sem ação; 1=Enviar; 2=Recebendo; 255=Não conectado
    public byte Version;
}
public struct USB_DataReport
{
    public byte ReportId;
    public Int16 X;
    public byte Y;
    public byte Z;
    public byte RX;
    public byte RY;
    public byte RZ;
    public byte[] buttons;
}


namespace brWheelProfile
{
    public class HID_demo
    {
        HIDDevice.interfaceDetails[] devices;
        HIDDevice device;
        public bool connected = false;
        private string devicePath;

        public byte[] configReceived = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public byte[] dataReceived = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public void find()
        {
            devices = HIDDevice.getConnectedDevices();

            //int selectedDeviceIndex = 0;
            /*ushort VID = devices[selectedDeviceIndex].VID;
            ushort PID = devices[selectedDeviceIndex].PID;
            int SN = devices[selectedDeviceIndex].serialNumber;*/
            // devicePath = devices[selectedDeviceIndex].devicePath;
            //devicePath = null;
            for (int i = 0; i <= devices.Length; i++)
            {
                try
                {
                    if (devices[i].VID == 9025 && devices[i].PID == 32822)
                    {
                        devicePath = devices[i].devicePath;
                        break;
                    }
                }
                catch (Exception)
                {

                }
            }

            if (devicePath == null)
            {
                Console.WriteLine("Device not found");
                connected = false;
            }

            //create a handle to the device by calling the constructor of the HID class
            //This can be done using either the VID/PID/Serialnumber, or the device path (string) 
            //all of these details are available from the HIDDevice.interfaceDetails[] struct array created above
            //The "true" boolean in the constructor tells the class we want asynchronous operation this time
            //device = new HIDDevice(devicePath, true);
            //OR, the normal usage when you know the VID and PID of the device
            //HIDDevice device = new HIDDevice(VID, PID, (ushort)SN, true);

            //next create the event handler for the incoming reports
            //device.dataReceived += new HIDDevice.dataReceivedEvent(device_dataReceived);

            //Write some data to the device (the write method throws an exception if the data is longer than the report length
            //specified by the device, this length can be found in the HIDDevice.interfaceDetails struct)
            //The write method is identical to the synchronous mode of operation
            //byte[] writeData = { 0x00, 0x01, 0x02, 0x03, 0x04 };
            //device.write(writeData);    //Its that easy!!

            //Send your program off to do other stuff here, wait for UI events etc
            //When a report occurs, the device_dataReceived(byte[] message) method will be called
            /*while(!receiveData)
            System.Threading.Thread.Sleep(100);*/

            //close the device to release all handles etc
            //device.close();
        }

        public void connect()
        {
            if (!connected && devicePath != null)
            {
                device = new HIDDevice(devicePath, true);
                device.dataReceived += new HIDDevice.dataReceivedEvent(this.device_dataReceived);
                connected = true;
            }
            else
            {
                find();
            }



        }

        public void close()
        {
            if (connected)
                device.close();
        }
        public void recordData(byte[] data)
        {
            configReceived = data;
        }

        public void sendData(USB_ConfigReport config)
        {
            if (connected)
            {
                byte[] writeData = encodeConfigReport(config);
                try
                {
                    device.write(241, writeData);    // F1 = 241   output reportid
                }
                catch (Exception)
                {
                    Console.WriteLine("Cant send data!");
                }
            }
        }

        //Whenever a report comes in, this method will be called and the data will be available! Like magic...
        public void device_dataReceived(byte[] message)
        {
            byte reportId = message[0];



            if (reportId == 4)
            {
                for (int i = 0; i < message.Length; i++)
                    dataReceived[i] = message[i];
            }
            else if (reportId == 242)
            {
                for (int i = 0; i < message.Length; i++)
                    configReceived[i] = message[i];
            }



            //else if(message[0] == 3)
            //configReceived = message;
        }

        public USB_ConfigReport decodeConfigReport()
        {
            USB_ConfigReport data = new USB_ConfigReport();
            //Console.WriteLine("########## " + configReceived[0] + " " + configReceived[1] + " " + configReceived[2] + " " + configReceived[3] + " " + configReceived[4]);

            data.ReportId = configReceived[1];
            data.Rotation = BitConverter.ToUInt16(configReceived, 2);
            data.GeneralGain = configReceived[4];
            data.ConstantGain = configReceived[5];
            data.DamperGain = configReceived[6];
            data.FrictionGain = configReceived[7];
            data.SineGain = configReceived[8];
            data.SpringGain = configReceived[9];
            data.InertiaGain = configReceived[10];
            data.CenterGain = configReceived[11];
            data.StopGain = configReceived[12];
            data.MaxForce = BitConverter.ToUInt16(configReceived, 13);
            data.MinForce = BitConverter.ToUInt16(configReceived, 15);
            data.Centralize = configReceived[17];
            data.Calibrate = configReceived[18];
            data.Info = configReceived[19];
            data.Version = configReceived[20];

            return data;
        }

        public byte[] encodeConfigReport(USB_ConfigReport config)
        {
            byte[] data = new byte[64];
            data[0] = config.ReportId;

            byte[] Rotation = BitConverter.GetBytes(config.Rotation);
            byte[] MinForce = BitConverter.GetBytes(config.MinForce);
            byte[] MaxForce = BitConverter.GetBytes(config.MaxForce);

            data[1] = Rotation[0];
            data[2] = Rotation[1];
            data[3] = config.GeneralGain;
            data[4] = config.ConstantGain;
            data[5] = config.DamperGain;
            data[6] = config.FrictionGain;
            data[7] = config.SineGain;
            data[8] = config.SpringGain;
            data[9] = config.InertiaGain;
            data[10] = config.CenterGain;
            data[11] = config.StopGain;
            
            data[12] = MaxForce[0];
            data[13] = MaxForce[1];
            data[14] = MinForce[0];
            data[15] = MinForce[1];
            data[16] = config.Centralize;
            data[17] = config.Calibrate;
            data[18] = config.Info;
            data[19] = config.Version;

            return data;
        }

        public bool isEqual(byte[] A, byte[] B)
        {
            if (A == null || B == null) return false;
            for (int b = 0; b < 63; b++)
            {
                if (A[b + 1] != B[b] && b != 18) return false; // pos 18 is INFO
            }
            return true;
        }
        public USB_DataReport decodeDataReport()
        {
            USB_DataReport data = new USB_DataReport();
            data.ReportId = dataReceived[0];
            data.X = BitConverter.ToInt16(dataReceived, 1);
            data.Y = dataReceived[3];
            data.Z = dataReceived[4];
            data.RX = dataReceived[5];
            data.RY = dataReceived[6];
            data.RZ = dataReceived[7];


            //Console.WriteLine(data.X);
            return data;
        }
    }
}

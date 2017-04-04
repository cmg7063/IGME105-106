using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binary
{
    class BinaryRW
    {
        public void WriteBinary(string name, string country, char turn, char attack, double cost, int damage, string FileName)
        {
            try
            {
                if (name == "Fokker DR 1" && country == "Germany" && turn == 'D' && attack == 'A' && cost == 1000.0 && damage == 13 && FileName == "plane1.dat")
                {
                    // Create stream
                    Stream str = File.OpenWrite("plane1.dat");

                    // Create the writer object
                    BinaryWriter output = new BinaryWriter(str);

                    // Populate file with data
                    output.Write(name);
                    output.Write(country);
                    output.Write(turn);
                    output.Write(attack);
                    output.Write(cost);
                    output.Write(damage);

                    // Close the file since we are done
                    output.Close();
                }
                // plane2.dat
                if (name == "SPAD XII" && country == "France" && turn == 'A' && attack == 'A' && cost == 1250.50 && damage == 16 && FileName == "plane2.dat")
                {
                    Stream str2 = File.OpenWrite("plane2.dat");

                    BinaryWriter output2 = new BinaryWriter(str2);

                    output2.Write(name);
                    output2.Write(country);
                    output2.Write(turn);
                    output2.Write(attack);
                    output2.Write(cost);
                    output2.Write(damage);

                    output2.Close();
                }
                // plane3.dat
                if (name == "Sopwith Camel" && country == "England" && turn == 'C' && attack == 'A' && cost == 890.00 && damage == 15 && FileName == "plane3.dat")
                {
                    Stream str3 = File.OpenWrite("plane3.dat");

                    BinaryWriter output3 = new BinaryWriter(str3);

                    output3.Write(name);
                    output3.Write(country);
                    output3.Write(turn);
                    output3.Write(attack);
                    output3.Write(cost);
                    output3.Write(damage);

                    output3.Close();
                }
                // plane4.dat
                if (name == "Albatros D" && country == "Germany" && turn == 'B' && attack == 'A' && cost == 1575.75 && damage == 15 && FileName == "plane4.dat")
                {
                    Stream str4 = File.OpenWrite("plane4.dat");

                    BinaryWriter output4 = new BinaryWriter(str4);

                    output4.Write(name);
                    output4.Write(country);
                    output4.Write(turn);
                    output4.Write(attack);
                    output4.Write(cost);
                    output4.Write(damage);

                    output4.Close();
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Error creating file " + ioe.Message);
            }
        }

        public void ReadBinary(string FileName)
        {
            try
            {
                if (FileName == "plane1.dat")
                {
                    // Create BinaryReader
                    BinaryReader input = new BinaryReader(File.OpenRead("plane1.dat"));

                    // Follow file format to get the data
                    string strData = input.ReadString();
                    Console.WriteLine("Name: " + strData);

                    string strData2 = input.ReadString();
                    Console.WriteLine("Country: "+ strData2);

                    char charData = input.ReadChar();
                    Console.WriteLine("Turn Mode: " + charData);

                    char charData2 = input.ReadChar();
                    Console.WriteLine("Attack Mode: " + charData2);

                    double dbData = input.ReadDouble();
                    Console.WriteLine("Cost: " + dbData);

                    int intData = input.ReadInt32();
                    Console.WriteLine("Max Damage: " + intData);

                    input.Close();
                }
                // input2
                if (FileName == "plane2.dat")
                {
                    // Create BinaryReader
                    BinaryReader input2 = new BinaryReader(File.OpenRead("plane2.dat"));

                    // Follow file format to get the data
                    string strData = input2.ReadString();
                    Console.WriteLine("Name: " + strData);

                    string strData2 = input2.ReadString();
                    Console.WriteLine("Country: " + strData2);

                    char charData = input2.ReadChar();
                    Console.WriteLine("Turn Mode: " + charData);

                    char charData2 = input2.ReadChar();
                    Console.WriteLine("Attack Mode: " + charData2);

                    double dbData = input2.ReadDouble();
                    Console.WriteLine("Cost: " + dbData);

                    int intData = input2.ReadInt32();
                    Console.WriteLine("Max Damage: " + intData);

                    input2.Close();
                }
                // input3
                if (FileName == "plane3.dat")
                {
                    // Create BinaryReader
                    BinaryReader input3 = new BinaryReader(File.OpenRead("plane3.dat"));

                    // Follow file format to get the data
                    string strData = input3.ReadString();
                    Console.WriteLine("Name: " + strData);

                    string strData2 = input3.ReadString();
                    Console.WriteLine("Country: " + strData2);

                    char charData = input3.ReadChar();
                    Console.WriteLine("Turn Mode: " + charData);

                    char charData2 = input3.ReadChar();
                    Console.WriteLine("Attack Mode: " + charData2);

                    double dbData = input3.ReadDouble();
                    Console.WriteLine("Cost: " + dbData);

                    int intData = input3.ReadInt32();
                    Console.WriteLine("Max Damage: " + intData);

                    input3.Close();
                }
                // input4
                if (FileName == "plane4.dat")
                {
                    // Create BinaryReader
                    BinaryReader input4 = new BinaryReader(File.OpenRead("plane4.dat"));

                    // Follow file format to get the data
                    string strData = input4.ReadString();
                    Console.WriteLine("Name: " + strData);

                    string strData2 = input4.ReadString();
                    Console.WriteLine("Country: " + strData2);

                    char charData = input4.ReadChar();
                    Console.WriteLine("Turn Mode: " + charData);

                    char charData2 = input4.ReadChar();
                    Console.WriteLine("Attack Mode: " + charData2);

                    double dbData = input4.ReadDouble();
                    Console.WriteLine("Cost: " + dbData);

                    int intData = input4.ReadInt32();
                    Console.WriteLine("Max Damage: " + intData);

                    input4.Close();
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Error reading file " + ioe.Message);
            }
        }
    }
}

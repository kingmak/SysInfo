using System;
using SystemMaloomat;

namespace SysInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            SysMaloomat maloomat = new SysMaloomat();
            SysMaloomat.ProccessorInfo procInfo = maloomat.getProccessorInfo();
            SysMaloomat.BiosInfo biosInfo = maloomat.getBiosInfo();
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Proccessor Information");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cpu speed     : {0} MHz, {1} Ghz", procInfo.cpuSpeed, procInfo.cpuSpeed / 1000.0);
            Console.WriteLine("Name          : {0}", procInfo.name);
            Console.WriteLine("Identifier    : {0}", procInfo.identifier);
            Console.WriteLine("Vendor        : {0}", procInfo.vendor);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bios Information");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Major release : {0}", biosInfo.majorRelease);
            Console.WriteLine("Minor release : {0}", biosInfo.minorRelease);
            Console.WriteLine("Release date  : {0}", biosInfo.releaseDate);
            Console.WriteLine("Vendor        : {0}", biosInfo.vendor);
            Console.WriteLine("Version       : {0}", biosInfo.version);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Base Board Information");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Manufacturer  : {0}", biosInfo.baseBoardManufacturer);
            Console.WriteLine("Prduct        : {0}", biosInfo.baseBoardProduct);
            Console.WriteLine("Version       : {0}", biosInfo.baseBoardVersion);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("System Information");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Family        : {0}", biosInfo.sysFamily);
            Console.WriteLine("Manufacturer  : {0}", biosInfo.sysManufacturer);
            Console.WriteLine("Product       : {0}", biosInfo.sysProductName);
            Console.WriteLine("SKU           : {0}", biosInfo.sysSKU);
            Console.WriteLine("Version       : {0}", biosInfo.sysVersion);

            Console.Write("\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.Write("This utility was created by : ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("KingMak @ github.com/kingmak");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.ResetColor(); // return to user's settings
            Console.Read();
        }
    }
}

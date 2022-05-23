using System;
// Name: Micah Curtis
// Course: IT 112
// NOTES: I used an abstract method inside of Phone and defined _dialer separately in both
// sub-classes to output the correct dial message.
// BEHAVIORS NOT IMPLENTED AND WHY: All behaviors present
namespace Curtis_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] phones = new Phone[10];
            phones[0] = new HomePhone("CompuTest", "(303)985-5060", 1);
            phones[1] = new CellPhone("Curtis Manufacturing", "(603)532-4123", 2);
            phones[2] = new HomePhone("Data Functions", "(800)876-2524", 1);
            phones[3] = new HomePhone("Donnay Repair", "(708)397-3330", 1);
            phones[4] = new HomePhone("ErgoNomic Inc", "(360)434-3894", 1);
            phones[5] = new HomePhone("ErgoSource", "(800)969-4374", 1);
            phones[6] = new CellPhone("Fox Bay Industries", "(800)874-8527", 2);
            phones[7] = new CellPhone("Glare-Guard", "(800)545-6254", 2);
            phones[8] = new CellPhone("Hazard Comm Specialists", "(407)783-6641", 2);
            phones[9] = new CellPhone("Komfort Support", "(714)472-4409", 2);

            ProcessCompanies(phones);
        }
         public static void ProcessCompanies(Phone[] phones)
        {
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i].Dial());
            }
        }

    }
}

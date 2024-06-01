using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models;
internal class SmartphoneTests
{
    public void TestNokiaSmartphone()
    {
        Nokia nokia = new Nokia("123456789", 16, 50);
        nokia.Ligar(); 
        nokia.ReceberLigacao(); 
        nokia.InstalarAplicativo("WhatsApp"); 
    }

    public void TestiPhoneSmartphone()
    {
        Iphone iphone = new Iphone("987654321", 64, 80);
        iphone.Ligar(); 
        iphone.ReceberLigacao(); 
        iphone.InstalarAplicativo("Instagram"); 
    }
}
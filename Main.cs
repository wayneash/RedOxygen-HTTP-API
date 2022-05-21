/*
 * Red Oxygen HTTP API test tool
 * Wayne Ash
 * v0.10
 */


Console.WriteLine("-----------------------------------------------------------------------------------");
Console.WriteLine("RedOxygen HTTP API test tool");
Console.WriteLine("https://redoxygen.com/");
Console.WriteLine("20/5/2022 WA v0.10");
Console.WriteLine("-----------------------------------------------------------------------------------");
Console.WriteLine("");
Console.WriteLine("Note:");
Console.WriteLine("1. Please ensure that http://www.redoxygen.net/sms.dll?Action=SendSMS is working");
Console.WriteLine("2. 4x ZEROS will be displayed in browser windows, if the page is loading okay");
Console.WriteLine("3. Sending email needs access rights in RedOxygen to send SMS!");
Console.WriteLine("-----------------------------------------------------------------------------------");
Console.WriteLine("");


// Details of valid RedOxygen account to send SMS
Console.WriteLine("Enter Red Oxygen Account ID (Eg:CI12345):");
var strAccountId = Console.ReadLine();
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("Enter Sending Email (Eg:Joe.Smith@xyz.com.au):");
var strEmail = Console.ReadLine();
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("Enter Password:");
var strPassword = Console.ReadLine();
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("Enter Recipient Mobile Number/s (eg:61411222333 or 61411222333,61422222333):");
var strMSISDN = Console.ReadLine();
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("Enter Test Message (Single SMS has 160 Character, max is 765 Characters):");
var strMessage = Console.ReadLine();

// Call sendsms with parameters


RedOxygen.SendSms(strAccountId,
                  strEmail,
                  strPassword,
                  strMSISDN,
                  strMessage);

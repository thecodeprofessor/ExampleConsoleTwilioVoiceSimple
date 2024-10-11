// Before You Begin
// Instructions for Setting Up Twilio:
// 1. Follow the instructions provided on your course Moodle page to set up your student Twilio account.
//    Make sure to note down your Account SID, Auth Token, and Twilio phone number, as you'll need them later.
// 2. Open your project in Visual Studio.
// 3. Go to the "Tools" menu at the top of the screen.
// 4. Select "NuGet Package Manager" > "Package Manager Console."
// 5. In the "Package Manager Console" window that opens, type the following command and press Enter:
//    Install-Package Twilio
// 6. Wait for the installation to complete. You should see messages indicating that the package has been installed successfully.
// 7. Enter your Twilio details: twilioAccountId, twilioAuthToken, twilioPhoneNumber
// 8. Update `Main`:
//    - Initialize with `TwilioClient.Init(twilioAccountId, twilioAuthToken);`
//    - Replace `SendVoiceMessage("phone_number_here", "Hello World");` with your own number and message
//    - Use the console to display call confirmation

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML;
using Twilio.TwiML.Voice;

namespace ExampleConsoleTwilioVoiceSimple
{
    internal class Program
    {
        // Twilio Account Information (replace with your actual account information)
        public static string twilioAccountId = "twilio_account_id_here";
        public static string twilioAuthToken = "twilio_auth_token_here";
        public static string twilioPhoneNumber = "twilio_phone_number_here";

        static void Main(string[] args)
        {
            // Initialize the Twilio client
            TwilioClient.Init(twilioAccountId, twilioAuthToken);

            //Place a voice call to a specified phone number in the format of +1XXXXXXXXX and say the words "Hello World" .
            //SendVoiceMessage("phone_number_here", "Hello World");
        }

        // Method to place a voice call with Text-to-Speech and gather user input
        public static string SendVoiceMessage(string recipientNumber, string messageBody, int waitSeconds = 5)
        {
            // Create the TwiML response for the call
            var voiceMessage = new VoiceResponse();

            // Text-to-speech message
            voiceMessage.Say(messageBody, voice: Say.VoiceEnum.Alice);

            // Wait 5 seconds before hanging up.
            voiceMessage.Pause(length: waitSeconds);

            // Create the call using Twilio's API
            var call = CallResource.Create(
                to: new PhoneNumber(recipientNumber),
                from: new PhoneNumber(twilioPhoneNumber),
                twiml: new Twilio.Types.Twiml(voiceMessage.ToString())
            );

            //OPTIONAL: You can display a message indicating the message has been sent that includes the call SID for tracking purposes.
            //Console.WriteLine($"Call placed with SID: {call.Sid}");
            return call.Sid;
        }
    }
}
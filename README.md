# Twilio Voice Integration Example

This program demonstrates how to use the Twilio API to place a voice call with text-to-speech functionality. It allows the user to send a voice message to a specified phone number, using Twilio's API to handle the call. 

## Features

- Place a voice call to any phone number.
- Use text-to-speech to deliver a custom message during the call.
- Include a delay before hanging up.
- Display call confirmation (optional).

## Prerequisites

Before running the program, make sure you have completed the following steps:

1. **Twilio Account Setup:**
   - Follow the instructions on your course's Moodle page to set up your student Twilio account.
   - Note down your **Account SID**, **Auth Token**, and **Twilio phone number**, as you'll need them for the program.

2. **NuGet Package:**
   - Install the **Twilio API Client Library** by running the following command in the **Package Manager Console**:
     ```
     Install-Package Twilio
     ```

## Setup Instructions

1. **Twilio API Configuration:**
   - Follow the instructions to set up your Twilio account.
   - Replace the placeholder values in the code with your actual `twilioAccountId`, `twilioAuthToken`, and `twilioPhoneNumber`.

2. **Project Directory Structure:**
   - Ensure your `Program.cs` file is located in the `src` directory of your solution.

3. **Running the Program:**
   - The program initializes the Twilio client using your account credentials.
   - It places a voice call to the specified phone number, reads out a text-to-speech message, and optionally waits before ending the call.

## Usage

### Initialize Twilio Client and Place a Call:
```csharp
TwilioClient.Init(twilioAccountId, twilioAuthToken);
SendVoiceMessage("phone_number_here", "Hello World");

## License
This program is for educational purposes and is provided as-is. Ensure that you follow best practices for securing sensitive information such as API credentials.

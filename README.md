
```markdown
# Bounceless-CSharp

This is a C# client for the [Bounceless.io](https://bounceless.io/) API.

## Requirements
* .NET Core 3.1 or later
* An API key from Bounceless.io

## Setup

Clone the repository to your local machine:

```bash
git clone https://github.com/bounceless/Bounceless-CSharp.git
```

Open the solution in your preferred IDE (like Visual Studio or JetBrains Rider). 

## Usage

In the `Program.cs` file, there are three methods to interact with the Bounceless API:

1. `VerifySingleEmail(string key, string email)` - This method verifies a single email address.
2. `UploadFile(string key, string filePath)` - This method uploads a CSV file of email addresses for bulk verification.
3. `GetFileInfo(string key, string fileId)` - This method retrieves the verification results of a previously uploaded file.

Replace the placeholders in the `Main` function with your actual API key, email address, file path, and file ID:

```csharp
static void Main(string[] args)
{
    VerifySingleEmail("PUT YOUR KEY HERE", "emailtoverify@example.com");
    UploadFile("PUT YOUR KEY HERE", "path\\to\\your\\file.csv");
    GetFileInfo("PUT YOUR KEY HERE", "FILE_ID");
}
```

Then run the program.

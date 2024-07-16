
# Project Setup and Execution

This guide provides step-by-step instructions to run the Selenium project created with the .NET 8 framework and the client application. Please follow the instructions carefully to ensure everything is set up correctly.

## Prerequisites

- .NET 8 SDK installed
- Selenium WebDriver and browser driver installed
- An IDE (e.g., Visual Studio, VS Code) for .NET development
- A suitable code editor or IDE for the client-side code

## Selenium Project Setup

1. **Clone the repository:**
   ```sh
   git clone <repository_url>
   cd <repository_directory>
   ```

2. **Open the project in your IDE (e.g., Visual Studio):**

3. **Check and update the file location:**
   Ensure that the file location in the Selenium project matches the location where your `site-data.json` file is located. Update the `fileLocation` variable if necessary.
   ```csharp
   private static readonly string fileLocation = "..\\..\\..\\..\\..\\client\\data\\site-data.json";
   ```

   - Verify if the relative path `"..\\..\\..\\..\\..\\client\\data\\site-data.json"` correctly points to the `site-data.json` file in the client directory.
   - Adjust the path if it does not match your system's file structure.

4. **Build and run the Selenium project:**
   - Open the terminal or use the IDE's build function.
   - Execute the build command:
     ```sh
     dotnet build
     ```
   - Run the Selenium tests:
     ```sh
     dotnet test
     ```

## Client Configuration
1. **Update the fetch URL if necessary:**
   Ensure the URL in your client application matches the URL where the Selenium project serves the `site-data.json` file. Update the fetch URL in your JavaScript code if necessary.
   ```javascript
   const jsonData = await fetch('http://localhost:59436/data/site-data.json')
                        .then((response) => response.json());
   ```

2. **Verify the client is fetching the data correctly:**
   - Open your browser and navigate to the client application.
   - Check the console or network tab in the developer tools to ensure the data is being fetched correctly.
   
3. **Run the client application from the server**
    **Note**: You must run the client from the server to avoid **CORS (Cross-Origin Resource Sharing) errors**.
## Troubleshooting

- **File location mismatch:**
  - If the file location in the Selenium project does not match your system's structure, adjust the `fileLocation` variable accordingly.

- **Fetch URL mismatch:**
  - If the client application is not able to fetch the `site-data.json` file, verify and update the URL in the fetch request to match the actual URL where the file is served.

- **Dependencies issues:**
  - Ensure all necessary dependencies are installed for both the Selenium project and the client application.


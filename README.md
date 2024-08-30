ST10262898_CLDV6212_POEPART1 Web Application

Overview

The ST10262898_CLDV6212_POEPART1 Web Application is an ASP.NET Core MVC project that interacts with various Azure services to handle file uploads, customer profile management, and order processing. The application is designed to demonstrate how to use Azure Blob Storage, File Storage, Queue Storage, and Table Storage within an ASP.NET Core application.

Features

Upload Image: Allows users to upload images to Azure Blob Storage.
Add Customer Profile: Enables the addition of customer profiles to Azure Table Storage.
Process Order: Sends messages to an Azure Queue for order processing.
Upload Contract: Allows users to upload contract files to Azure File Storage.
Project Structure

Controllers
HomeController.cs

Purpose: Handles HTTP requests related to image uploads, customer profiles, order processing, and contract uploads.
Dependencies: Utilizes services for interacting with Azure Blob Storage, Table Storage, Queue Storage, and File Storage.
Actions:
Index(): Renders the main view.
UploadImage(IFormFile file): Uploads an image to Azure Blob Storage.
AddCustomerProfile(CustomerProfile profile): Adds a customer profile to Azure Table Storage.
ProcessOrder(string orderId): Sends a message to Azure Queue Storage to process an order.
UploadContract(IFormFile file): Uploads a contract to Azure File Storage.
Models
CustomerProfile.cs

Purpose: Defines the customer profile entity for Azure Table Storage.
Properties:
PartitionKey: Partition key for the table.
RowKey: Unique identifier for the entity.
Timestamp: Entity timestamp.
ETag: Entity tag for concurrency control.
FirstName: Customer's first name.
LastName: Customer's last name.
Email: Customer's email address.
PhoneNumber: Customer's phone number.
ErrorViewModel.cs

Purpose: Represents an error view model for displaying error information.
Properties:
RequestId: ID for the error request.
ShowRequestId: Indicates if the request ID should be displayed.
Services
BlobService.cs

Purpose: Provides methods for uploading blobs to Azure Blob Storage.
Methods:
UploadBlobAsync(string containerName, string blobName, Stream content): Uploads a blob to the specified container.
FileService.cs

Purpose: Provides methods for uploading files to Azure File Storage.
Methods:
UploadFileAsync(string shareName, string fileName, Stream content): Uploads a file to the specified share.
QueueService.cs

Purpose: Provides methods for sending messages to Azure Queue Storage.
Methods:
SendMessageAsync(string queueName, string message): Sends a message to the specified queue.
TableService.cs

Purpose: Provides methods for interacting with Azure Table Storage.
Methods:
AddEntityAsync(CustomerProfile profile): Adds a customer profile entity to the table.
Views
Index.cshtml

Purpose: Provides forms for the following operations:
Upload Image: Upload an image file to Azure Blob Storage.
Add Customer Profile: Submit customer profile information to Azure Table Storage.
Process Order: Submit an order ID to Azure Queue Storage.
Upload Contract: Upload a contract file to Azure File Storage.
Configuration

Install Dependencies: Ensure that the necessary Azure SDK packages are installed:
Azure.Storage.Blobs
Azure.Storage.Files.Shares
Azure.Storage.Queues
Azure.Data.Tables
Configure Azure Storage: Update your appsettings.json file with your Azure Storage connection string:
{
  "AzureStorage": {
    "ConnectionString": "Your_Azure_Storage_Connection_String"
  }
}
Run the Application:
Use dotnet run to start the application.
Access the application via the URLs specified in launchSettings.json.
Access the Application:
Navigate to http://localhost:5220 or https://localhost:7131 based on your configuration to interact with the application's features.
